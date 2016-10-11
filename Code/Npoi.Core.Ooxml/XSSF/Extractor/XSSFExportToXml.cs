/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */

using System;
using Npoi.Core.XSSF.UserModel;
using System.Xml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Npoi.Core.XSSF.UserModel.Helpers;
using System.Text.RegularExpressions;
using Npoi.Core.OpenXmlFormats.Spreadsheet;
using Npoi.Core.SS.UserModel;
using System.Text;
using System.Xml.Linq;

namespace Npoi.Core.XSSF.Extractor
{

    /**
     *
     * Maps an XLSX to an XML according to one of the mapping defined.
     *
     *
     * The output XML Schema must respect this limitations:
     *
     * <ul>
     * <li> all mandatory elements and attributes must be mapped (enable validation to check this)</li>
     *
     * <li> no &lt;any&gt; in complex type/element declaration </li>
     * <li> no &lt;anyAttribute&gt; attributes declaration </li>
     * <li> no recursive structures: recursive structures can't be nested more than one level </li>
     * <li> no abstract elements: abstract complex types can be declared but must not be used in elements. </li>
     * <li> no mixed content: an element can't contain simple text and child element(s) together </li>
     * <li> no &lt;substitutionGroup&gt; in complex type/element declaration </li>
     * </ul>
     */
    public class XSSFExportToXml : IComparer<String>
    {

        private XSSFMap map;

        /**
         * Creates a new exporter and Sets the mapping to be used when generating the XML output document
         *
         * @param map the mapping rule to be used
         */
        public XSSFExportToXml(XSSFMap map)
        {
            this.map = map;
        }

        /**
         *
         * Exports the data in an XML stream
         *
         * @param os OutputStream in which will contain the output XML
         * @param validate if true, validates the XML againts the XML Schema
         * @throws SAXException
         * @throws TransformerException  
         * @throws ParserConfigurationException 
         */
        public void ExportToXML(Stream os, bool validate)
        {
            ExportToXML(os, "UTF-8", validate);
        }

        private XDocument GetEmptyDocument()
        {
            return new XDocument();
        }

        /**
         * Exports the data in an XML stream
         *
         * @param os OutputStream in which will contain the output XML
         * @param encoding the output charset encoding
         * @param validate if true, validates the XML againts the XML Schema
         * @throws SAXException
         * @throws ParserConfigurationException 
         * @throws TransformerException 
         * @throws InvalidFormatException
         */
        public void ExportToXML(Stream os, String encoding, bool validate)
        {
            List<XSSFSingleXmlCell> SingleXMLCells = map.GetRelatedSingleXMLCell();
            List<XSSFTable> tables = map.GetRelatedTables();

            String rootElement = map.GetCTMap().RootElement;

            XDocument doc = GetEmptyDocument();


            XElement root = null;

            if (IsNamespaceDeclared())
            {
                root = new XElement((XNamespace)this.GetNamespace() + rootElement);
            }
            else
            {
                root = doc.CreateElement(rootElement);
            }
            doc.AppendChild(root);


            List<String> xpaths = new List<String>();
            Dictionary<String, XSSFSingleXmlCell> SingleXmlCellsMappings = new Dictionary<String, XSSFSingleXmlCell>();
            Dictionary<String, XSSFTable> tableMappings = new Dictionary<String, XSSFTable>();

            foreach (XSSFSingleXmlCell simpleXmlCell in SingleXMLCells)
            {
                xpaths.Add(simpleXmlCell.GetXpath());
                SingleXmlCellsMappings[simpleXmlCell.GetXpath()] = simpleXmlCell;
            }
            foreach (XSSFTable table in tables)
            {
                String commonXPath = table.GetCommonXpath();
                xpaths.Add(commonXPath);
                tableMappings[commonXPath] = table;
            }


            xpaths.Sort();

            foreach (String xpath in xpaths)
            {

                XSSFSingleXmlCell simpleXmlCell;
                if (SingleXmlCellsMappings.ContainsKey(xpath))
                    simpleXmlCell = SingleXmlCellsMappings[xpath];
                else
                    simpleXmlCell = null;
                XSSFTable table;
                if (tableMappings.ContainsKey(xpath))
                    table = tableMappings[xpath];
                else
                    table = null;

                if (!Regex.IsMatch(xpath, ".*\\[.*"))
                {

                    // Exports elements and attributes mapped with simpleXmlCell
                    if (simpleXmlCell != null)
                    {
                        XSSFCell cell = (XSSFCell)simpleXmlCell.GetReferencedCell();
                        if (cell != null)
                        {
                            XElement currentNode = GetNodeByXPath(xpath, doc.Root.FirstNode as XElement, doc, false);
                            ST_XmlDataType dataType = simpleXmlCell.GetXmlDataType();
                            mapCellOnNode(cell, currentNode, dataType);
                        }
                    }

                    // Exports elements and attributes mapped with tables
                    if (table != null)
                    {

                        List<XSSFXmlColumnPr> tableColumns = table.GetXmlColumnPrs();

                        XSSFSheet sheet = table.GetXSSFSheet();

                        int startRow = table.GetStartCellReference().Row;
                        // In mappings Created with Microsoft Excel the first row Contains the table header and must be Skipped
                        startRow += 1;

                        int endRow = table.GetEndCellReference().Row;

                        for (int i = startRow; i <= endRow; i++)
                        {
                            XSSFRow row = (XSSFRow)sheet.GetRow(i);

                            XElement tableRootNode = GetNodeByXPath(table.GetCommonXpath(), doc.Root.FirstNode as XElement, doc, true);

                            short startColumnIndex = table.GetStartCellReference().Col;
                            for (int j = startColumnIndex; j <= table.GetEndCellReference().Col; j++)
                            {
                                XSSFCell cell = (XSSFCell)row.GetCell(j);
                                if (cell != null)
                                {
                                    XSSFXmlColumnPr pointer = tableColumns[j - startColumnIndex];
                                    String localXPath = pointer.GetLocalXPath();
                                    XElement currentNode = GetNodeByXPath(localXPath, tableRootNode, doc, false);
                                    ST_XmlDataType dataType = pointer.GetXmlDataType();


                                    mapCellOnNode(cell, currentNode, dataType);
                                }

                            }

                        }

                    }
                }
                else
                {
                    // TODO:  implement filtering management in xpath
                }
            }

            bool isValid = true;
            if (validate)
            {
                isValid = this.IsValid(doc);
            }



            if (isValid)
            {

                /////////////////
                //Output the XML
                XmlWriterSettings settings = new XmlWriterSettings();
                //settings.OmitXmlDeclaration=false;
                settings.Indent = true;
                settings.Encoding = Encoding.GetEncoding(encoding);
                //create string from xml tree
                using (XmlWriter xmlWriter = XmlWriter.Create(os, settings))
                {
                    doc.WriteTo(xmlWriter);
                }
            }
        }


        /**
         * Validate the generated XML against the XML Schema associated with the XSSFMap
         *
         * @param xml the XML to validate
         * @return
         */
        private bool IsValid(XDocument xml)
        {
            //bool isValid = false;
            //try
            //{
            //    String language = "http://www.w3.org/2001/XMLSchema";
            //    SchemaFactory factory = SchemaFactory.newInstance(language);

            //    Source source = new DOMSource(map.GetSchema());
            //    Schema schema = factory.newSchema(source);
            //    XmlValidator validator = schema.newValidator();
            //    validator.validate(new DOMSource(xml));
            //    //if no exceptions where raised, the document is valid
            //    isValid = true;


            //}
            //catch (IOException e)
            //{
            //    e.printStackTrace();
            //}
            //return isValid;
            return true;
        }


        private void mapCellOnNode(XSSFCell cell, XElement node, ST_XmlDataType outputDataType)
        {

            String value = "";
            switch (cell.CellType)
            {

                case CellType.String: value = cell.StringCellValue; break;
                case CellType.Boolean: value += cell.BooleanCellValue; break;
                case CellType.Error: value = cell.ErrorCellString; break;
                case CellType.Formula: value = cell.StringCellValue; break;
                case CellType.Numeric: value += cell.GetRawValue(); break;
                default:
                    break;
            }
            if (node is XElement)
            {
                XElement currentElement = (XElement)node;
                currentElement.Value = value;
            }
            else
            {
                node.Value = value;
            }
        }

        private String RemoveNamespace(String elementName)
        {
            return Regex.IsMatch(elementName, ".*:.*") ? elementName.Split(new char[] { ':' })[1] : elementName;
        }



        private XElement GetNodeByXPath(String xpath, XElement rootNode, XDocument doc, bool CreateMultipleInstances)
        {
            String[] xpathTokens = xpath.Split(new char[] { '/' });


            XElement currentNode = rootNode;
            // The first token is empty, the second is the root node
            for (int i = 2; i < xpathTokens.Length; i++)
            {

                String axisName = RemoveNamespace(xpathTokens[i]);


                if (!axisName.StartsWith("@"))
                {

                    var list = currentNode.ChildElements().ToList();

                    XElement selectedNode = null;
                    if (!(CreateMultipleInstances && i == xpathTokens.Length - 1))
                    {
                        // select the last child node only if we need to map to a single cell
                        selectedNode = selectNode(axisName, list);
                    }
                    if (selectedNode == null)
                    {
                        selectedNode = CreateElement(doc, currentNode, axisName);
                    }
                    currentNode = selectedNode;
                }
                else
                {
                    var attribute = CreateAttribute(doc, currentNode, axisName);

                    //currentNode = attribute;
                }
            }
            return currentNode;
        }

        private XAttribute CreateAttribute(XDocument doc, XElement currentNode, String axisName)
        {
            String attributeName = axisName.Substring(1);
            var attribute = currentNode.Attribute(attributeName);
            if (attribute == null)
            {
                attribute = new XAttribute(attributeName, "");
                currentNode.Add(attribute);
            }
            return attribute;
        }

        private XElement CreateElement(XDocument doc, XElement currentNode, String axisName)
        {
            XElement selectedNode;
            if (IsNamespaceDeclared())
            {
                selectedNode = new XElement((XNamespace)GetNamespace() + axisName);
            }
            else
            {
                selectedNode = doc.CreateElement(axisName);
            }
            currentNode.AppendChild(selectedNode);
            return selectedNode;
        }

        private XElement selectNode(String axisName, IList<XElement> list)
        {
            XElement selectedNode = null;
            for (int j = 0; j < list.Count; j++)
            {
                XElement node = list[j];
                if (node.Name.Equals(axisName))
                {
                    selectedNode = node;
                    break;
                }
            }
            return selectedNode;
        }


        private bool IsNamespaceDeclared()
        {
            String schemaNamespace = GetNamespace();
            return schemaNamespace != null && !schemaNamespace.Equals("");
        }

        private String GetNamespace()
        {
            return map.GetCTSchema().Namespace;
        }


        /**
         * Compares two xpaths to define an ordering according to the XML Schema
         *
         */
        public int Compare(String leftXpath, String rightXpath)
        {

            int result = 0;
            string xmlSchema = map.GetSchema();
            XDocument doc = XDocument.Load(new StringReader(xmlSchema));

            String[] leftTokens = leftXpath.Split(new char[] { '/' });
            String[] rightTokens = rightXpath.Split(new char[] { '/' });

            int minLenght = leftTokens.Length < rightTokens.Length ? leftTokens.Length : rightTokens.Length;

            XElement localComplexTypeRootNode = doc.Document.Root;


            for (int i = 1; i < minLenght; i++)
            {

                String leftElementName = leftTokens[i];
                String rightElementName = rightTokens[i];

                if (leftElementName.Equals(rightElementName))
                {
                    XElement complexType = GetComplexTypeForElement(leftElementName, doc.Document.Root, localComplexTypeRootNode);
                    localComplexTypeRootNode = complexType;
                }
                else
                {
                    int leftIndex = IndexOfElementInComplexType(leftElementName, localComplexTypeRootNode);
                    int rightIndex = IndexOfElementInComplexType(rightElementName, localComplexTypeRootNode);
                    if (leftIndex != -1 && rightIndex != -1)
                    {
                        if (leftIndex < rightIndex)
                        {
                            result = -1;
                        }
                        if (leftIndex > rightIndex)
                        {
                            result = 1;
                        }
                    }
                    else
                    {
                        // NOTE: the xpath doesn't match correctly in the schema
                    }
                }
            }

            return result;
        }

        private int IndexOfElementInComplexType(String elementName, XElement complexType)
        {
            var list = complexType.ChildElements().ToList();
            int indexOf = -1;

            for (int i = 0; i < list.Count; i++)
            {
                XElement node = list[i];
                if (node.Name.LocalName.Equals("element"))
                {
                    var nameAttribute = node.Attribute("name");
                    if (nameAttribute.Value.Equals(RemoveNamespace(elementName)))
                    {
                        indexOf = i;
                        break;
                    }
                }
            }
            return indexOf;
        }

        private XElement GetComplexTypeForElement(String elementName, XElement xmlSchema, XElement localComplexTypeRootNode)
        {
            XElement complexTypeNode = null;

            String elementNameWithoutNamespace = RemoveNamespace(elementName);


            var list = localComplexTypeRootNode.ChildElements().ToList();
            String complexTypeName = "";



            for (int i = 0; i < list.Count; i++)
            {
                XElement node = list[i];
                if (node.Name.LocalName.Equals("element"))
                {
                    var nameAttribute = node.Attribute("name");
                    if (nameAttribute.Value.Equals(elementNameWithoutNamespace))
                    {
                        var complexTypeAttribute = node.Attribute("type");
                        if (complexTypeAttribute != null)
                        {
                            complexTypeName = complexTypeAttribute.Value;
                            break;
                        }
                    }
                }
            }
            // Note: we expect that all the complex types are defined at root level
            if (!"".Equals(complexTypeName))
            {
                var complexTypeList = xmlSchema.ChildElements().ToList();
                for (int i = 0; i < complexTypeList.Count; i++)
                {
                    XElement node = list[i];
                    if (node is XElement)
                    {
                        if (node.Name.LocalName.Equals("complexType"))
                        {
                            var nameAttribute = node.Attribute("name");
                            if (nameAttribute.Value.Equals(complexTypeName))
                            {

                                var complexTypeChildList = node.ChildElements().ToList();
                                for (int j = 0; j < complexTypeChildList.Count; j++)
                                {
                                    XElement sequence = complexTypeChildList[j];

                                    if (sequence is XElement)
                                    {
                                        if (sequence.Name.LocalName.Equals("sequence"))
                                        {
                                            complexTypeNode = sequence;
                                            break;
                                        }
                                    }
                                }
                                if (complexTypeNode != null)
                                {
                                    break;
                                }

                            }
                        }
                    }
                }
            }
            return complexTypeNode;
        }
    }
}
