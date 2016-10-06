using NPOI.OpenXml4Net.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_NumFmts
    {

        private List<CT_NumFmt> numFmtField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_NumFmts()
        {
            //this.numFmtField = new List<CT_NumFmt>();
        }
        public static CT_NumFmts Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_NumFmts ctObj = new CT_NumFmts();
            ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.numFmt = new List<CT_NumFmt>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "numFmt")
                    ctObj.numFmt.Add(CT_NumFmt.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count, true);
            sw.Write(">");
            if (this.numFmt != null)
            {
                foreach (CT_NumFmt x in this.numFmt)
                {
                    x.Write(sw, "numFmt");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        public CT_NumFmt AddNewNumFmt()
        {
            if (this.numFmtField == null)
                this.numFmtField = new List<CT_NumFmt>();
            CT_NumFmt newNumFmt = new CT_NumFmt();
            this.numFmtField.Add(newNumFmt);
            return newNumFmt;
        }
        [XmlElement]
        public List<CT_NumFmt> numFmt
        {
            get
            {
                return this.numFmtField;
            }
            set
            {
                this.numFmtField = value;
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

}
