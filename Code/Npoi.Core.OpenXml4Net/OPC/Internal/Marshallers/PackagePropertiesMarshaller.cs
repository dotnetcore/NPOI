using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace Npoi.Core.OpenXml4Net.OPC.Internal.Marshallers
{
    /**
     * Package properties marshaller.
     *
     * @author CDubet, Julien Chable
     */

    public class PackagePropertiesMarshaller : PartMarshaller
    {
        private static readonly string NamespaceDc = PackagePropertiesPart.NAMESPACE_DC_URI;
        private static readonly string NamespaceCoreProperties = PackagePropertiesPart.NAMESPACE_CP_URI;
        private static readonly string NamespaceDcTerms = PackagePropertiesPart.NAMESPACE_DCTERMS_URI;
        private static readonly string NamespaceXsi = PackagePropertiesPart.NAMESPACE_XSI_URI;

        protected static string KeywordCategory = "category";
        protected static string KeywordContentStatus = "contentStatus";
        protected static string KeywordContentType = "contentType";
        protected static string KeywordCreated = "created";
        protected static string KeywordCreator = "creator";
        protected static string KeywordDescription = "description";
        protected static string KeywordIdentifier = "identifier";
        protected static string KeywordKeywords = "keywords";
        protected static string KeywordLanguage = "language";
        protected static string KeywordLastModifiedBy = "lastModifiedBy";
        protected static string KeywordLastPrinted = "lastPrinted";
        protected static string KeywordModified = "modified";
        protected static string KeywordRevision = "revision";
        protected static string KeywordSubject = "subject";
        protected static string KeywordTitle = "title";
        protected static string KeywordVersion = "version";
        protected XmlNamespaceManager Nsmgr;
        protected XDocument XmlDoc;
        protected XElement RootElem { get; set; }

        private PackagePropertiesPart _propsPart;

        /**
         * Marshall package core properties to an XML document. Always return
         * <code>true</code>.
         */

        public virtual bool Marshall(PackagePart part, Stream out1)
        {
            if (!(part is PackagePropertiesPart))
                throw new ArgumentException(
                    "'part' must be a PackagePropertiesPart instance.");
            _propsPart = (PackagePropertiesPart)part;

            // Configure the document
            XmlDoc = new XDocument();
            XNamespace ns = NamespaceCoreProperties;
            this.RootElem = new XElement(ns + "coreProperties",
                new XAttribute(XNamespace.Xmlns + "cp", PackagePropertiesPart.NAMESPACE_CP_URI),
                new XAttribute(XNamespace.Xmlns + "dc", PackagePropertiesPart.NAMESPACE_DC_URI),
                new XAttribute(XNamespace.Xmlns + "dcterms", PackagePropertiesPart.NAMESPACE_DCTERMS_URI),
                new XAttribute(XNamespace.Xmlns + "xsi", PackagePropertiesPart.NAMESPACE_XSI_URI)
                );
            //this.RootElem.Name =
            //    (XNamespace)NamespaceCoreProperties + RootElem.Name.LocalName;
            //using (var reader = XmlDoc.CreateReader())
            //{
            //	Nsmgr = new XmlNamespaceManager(reader.NameTable);
            //}
            //Nsmgr.AddNamespace("cp", PackagePropertiesPart.NAMESPACE_CP_URI);
            //Nsmgr.AddNamespace("dc", PackagePropertiesPart.NAMESPACE_DC_URI);
            //Nsmgr.AddNamespace("dcterms", PackagePropertiesPart.NAMESPACE_DCTERMS_URI);
            //Nsmgr.AddNamespace("xsi", PackagePropertiesPart.NAMESPACE_XSI_URI);

            XmlDoc.Add(RootElem);

            Prop(() => _propsPart.GetCategoryProperty(), NamespaceCoreProperties, "cp", KeywordCategory);
            Prop(() => _propsPart.GetContentStatusProperty(), NamespaceCoreProperties, "cp", KeywordContentStatus);
            Prop(() => _propsPart.GetContentTypeProperty(), NamespaceCoreProperties, "cp", KeywordContentType);
            var created = Prop(() => _propsPart.GetCreatedProperty(), NamespaceDcTerms, "dcterms", KeywordCreated,
                () => _propsPart.GetCreatedPropertyString());
            created?.SetAttribute("type", NamespaceXsi, "dcterms:W3CDTF");
            Prop(() => _propsPart.GetCreatorProperty(), NamespaceDc, "dc", KeywordCreator);
            Prop(() => _propsPart.GetDescriptionProperty(), NamespaceDc, "dc", KeywordDescription);
            Prop(() => _propsPart.GetIdentifierProperty(), NamespaceDc, "dc", KeywordIdentifier);
            Prop(() => _propsPart.GetKeywordsProperty(), NamespaceCoreProperties, "cp", KeywordKeywords);
            Prop(() => _propsPart.GetLanguageProperty(), NamespaceDc, "dc", KeywordLanguage);
            Prop(() => _propsPart.GetLastModifiedByProperty(), NamespaceCoreProperties, "cp", KeywordLastModifiedBy);
            Prop(() => _propsPart.GetLastPrintedProperty(), NamespaceCoreProperties, "cp", KeywordLastPrinted,
                () => _propsPart.GetLastPrintedPropertyString());
            var modified = Prop(() => _propsPart.GetModifiedProperty(), NamespaceDcTerms, "dcterms", KeywordModified,
                () => _propsPart.GetModifiedPropertyString());
            modified?.SetAttribute("type", NamespaceXsi, "dcterms:W3CDTF");
            Prop(() => _propsPart.GetRevisionProperty(), NamespaceCoreProperties, "cp", KeywordRevision);
            Prop(() => _propsPart.GetSubjectProperty(), NamespaceDc, "dc", KeywordSubject);
            Prop(() => _propsPart.GetTitleProperty(), NamespaceDc, "dc", KeywordTitle);
            Prop(() => _propsPart.GetVersionProperty(), NamespaceCoreProperties, "cp", KeywordVersion);
            return true;
        }

        private XElement Prop<T>(Func<T> prop, string @namespace, string prefix, string localName,
            Func<string> propString = null)
        {
            if (prop() == null)
                return null;

            var elems = XmlDoc.Descendants((XNamespace)@namespace + KeywordCreator).ToList();
            XElement elem;
            if (elems.Count == 0)
            {
                // Missing, we Add it
                elem = new XElement((XNamespace)@namespace + localName);
                //elem = elem.AddSchemaAttribute(prefix);
                RootElem.Add(elem);
            }
            else
            {
                elem = elems[0];
                elem.Value = ""; // clear the old value
            }

            elem.Value = propString != null ? propString() : prop() as string;
            return elem;
        }
    }
}