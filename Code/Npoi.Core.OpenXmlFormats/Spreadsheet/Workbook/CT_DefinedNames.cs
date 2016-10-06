using Npoi.Core.OpenXml4Net.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Npoi.Core.OpenXmlFormats.Spreadsheet
{
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_DefinedName
    {

        private string nameField;

        private string commentField;

        private string customMenuField;

        private string descriptionField;

        private string helpField;

        private string statusBarField;

        private uint localSheetIdField;

        private bool localSheetIdFieldSpecified;

        private bool hiddenField;

        private bool functionField;

        private bool vbProcedureField;

        private bool xlmField;

        private uint functionGroupIdField;

        private bool functionGroupIdFieldSpecified;

        private string shortcutKeyField;

        private bool publishToServerField;

        private bool workbookParameterField;

        private string valueField;
        public static CT_DefinedName Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_DefinedName ctObj = new CT_DefinedName();
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            ctObj.comment = XmlHelper.ReadString(node.Attribute("comment"));
            ctObj.customMenu = XmlHelper.ReadString(node.Attribute("customMenu"));
            ctObj.description = XmlHelper.ReadString(node.Attribute("description"));
            ctObj.help = XmlHelper.ReadString(node.Attribute("help"));
            ctObj.statusBar = XmlHelper.ReadString(node.Attribute("statusBar"));
            ctObj.localSheetId = XmlHelper.ReadUInt(node.Attribute("localSheetId"));
            ctObj.localSheetIdFieldSpecified = node.Attribute("localSheetId") != null;
            ctObj.hidden = XmlHelper.ReadBool(node.Attribute("hidden"));
            ctObj.function = XmlHelper.ReadBool(node.Attribute("function"));
            ctObj.vbProcedure = XmlHelper.ReadBool(node.Attribute("vbProcedure"));
            ctObj.xlm = XmlHelper.ReadBool(node.Attribute("xlm"));
            ctObj.functionGroupId = XmlHelper.ReadUInt(node.Attribute("functionGroupId"));
            ctObj.shortcutKey = XmlHelper.ReadString(node.Attribute("shortcutKey"));
            ctObj.publishToServer = XmlHelper.ReadBool(node.Attribute("publishToServer"));
            ctObj.workbookParameter = XmlHelper.ReadBool(node.Attribute("workbookParameter"));
            ctObj.Value = node.Value;
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "comment", this.comment);
            XmlHelper.WriteAttribute(sw, "customMenu", this.customMenu);
            XmlHelper.WriteAttribute(sw, "description", this.description);
            XmlHelper.WriteAttribute(sw, "help", this.help);
            XmlHelper.WriteAttribute(sw, "statusBar", this.statusBar);
            if (localSheetIdFieldSpecified)
                XmlHelper.WriteAttribute(sw, "localSheetId", this.localSheetId, true);
            if(hidden)
                XmlHelper.WriteAttribute(sw, "hidden", this.hidden);
            if (function)
                XmlHelper.WriteAttribute(sw, "function", this.function);
            if (vbProcedure)
                XmlHelper.WriteAttribute(sw, "vbProcedure", this.vbProcedure);
            if(xlm)
                XmlHelper.WriteAttribute(sw, "xlm", this.xlm);
            XmlHelper.WriteAttribute(sw, "functionGroupId", this.functionGroupId);
            XmlHelper.WriteAttribute(sw, "shortcutKey", this.shortcutKey);
            if (publishToServerField)
                XmlHelper.WriteAttribute(sw, "publishToServer", this.publishToServer);
            if (workbookParameterField)
                XmlHelper.WriteAttribute(sw, "workbookParameter", this.workbookParameter);
            sw.Write(">");
            sw.Write(string.Format("<![CDATA[{0}]]>", this.Value));
            sw.Write(string.Format("</{0}>", nodeName));
        }

        public CT_DefinedName()
        {
            this.hiddenField = false;
            this.functionField = false;
            this.vbProcedureField = false;
            this.xlmField = false;
            this.publishToServerField = false;
            this.workbookParameterField = false;
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
        public string customMenu
        {
            get
            {
                return this.customMenuField;
            }
            set
            {
                this.customMenuField = value;
            }
        }
        [XmlAttribute]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        [XmlAttribute]
        public string help
        {
            get
            {
                return this.helpField;
            }
            set
            {
                this.helpField = value;
            }
        }
        [XmlAttribute]
        public string statusBar
        {
            get
            {
                return this.statusBarField;
            }
            set
            {
                this.statusBarField = value;
            }
        }
        public bool IsSetLocalSheetId()
        {
            return localSheetIdFieldSpecified;
        }
        public void UnsetLocalSheetId()
        {
            localSheetIdFieldSpecified = false;
        }
        [XmlAttribute]
        public uint localSheetId
        {
            get
            {
                return localSheetIdField;
            }
            set
            {
                this.localSheetIdField = value;
                this.localSheetIdFieldSpecified = true;
            }
        }

        [XmlIgnore]
        public bool localSheetIdSpecified
        {
            get
            {
                return this.localSheetIdFieldSpecified;
            }
            set
            {
                this.localSheetIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool function
        {
            get
            {
                return this.functionField;
            }
            set
            {
                this.functionField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool vbProcedure
        {
            get
            {
                return this.vbProcedureField;
            }
            set
            {
                this.vbProcedureField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool xlm
        {
            get
            {
                return this.xlmField;
            }
            set
            {
                this.xlmField = value;
            }
        }
        [XmlAttribute]
        public uint functionGroupId
        {
            get
            {
                return this.functionGroupIdField;
            }
            set
            {
                this.functionGroupIdField = value;
            }
        }

        [XmlIgnore]
        public bool functionGroupIdSpecified
        {
            get
            {
                return this.functionGroupIdFieldSpecified;
            }
            set
            {
                this.functionGroupIdFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public string shortcutKey
        {
            get
            {
                return this.shortcutKeyField;
            }
            set
            {
                this.shortcutKeyField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool publishToServer
        {
            get
            {
                return this.publishToServerField;
            }
            set
            {
                this.publishToServerField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool workbookParameter
        {
            get
            {
                return this.workbookParameterField;
            }
            set
            {
                this.workbookParameterField = value;
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
    }
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_DefinedNames
    {

        private List<CT_DefinedName> definedNameField;

        public CT_DefinedNames()
        {
        }
        public static CT_DefinedNames Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_DefinedNames ctObj = new CT_DefinedNames();
            ctObj.definedName = new List<CT_DefinedName>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "definedName")
                    ctObj.definedName.Add(CT_DefinedName.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            sw.Write(">");
            if (this.definedName != null)
            {
                foreach (CT_DefinedName x in this.definedName)
                {
                    x.Write(sw, "definedName");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        public CT_DefinedName AddNewDefinedName()
        {
            if (this.definedNameField == null)
                this.definedNameField = new List<CT_DefinedName>();
            CT_DefinedName dn = new CT_DefinedName();
            this.definedNameField.Add(dn);
            return dn;
        }

        public void SetDefinedNameArray(List<CT_DefinedName> array)
        {
            this.definedNameField = array;
        }
        [XmlElement]
        public List<CT_DefinedName> definedName
        {
            get
            {
                return this.definedNameField;
            }
            set
            {
                this.definedNameField = value;
            }
        }
    }
}
