using NPOI.OpenXml4Net.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
    [Serializable]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot("table", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public class CT_Table
    {

        private CT_AutoFilter autoFilterField;

        private CT_SortState sortStateField;

        private CT_TableColumns tableColumnsField;

        private CT_TableStyleInfo tableStyleInfoField;

        private CT_ExtensionList extLstField;

        private uint idField;

        private string nameField;

        private string displayNameField;

        private string commentField;

        private string refField;

        private ST_TableType tableTypeField;

        private uint headerRowCountField;

        private bool insertRowField;

        private bool insertRowShiftField;

        private uint totalsRowCountField;

        private bool totalsRowShownField;

        private bool publishedField;

        private uint headerRowDxfIdField;

        private bool headerRowDxfIdFieldSpecified;

        private uint dataDxfIdField;

        private bool dataDxfIdFieldSpecified;

        private uint totalsRowDxfIdField;

        private bool totalsRowDxfIdFieldSpecified;

        private uint headerRowBorderDxfIdField;

        private bool headerRowBorderDxfIdFieldSpecified;

        private uint tableBorderDxfIdField;

        private bool tableBorderDxfIdFieldSpecified;

        private uint totalsRowBorderDxfIdField;

        private bool totalsRowBorderDxfIdFieldSpecified;

        private string headerRowCellStyleField;

        private string dataCellStyleField;

        private string totalsRowCellStyleField;

        private uint connectionIdField;

        private bool connectionIdFieldSpecified;

        public CT_Table()
        {
            //this.extLstField = new CT_ExtensionList();
            //this.tableStyleInfoField = new CT_TableStyleInfo();
            //this.tableColumnsField = new CT_TableColumns();
            //this.sortStateField = new CT_SortState();
            //this.autoFilterField = new CT_AutoFilter();
            this.tableTypeField = ST_TableType.worksheet;
            this.headerRowCountField = ((uint)(1));
            this.insertRowField = false;
            this.insertRowShiftField = false;
            this.totalsRowCountField = ((uint)(0));
            this.totalsRowShownField = true;
            this.publishedField = false;
        }
        public static CT_Table Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Table ctObj = new CT_Table();
            if (node.Attribute("id") != null)
                ctObj.id = XmlHelper.ReadUInt(node.Attribute("id"));
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            ctObj.displayName = XmlHelper.ReadString(node.Attribute("displayName"));
            ctObj.comment = XmlHelper.ReadString(node.Attribute("comment"));
            ctObj.@ref = XmlHelper.ReadString(node.Attribute("ref"));
            if (node.Attribute("tableType") != null)
                ctObj.tableType = (ST_TableType)Enum.Parse(typeof(ST_TableType), node.Attribute("tableType").Value);
            if (node.Attribute("headerRowCount") != null)
                ctObj.headerRowCount = XmlHelper.ReadUInt(node.Attribute("headerRowCount"));
            if (node.Attribute("insertRow") != null)
                ctObj.insertRow = XmlHelper.ReadBool(node.Attribute("insertRow"));
            if (node.Attribute("insertRowShift") != null)
                ctObj.insertRowShift = XmlHelper.ReadBool(node.Attribute("insertRowShift"));
            if (node.Attribute("totalsRowCount") != null)
                ctObj.totalsRowCount = XmlHelper.ReadUInt(node.Attribute("totalsRowCount"));
            if (node.Attribute("totalsRowShown") != null)
                ctObj.totalsRowShown = XmlHelper.ReadBool(node.Attribute("totalsRowShown"));
            if (node.Attribute("published") != null)
                ctObj.published = XmlHelper.ReadBool(node.Attribute("published"));
            if (node.Attribute("headerRowDxfId") != null)
                ctObj.headerRowDxfId = XmlHelper.ReadUInt(node.Attribute("headerRowDxfId"));
            if (node.Attribute("dataDxfId") != null)
                ctObj.dataDxfId = XmlHelper.ReadUInt(node.Attribute("dataDxfId"));
            if (node.Attribute("totalsRowDxfId") != null)
                ctObj.totalsRowDxfId = XmlHelper.ReadUInt(node.Attribute("totalsRowDxfId"));
            if (node.Attribute("headerRowBorderDxfId") != null)
                ctObj.headerRowBorderDxfId = XmlHelper.ReadUInt(node.Attribute("headerRowBorderDxfId"));
            if (node.Attribute("tableBorderDxfId") != null)
                ctObj.tableBorderDxfId = XmlHelper.ReadUInt(node.Attribute("tableBorderDxfId"));
            if (node.Attribute("totalsRowBorderDxfId") != null)
                ctObj.totalsRowBorderDxfId = XmlHelper.ReadUInt(node.Attribute("totalsRowBorderDxfId"));
            ctObj.headerRowCellStyle = XmlHelper.ReadString(node.Attribute("headerRowCellStyle"));
            ctObj.dataCellStyle = XmlHelper.ReadString(node.Attribute("dataCellStyle"));
            ctObj.totalsRowCellStyle = XmlHelper.ReadString(node.Attribute("totalsRowCellStyle"));
            if (node.Attribute("connectionId") != null)
                ctObj.connectionId = XmlHelper.ReadUInt(node.Attribute("connectionId"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "autoFilter")
                    ctObj.autoFilter = CT_AutoFilter.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "sortState")
                    ctObj.sortState = CT_SortState.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "tableColumns")
                    ctObj.tableColumns = CT_TableColumns.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "tableStyleInfo")
                    ctObj.tableStyleInfo = CT_TableStyleInfo.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw)
        {

            sw.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
            sw.Write("<table xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\"");
            XmlHelper.WriteAttribute(sw, "id", this.id);
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "displayName", this.displayName);
            XmlHelper.WriteAttribute(sw, "comment", this.comment);
            XmlHelper.WriteAttribute(sw, "ref", this.@ref);
            XmlHelper.WriteAttribute(sw, "tableType", this.tableType.ToString());
            XmlHelper.WriteAttribute(sw, "headerRowCount", this.headerRowCount);
            XmlHelper.WriteAttribute(sw, "insertRow", this.insertRow);
            XmlHelper.WriteAttribute(sw, "insertRowShift", this.insertRowShift);
            XmlHelper.WriteAttribute(sw, "totalsRowCount", this.totalsRowCount);
            XmlHelper.WriteAttribute(sw, "totalsRowShown", this.totalsRowShown);
            XmlHelper.WriteAttribute(sw, "published", this.published);
            XmlHelper.WriteAttribute(sw, "headerRowDxfId", this.headerRowDxfId);
            XmlHelper.WriteAttribute(sw, "dataDxfId", this.dataDxfId);
            XmlHelper.WriteAttribute(sw, "totalsRowDxfId", this.totalsRowDxfId);
            XmlHelper.WriteAttribute(sw, "headerRowBorderDxfId", this.headerRowBorderDxfId);
            XmlHelper.WriteAttribute(sw, "tableBorderDxfId", this.tableBorderDxfId);
            XmlHelper.WriteAttribute(sw, "totalsRowBorderDxfId", this.totalsRowBorderDxfId);
            XmlHelper.WriteAttribute(sw, "headerRowCellStyle", this.headerRowCellStyle);
            XmlHelper.WriteAttribute(sw, "dataCellStyle", this.dataCellStyle);
            XmlHelper.WriteAttribute(sw, "totalsRowCellStyle", this.totalsRowCellStyle);
            XmlHelper.WriteAttribute(sw, "connectionId", this.connectionId);
            sw.Write(">");
            if (this.autoFilter != null)
                this.autoFilter.Write(sw, "autoFilter");
            if (this.sortState != null)
                this.sortState.Write(sw, "sortState");
            if (this.tableColumns != null)
                this.tableColumns.Write(sw, "tableColumns");
            if (this.tableStyleInfo != null)
                this.tableStyleInfo.Write(sw, "tableStyleInfo");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write("</table>");
        }

        [XmlElement]
        public CT_AutoFilter autoFilter
        {
            get
            {
                return this.autoFilterField;
            }
            set
            {
                this.autoFilterField = value;
            }
        }
        [XmlElement]
        public CT_SortState sortState
        {
            get
            {
                return this.sortStateField;
            }
            set
            {
                this.sortStateField = value;
            }
        }
        [XmlElement]
        public CT_TableColumns tableColumns
        {
            get
            {
                return this.tableColumnsField;
            }
            set
            {
                this.tableColumnsField = value;
            }
        }
        [XmlElement]
        public CT_TableStyleInfo tableStyleInfo
        {
            get
            {
                return this.tableStyleInfoField;
            }
            set
            {
                this.tableStyleInfoField = value;
            }
        }
        [XmlElement]
        public CT_ExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }
        [XmlAttribute]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        [XmlAttribute]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        [XmlAttribute]
        public string displayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }
        [XmlAttribute]
        public string comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }
        [XmlAttribute]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(ST_TableType.worksheet)]
        public ST_TableType tableType
        {
            get
            {
                return this.tableTypeField;
            }
            set
            {
                this.tableTypeField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(typeof(uint), "1")]
        public uint headerRowCount
        {
            get
            {
                return this.headerRowCountField;
            }
            set
            {
                this.headerRowCountField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool insertRow
        {
            get
            {
                return this.insertRowField;
            }
            set
            {
                this.insertRowField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool insertRowShift
        {
            get
            {
                return this.insertRowShiftField;
            }
            set
            {
                this.insertRowShiftField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(typeof(uint), "0")]
        public uint totalsRowCount
        {
            get
            {
                return this.totalsRowCountField;
            }
            set
            {
                this.totalsRowCountField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(true)]
        public bool totalsRowShown
        {
            get
            {
                return this.totalsRowShownField;
            }
            set
            {
                this.totalsRowShownField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool published
        {
            get
            {
                return this.publishedField;
            }
            set
            {
                this.publishedField = value;
            }
        }
        [XmlAttribute]
        public uint headerRowDxfId
        {
            get
            {
                return this.headerRowDxfIdField;
            }
            set
            {
                this.headerRowDxfIdField = value;
            }
        }
        [XmlIgnore]
        public bool headerRowDxfIdSpecified
        {
            get
            {
                return this.headerRowDxfIdFieldSpecified;
            }
            set
            {
                this.headerRowDxfIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public uint dataDxfId
        {
            get
            {
                return this.dataDxfIdField;
            }
            set
            {
                this.dataDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool dataDxfIdSpecified
        {
            get
            {
                return this.dataDxfIdFieldSpecified;
            }
            set
            {
                this.dataDxfIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public uint totalsRowDxfId
        {
            get
            {
                return this.totalsRowDxfIdField;
            }
            set
            {
                this.totalsRowDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool totalsRowDxfIdSpecified
        {
            get
            {
                return this.totalsRowDxfIdFieldSpecified;
            }
            set
            {
                this.totalsRowDxfIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public uint headerRowBorderDxfId
        {
            get
            {
                return this.headerRowBorderDxfIdField;
            }
            set
            {
                this.headerRowBorderDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool headerRowBorderDxfIdSpecified
        {
            get
            {
                return this.headerRowBorderDxfIdFieldSpecified;
            }
            set
            {
                this.headerRowBorderDxfIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public uint tableBorderDxfId
        {
            get
            {
                return this.tableBorderDxfIdField;
            }
            set
            {
                this.tableBorderDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool tableBorderDxfIdSpecified
        {
            get
            {
                return this.tableBorderDxfIdFieldSpecified;
            }
            set
            {
                this.tableBorderDxfIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public uint totalsRowBorderDxfId
        {
            get
            {
                return this.totalsRowBorderDxfIdField;
            }
            set
            {
                this.totalsRowBorderDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool totalsRowBorderDxfIdSpecified
        {
            get
            {
                return this.totalsRowBorderDxfIdFieldSpecified;
            }
            set
            {
                this.totalsRowBorderDxfIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public string headerRowCellStyle
        {
            get
            {
                return this.headerRowCellStyleField;
            }
            set
            {
                this.headerRowCellStyleField = value;
            }
        }
        [XmlAttribute]
        public string dataCellStyle
        {
            get
            {
                return this.dataCellStyleField;
            }
            set
            {
                this.dataCellStyleField = value;
            }
        }
        [XmlAttribute]
        public string totalsRowCellStyle
        {
            get
            {
                return this.totalsRowCellStyleField;
            }
            set
            {
                this.totalsRowCellStyleField = value;
            }
        }
        [XmlAttribute]
        public uint connectionId
        {
            get
            {
                return this.connectionIdField;
            }
            set
            {
                this.connectionIdField = value;
            }
        }

        [XmlIgnore]
        public bool connectionIdSpecified
        {
            get
            {
                return this.connectionIdFieldSpecified;
            }
            set
            {
                this.connectionIdFieldSpecified = value;
            }
        }
    }
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_TableColumns
    {

        private List<CT_TableColumn> tableColumnField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_TableColumns()
        {
            //this.tableColumnField = new List<CT_TableColumn>();
        }
        public static CT_TableColumns Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_TableColumns ctObj = new CT_TableColumns();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.tableColumn = new List<CT_TableColumn>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "tableColumn")
                    ctObj.tableColumn.Add(CT_TableColumn.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.tableColumn != null)
            {
                foreach (CT_TableColumn x in this.tableColumn)
                {
                    x.Write(sw, "tableColumn");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        [XmlElement]
        public List<CT_TableColumn> tableColumn
        {
            get
            {
                return this.tableColumnField;
            }
            set
            {
                this.tableColumnField = value;
            }
        }
        [XmlAttribute]
        public uint count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        [XmlIgnore]
        public bool countSpecified
        {
            get
            {
                return this.countFieldSpecified;
            }
            set
            {
                this.countFieldSpecified = value;
            }
        }
    }
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_TableColumn
    {

        private CT_TableFormula calculatedColumnFormulaField;

        private CT_TableFormula totalsRowFormulaField;

        private CT_XmlColumnPr xmlColumnPrField;

        private CT_ExtensionList extLstField;

        private uint idField;

        private string uniqueNameField;

        private string nameField;

        private ST_TotalsRowFunction totalsRowFunctionField;

        private string totalsRowLabelField;

        private uint queryTableFieldIdField;

        private bool queryTableFieldIdFieldSpecified;

        private uint headerRowDxfIdField;

        private bool headerRowDxfIdFieldSpecified;

        private uint dataDxfIdField;

        private bool dataDxfIdFieldSpecified;

        private uint totalsRowDxfIdField;

        private bool totalsRowDxfIdFieldSpecified;

        private string headerRowCellStyleField;

        private string dataCellStyleField;

        private string totalsRowCellStyleField;

        public CT_TableColumn()
        {
            //this.extLstField = new CT_ExtensionList();
            //this.xmlColumnPrField = new CT_XmlColumnPr();
            //this.totalsRowFormulaField = new CT_TableFormula();
            //this.calculatedColumnFormulaField = new CT_TableFormula();
            this.totalsRowFunctionField = ST_TotalsRowFunction.none;
        }
        public static CT_TableColumn Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_TableColumn ctObj = new CT_TableColumn();
            if (node.Attribute("id") != null)
                ctObj.id = XmlHelper.ReadUInt(node.Attribute("id"));
            ctObj.uniqueName = XmlHelper.ReadString(node.Attribute("uniqueName"));
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            if (node.Attribute("totalsRowFunction") != null)
                ctObj.totalsRowFunction = (ST_TotalsRowFunction)Enum.Parse(typeof(ST_TotalsRowFunction), node.Attribute("totalsRowFunction").Value);
            ctObj.totalsRowLabel = XmlHelper.ReadString(node.Attribute("totalsRowLabel"));
            if (node.Attribute("queryTableFieldId") != null)
                ctObj.queryTableFieldId = XmlHelper.ReadUInt(node.Attribute("queryTableFieldId"));
            if (node.Attribute("headerRowDxfId") != null)
                ctObj.headerRowDxfId = XmlHelper.ReadUInt(node.Attribute("headerRowDxfId"));
            if (node.Attribute("dataDxfId") != null)
                ctObj.dataDxfId = XmlHelper.ReadUInt(node.Attribute("dataDxfId"));
            if (node.Attribute("totalsRowDxfId") != null)
                ctObj.totalsRowDxfId = XmlHelper.ReadUInt(node.Attribute("totalsRowDxfId"));
            ctObj.headerRowCellStyle = XmlHelper.ReadString(node.Attribute("headerRowCellStyle"));
            ctObj.dataCellStyle = XmlHelper.ReadString(node.Attribute("dataCellStyle"));
            ctObj.totalsRowCellStyle = XmlHelper.ReadString(node.Attribute("totalsRowCellStyle"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "calculatedColumnFormula")
                    ctObj.calculatedColumnFormula = CT_TableFormula.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "totalsRowFormula")
                    ctObj.totalsRowFormula = CT_TableFormula.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "xmlColumnPr")
                    ctObj.xmlColumnPr = CT_XmlColumnPr.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "id", this.id);
            XmlHelper.WriteAttribute(sw, "uniqueName", this.uniqueName);
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "totalsRowFunction", this.totalsRowFunction.ToString());
            XmlHelper.WriteAttribute(sw, "totalsRowLabel", this.totalsRowLabel);
            XmlHelper.WriteAttribute(sw, "queryTableFieldId", this.queryTableFieldId);
            XmlHelper.WriteAttribute(sw, "headerRowDxfId", this.headerRowDxfId);
            XmlHelper.WriteAttribute(sw, "dataDxfId", this.dataDxfId);
            XmlHelper.WriteAttribute(sw, "totalsRowDxfId", this.totalsRowDxfId);
            XmlHelper.WriteAttribute(sw, "headerRowCellStyle", this.headerRowCellStyle);
            XmlHelper.WriteAttribute(sw, "dataCellStyle", this.dataCellStyle);
            XmlHelper.WriteAttribute(sw, "totalsRowCellStyle", this.totalsRowCellStyle);
            sw.Write(">");
            if (this.calculatedColumnFormula != null)
                this.calculatedColumnFormula.Write(sw, "calculatedColumnFormula");
            if (this.totalsRowFormula != null)
                this.totalsRowFormula.Write(sw, "totalsRowFormula");
            if (this.xmlColumnPr != null)
                this.xmlColumnPr.Write(sw, "xmlColumnPr");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        [XmlElement]
        public CT_TableFormula calculatedColumnFormula
        {
            get
            {
                return this.calculatedColumnFormulaField;
            }
            set
            {
                this.calculatedColumnFormulaField = value;
            }
        }
        [XmlElement]
        public CT_TableFormula totalsRowFormula
        {
            get
            {
                return this.totalsRowFormulaField;
            }
            set
            {
                this.totalsRowFormulaField = value;
            }
        }
        public CT_XmlColumnPr xmlColumnPr
        {
            get
            {
                return this.xmlColumnPrField;
            }
            set
            {
                this.xmlColumnPrField = value;
            }
        }
        [XmlElement]
        public CT_ExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }
        [XmlAttribute]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        [XmlAttribute]
        public string uniqueName
        {
            get
            {
                return this.uniqueNameField;
            }
            set
            {
                this.uniqueNameField = value;
            }
        }
        [XmlAttribute]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(ST_TotalsRowFunction.none)]
        public ST_TotalsRowFunction totalsRowFunction
        {
            get
            {
                return this.totalsRowFunctionField;
            }
            set
            {
                this.totalsRowFunctionField = value;
            }
        }
        [XmlAttribute]
        public string totalsRowLabel
        {
            get
            {
                return this.totalsRowLabelField;
            }
            set
            {
                this.totalsRowLabelField = value;
            }
        }
        [XmlAttribute]
        public uint queryTableFieldId
        {
            get
            {
                return this.queryTableFieldIdField;
            }
            set
            {
                this.queryTableFieldIdField = value;
            }
        }

        [XmlIgnore]
        public bool queryTableFieldIdSpecified
        {
            get
            {
                return this.queryTableFieldIdFieldSpecified;
            }
            set
            {
                this.queryTableFieldIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public uint headerRowDxfId
        {
            get
            {
                return this.headerRowDxfIdField;
            }
            set
            {
                this.headerRowDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool headerRowDxfIdSpecified
        {
            get
            {
                return this.headerRowDxfIdFieldSpecified;
            }
            set
            {
                this.headerRowDxfIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public uint dataDxfId
        {
            get
            {
                return this.dataDxfIdField;
            }
            set
            {
                this.dataDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool dataDxfIdSpecified
        {
            get
            {
                return this.dataDxfIdFieldSpecified;
            }
            set
            {
                this.dataDxfIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public uint totalsRowDxfId
        {
            get
            {
                return this.totalsRowDxfIdField;
            }
            set
            {
                this.totalsRowDxfIdField = value;
            }
        }

        [XmlIgnore]
        public bool totalsRowDxfIdSpecified
        {
            get
            {
                return this.totalsRowDxfIdFieldSpecified;
            }
            set
            {
                this.totalsRowDxfIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public string headerRowCellStyle
        {
            get
            {
                return this.headerRowCellStyleField;
            }
            set
            {
                this.headerRowCellStyleField = value;
            }
        }
        [XmlAttribute]
        public string dataCellStyle
        {
            get
            {
                return this.dataCellStyleField;
            }
            set
            {
                this.dataCellStyleField = value;
            }
        }
        [XmlAttribute]
        public string totalsRowCellStyle
        {
            get
            {
                return this.totalsRowCellStyleField;
            }
            set
            {
                this.totalsRowCellStyleField = value;
            }
        }
    }
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_TableFormula
    {

        private bool arrayField;

        private string valueField;

        public CT_TableFormula()
        {
            this.arrayField = false;
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool array
        {
            get
            {
                return this.arrayField;
            }
            set
            {
                this.arrayField = value;
            }
        }

        [XmlText]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        public static CT_TableFormula Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_TableFormula ctObj = new CT_TableFormula();
            if (node.Attribute("array") != null)
                ctObj.array = XmlHelper.ReadBool(node.Attribute("array"));
            ctObj.Value = node.Value;
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "array", this.array);
            sw.Write(">");
            sw.Write(XmlHelper.EncodeXml(this.valueField));
            sw.Write(string.Format("</{0}>", nodeName));
        }

    }
}
