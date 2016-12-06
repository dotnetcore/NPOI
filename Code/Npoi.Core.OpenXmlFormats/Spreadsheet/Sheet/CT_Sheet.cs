using Npoi.Core.OpenXml4Net.OPC;
using Npoi.Core.OpenXml4Net.Util;
using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Npoi.Core.OpenXmlFormats.Spreadsheet
{
    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot("sheet", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public class CT_Sheet
    {
        private string nameField;

        private uint sheetIdField;

        private ST_SheetState stateField;

        private string idField;

        public static CT_Sheet Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Sheet ctObj = new CT_Sheet();
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            ctObj.sheetId = XmlHelper.ReadUInt(node.Attribute("sheetId"));
            if (node.Attribute("state") != null)
                ctObj.state = (ST_SheetState)Enum.Parse(typeof(ST_SheetState), node.Attribute("state").Value);
            ctObj.id = XmlHelper.ReadString(node.Attribute((XNamespace)PackageNamespaces.SCHEMA_RELATIONSHIPS + "id"));
            return ctObj;
        }

        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "sheetId", this.sheetId);
            if (state != ST_SheetState.visible)
                XmlHelper.WriteAttribute(sw, "state", this.state.ToString());
            XmlHelper.WriteAttribute(sw, "r:id", this.id);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        public CT_Sheet()
        {
            this.stateField = ST_SheetState.visible;
        }

        public void Set(CT_Sheet sheet)
        {
            this.nameField = sheet.nameField;
            this.sheetIdField = sheet.sheetIdField;
            this.stateField = sheet.stateField;
            this.idField = sheet.idField;
        }

        public CT_Sheet Copy()
        {
            CT_Sheet obj = new CT_Sheet();
            obj.idField = this.idField;
            obj.sheetIdField = this.sheetIdField;
            obj.nameField = this.nameField;
            obj.stateField = this.stateField;
            return obj;
        }

        [XmlAttribute("name")]
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

        [XmlAttribute("sheetId")]
        public uint sheetId
        {
            get
            {
                return this.sheetIdField;
            }
            set
            {
                this.sheetIdField = value;
            }
        }

        [XmlAttribute("state")]
        [DefaultValue(ST_SheetState.visible)]
        public ST_SheetState state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
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
}