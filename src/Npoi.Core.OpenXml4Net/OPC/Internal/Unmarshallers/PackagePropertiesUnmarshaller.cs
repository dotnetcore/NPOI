using ICSharpCode.SharpZipLib.Zip;
using Npoi.Core.OpenXml4Net.Exceptions;
using Npoi.Core.Util;
using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Npoi.Core.OpenXml4Net.OPC.Internal.Unmarshallers
{
    /**
     * Package properties unmarshaller.
     *
     * @author Julien Chable
     * @version 1.0
     */

    public class PackagePropertiesUnmarshaller : PartUnmarshaller
    {
        private static string namespaceDC = "http://purl.org/dc/elements/1.1/";

        private static string namespaceCP = PackageNamespaces.CORE_PROPERTIES;
        private static string namespaceDcTerms = "http://purl.org/dc/terms/";

        private static string namespaceXML = "http://www.w3.org/XML/1998/namespace";

        private static string namespaceXSI = "http://www.w3.org/2001/XMLSchema-instance";

        protected static String KEYWORD_CATEGORY = "category";

        protected static String KEYWORD_CONTENT_STATUS = "contentStatus";

        protected static String KEYWORD_CONTENT_TYPE = "contentType";

        protected static String KEYWORD_CREATED = "created";

        protected static String KEYWORD_CREATOR = "creator";

        protected static String KEYWORD_DESCRIPTION = "description";

        protected static String KEYWORD_IDENTIFIER = "identifier";

        protected static String KEYWORD_KEYWORDS = "keywords";

        protected static String KEYWORD_LANGUAGE = "language";

        protected static String KEYWORD_LAST_MODIFIED_BY = "lastModifiedBy";

        protected static String KEYWORD_LAST_PRINTED = "lastPrinted";

        protected static String KEYWORD_MODIFIED = "modified";

        protected static String KEYWORD_REVISION = "revision";

        protected static String KEYWORD_SUBJECT = "subject";

        protected static String KEYWORD_TITLE = "title";

        protected static String KEYWORD_VERSION = "version";

        protected XmlNamespaceManager nsmgr = null;

        // TODO Load element with XMLBeans or dynamic table
        // TODO Check every element/namespace for compliance
        public PackagePart Unmarshall(UnmarshallContext context, Stream in1)
        {
            PackagePropertiesPart coreProps = new PackagePropertiesPart(context
                    .Package, context.PartName);

            // If the input stream is null then we try to get it from the
            // package.
            if (in1 == null)
            {
                if (context.ZipEntry != null)
                {
                    in1 = ((ZipPackage)context.Package).ZipArchive
                            .GetInputStream(context.ZipEntry);
                }
                else if (context.Package != null)
                {
                    // Try to retrieve the part inputstream from the URI
                    ZipEntry zipEntry;
                    try
                    {
                        zipEntry = ZipHelper
                                .GetCorePropertiesZipEntry((ZipPackage)context
                                        .Package);
                    }
                    catch (OpenXml4NetException)
                    {
                        throw new IOException(
                                "Error while trying to get the part input stream.");
                    }
                    in1 = ((ZipPackage)context.Package).ZipArchive
                            .GetInputStream(zipEntry);
                }
                else
                    throw new IOException(
                            "Error while trying to get the part input stream.");
            }

            XDocument xmlDoc = null;
            try
            {
                xmlDoc = DocumentHelper.LoadDocument(in1);
                nsmgr = new XmlNamespaceManager(xmlDoc.NameTable());
                nsmgr.AddNamespace("cp", namespaceCP);
                nsmgr.AddNamespace("dc", namespaceDC);
                nsmgr.AddNamespace("dcterms", namespaceDcTerms);
                nsmgr.AddNamespace("xsi", namespaceXSI);
                nsmgr.AddNamespace("cml", PackageNamespaces.MARKUP_COMPATIBILITY);
                nsmgr.AddNamespace("dcmitype", PackageNamespaces.DCMITYPE);

                //xmlDoc.ReadNode(reader);
                //try {
                //xmlDoc = xmlReader.read(in1);

                /* Check OPC compliance */

                // Rule M4.2, M4.3, M4.4 and M4.5/
                CheckElementForOPCCompliance(xmlDoc.Document.Root);

                /* End OPC compliance */

                //} catch (DocumentException e) {
                //    throw new IOException(e.getMessage());
                //}
            }
            catch (XmlException ex)
            {
                throw new IOException(ex.Message, ex);
            }
            if (xmlDoc != null && xmlDoc.Document != null)
            {
                coreProps.SetCategoryProperty(LoadCategory(xmlDoc));
                coreProps.SetContentStatusProperty(LoadContentStatus(xmlDoc));
                coreProps.SetContentTypeProperty(LoadContentType(xmlDoc));
                coreProps.SetCreatedProperty(LoadCreated(xmlDoc));
                coreProps.SetCreatorProperty(LoadCreator(xmlDoc));
                coreProps.SetDescriptionProperty(LoadDescription(xmlDoc));
                coreProps.SetIdentifierProperty(LoadIdentifier(xmlDoc));
                coreProps.SetKeywordsProperty(LoadKeywords(xmlDoc));
                coreProps.SetLanguageProperty(LoadLanguage(xmlDoc));
                coreProps.SetLastModifiedByProperty(LoadLastModifiedBy(xmlDoc));
                coreProps.SetLastPrintedProperty(LoadLastPrinted(xmlDoc));
                coreProps.SetModifiedProperty(LoadModified(xmlDoc));
                coreProps.SetRevisionProperty(LoadRevision(xmlDoc));
                coreProps.SetSubjectProperty(LoadSubject(xmlDoc));
                coreProps.SetTitleProperty(LoadTitle(xmlDoc));
                coreProps.SetVersionProperty(LoadVersion(xmlDoc));
            }
            return coreProps;
        }

        private string LoadCategory(XDocument xmlDoc)
        {
            var el = xmlDoc.Document.XPathSelectElements("cp:" + KEYWORD_CATEGORY, nsmgr).ToList()[0];

            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        private string LoadContentStatus(XDocument xmlDoc)
        {
            var el = xmlDoc.Document.XPathSelectElements("cp:" + KEYWORD_CONTENT_STATUS, nsmgr).ToList()[0];
            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        private string LoadContentType(XDocument xmlDoc)
        {
            //Element el = xmlDoc.getRootElement().element(
            //        new QName(KEYWORD_CONTENT_TYPE, namespaceCP));
            var el = xmlDoc.Document.XPathSelectElements("cp:" + KEYWORD_CONTENT_TYPE, nsmgr).ToList()[0];
            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        private string LoadCreated(XDocument xmlDoc)
        {
            //Element el = xmlDoc.getRootElement().element(
            //        new QName(KEYWORD_CREATED, namespaceDcTerms));
            var el = xmlDoc.Document.XPathSelectElements("dcterms:" + KEYWORD_CREATED, nsmgr).ToList()[0];
            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        private string LoadCreator(XDocument xmlDoc)
        {
            //Element el = xmlDoc.getRootElement().element(
            //        new QName(KEYWORD_CREATOR, namespaceDC));
            var el = xmlDoc.Document.XPathSelectElements("dc:" + KEYWORD_CREATOR, nsmgr).ToList()[0];
            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        private string LoadDescription(XDocument xmlDoc)
        {
            //Element el = xmlDoc.getRootElement().element(
            //        new QName(KEYWORD_DESCRIPTION, namespaceDC));
            var el = xmlDoc.Document.XPathSelectElements("dc:" + KEYWORD_DESCRIPTION, nsmgr).ToList()[0];
            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        private string LoadIdentifier(XDocument xmlDoc)
        {
            //Element el = xmlDoc.getRootElement().element(
            //        new QName(KEYWORD_IDENTIFIER, namespaceDC));
            var el = xmlDoc.Document.XPathSelectElements("dc:" + KEYWORD_IDENTIFIER, nsmgr).ToList()[0];
            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        private string LoadKeywords(XDocument xmlDoc)
        {
            //Element el = xmlDoc.getRootElement().element(
            //        new QName(KEYWORD_KEYWORDS, namespaceCP));
            var el = xmlDoc.Document.XPathSelectElements("cp:" + KEYWORD_KEYWORDS, nsmgr).ToList()[0];

            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        private string LoadLanguage(XDocument xmlDoc)
        {
            //Element el = xmlDoc.getRootElement().element(
            //        new QName(KEYWORD_LANGUAGE, namespaceDC));
            var el = xmlDoc.Document.XPathSelectElements("dc:" + KEYWORD_LANGUAGE, nsmgr).ToList()[0];
            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        private string LoadLastModifiedBy(XDocument xmlDoc)
        {
            //Element el = xmlDoc.getRootElement().element(
            //        new QName(KEYWORD_LAST_MODIFIED_BY, namespaceCP));
            var el = xmlDoc.Document.XPathSelectElements("cp:" + KEYWORD_LAST_MODIFIED_BY, nsmgr).ToList()[0];
            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        private string LoadLastPrinted(XDocument xmlDoc)
        {
            //Element el = xmlDoc.getRootElement().element(
            //        new QName(KEYWORD_LAST_PRINTED, namespaceCP));
            var el = xmlDoc.Document.XPathSelectElements("cp:" + KEYWORD_LAST_PRINTED, nsmgr).ToList()[0];
            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        private string LoadModified(XDocument xmlDoc)
        {
            //Element el = xmlDoc.getRootElement().element(
            //        new QName(KEYWORD_MODIFIED, namespaceDcTerms));
            var el = xmlDoc.Document.XPathSelectElements("dcterms:" + KEYWORD_MODIFIED, nsmgr).ToList()[0];
            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        private string LoadRevision(XDocument xmlDoc)
        {
            //Element el = xmlDoc.getRootElement().element(
            //        new QName(KEYWORD_REVISION, namespaceCP));
            var el = xmlDoc.Document.XPathSelectElements("cp:" + KEYWORD_REVISION, nsmgr).ToList()[0];
            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        private string LoadSubject(XDocument xmlDoc)
        {
            //Element el = xmlDoc.getRootElement().element(
            //        new QName(KEYWORD_SUBJECT, namespaceDC));
            var el = xmlDoc.Document.XPathSelectElements("dc:" + KEYWORD_SUBJECT, nsmgr).ToList()[0];
            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        private string LoadTitle(XDocument xmlDoc)
        {
            //Element el = xmlDoc.getRootElement().element(
            //        new QName(KEYWORD_TITLE, namespaceDC));
            var el = xmlDoc.Document.XPathSelectElements("dc:" + KEYWORD_TITLE, nsmgr).ToList()[0];
            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        private string LoadVersion(XDocument xmlDoc)
        {
            //Element el = xmlDoc.getRootElement().element(
            //        new QName(KEYWORD_VERSION, namespaceCP));
            var el = xmlDoc.Document.XPathSelectElements("cp:" + KEYWORD_VERSION, nsmgr).ToList()[0];
            if (el == null)
            {
                return null;
            }
            return el.Value;
        }

        /* OPC Compliance methods */

        /**
         * Check the element for the following OPC compliance rules:
         * <p>
         * Rule M4.2: A format consumer shall consider the use of the Markup
         * Compatibility namespace to be an error.
         * </p><p>
         * Rule M4.3: Producers shall not create a document element that contains
         * refinements to the Dublin Core elements, except for the two specified in
         * the schema: <dcterms:created> and <dcterms:modified> Consumers shall
         * consider a document element that violates this constraint to be an error.
         * </p><p>
         * Rule M4.4: Producers shall not create a document element that contains
         * the xml:lang attribute. Consumers shall consider a document element that
         * violates this constraint to be an error.
         *  </p><p>
         * Rule M4.5: Producers shall not create a document element that contains
         * the xsi:type attribute, except for a <dcterms:created> or
         * <dcterms:modified> element where the xsi:type attribute shall be present
         * and shall hold the value dcterms:W3CDTF, where dcterms is the namespace
         * prefix of the Dublin Core namespace. Consumers shall consider a document
         * element that violates this constraint to be an error.
         * </p>
         */

        public void CheckElementForOPCCompliance(XElement el)
        {
            foreach (XAttribute attr in el.Attributes())
            {
                if (attr.Name.LocalName.StartsWith("xmlns:"))
                {
                    string namespacePrefix = attr.Name.LocalName.Substring(6);
                    if (nsmgr.LookupNamespace(namespacePrefix).Equals(PackageNamespaces.MARKUP_COMPATIBILITY))
                    {
                        // Rule M4.2
                        throw new InvalidFormatException(
                                    "OPC Compliance error [M4.2]: A format consumer shall consider the use of the Markup Compatibility namespace to be an error.");
                    }
                }
            }
            // Check the current element

            // Rule M4.3
            if (el.Name.NamespaceName.Equals(
                    namespaceDcTerms)
                    && !(el.Name.LocalName.Equals(KEYWORD_CREATED) || el.Name.LocalName
                            .Equals(KEYWORD_MODIFIED)))
                throw new InvalidFormatException(
                        "OPC Compliance error [M4.3]: Producers shall not create a document element that contains refinements to the Dublin Core elements, except for the two specified in the schema: <dcterms:created> and <dcterms:modified> Consumers shall consider a document element that violates this constraint to be an error.");

            // Rule M4.4
            if (el.Attribute((XNamespace)namespaceXML + "lang") != null)
                throw new InvalidFormatException(
                        "OPC Compliance error [M4.4]: Producers shall not create a document element that contains the xml:lang attribute. Consumers shall consider a document element that violates this constraint to be an error.");

            // Rule M4.5
            if (el.Name.NamespaceName.Equals(
                    namespaceDcTerms))
            {
                // DCTerms namespace only use with 'created' and 'modified' elements
                String elName = el.Name.LocalName;
                if (!(elName.Equals(KEYWORD_CREATED) || elName
                        .Equals(KEYWORD_MODIFIED)))
                    throw new InvalidFormatException("Namespace error : " + elName
                            + " shouldn't have the following naemspace -> "
                            + namespaceDcTerms);

                // Check for the 'xsi:type' attribute
                var typeAtt = el.Attribute("xsi:type");
                if (typeAtt == null)
                    throw new InvalidFormatException("The element '" + elName
                            + "' must have the '" + nsmgr.LookupPrefix(namespaceXSI)
                            + ":type' attribute present !");

                // Check for the attribute value => 'dcterms:W3CDTF'
                if (!typeAtt.Value.Equals("dcterms:W3CDTF"))
                    throw new InvalidFormatException("The element '" + elName
                            + "' must have the '" + nsmgr.LookupPrefix(namespaceXSI)
                            + ":type' attribute with the value 'dcterms:W3CDTF' !");
            }

            // Check its children
            foreach (var node in el.Nodes())
            {
                if (node is XElement)
                    CheckElementForOPCCompliance((XElement)node);
            }
        }
    }
}