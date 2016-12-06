using Npoi.Core.OpenXml4Net.OPC;
using Npoi.Core.OpenXml4Net.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Npoi.Core.OpenXmlFormats.Spreadsheet
{
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_ExternalReference
    {
        private string idField;

        public static CT_ExternalReference Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_ExternalReference ctObj = new CT_ExternalReference();
            ctObj.id = XmlHelper.ReadString(node.Attribute((XNamespace)PackageNamespaces.SCHEMA_RELATIONSHIPS + "id"));
            return ctObj;
        }

        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "r:id", this.id);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
        public string id
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
    }

    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_ExternalReferences
    {
        private List<CT_ExternalReference> externalReferenceField;

        public static CT_ExternalReferences Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_ExternalReferences ctObj = new CT_ExternalReferences();
            ctObj.externalReference = new List<CT_ExternalReference>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "externalReference")
                    ctObj.externalReference.Add(CT_ExternalReference.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }

        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            sw.Write(">");
            if (this.externalReference != null)
            {
                foreach (CT_ExternalReference x in this.externalReference)
                {
                    x.Write(sw, "externalReference");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        public CT_ExternalReferences()
        {
            //this.externalReferenceField = new List<CT_ExternalReference>();
        }

        [XmlElement]
        public List<CT_ExternalReference> externalReference
        {
            get
            {
                return this.externalReferenceField;
            }
            set
            {
                this.externalReferenceField = value;
            }
        }
    }
}