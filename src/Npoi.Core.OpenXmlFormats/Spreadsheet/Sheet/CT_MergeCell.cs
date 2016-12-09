using Npoi.Core.OpenXml4Net.Util;
using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Npoi.Core.OpenXmlFormats.Spreadsheet
{
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_MergeCell
    {
        public static CT_MergeCell Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_MergeCell ctObj = new CT_MergeCell();
            ctObj.@ref = XmlHelper.ReadString(node.Attribute("ref"));
            return ctObj;
        }

        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "ref", this.@ref);
            sw.Write("/>");
        }

        private string refField;

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
    }
}