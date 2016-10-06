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
    public enum ST_Comments
    {


        commNone,


        commIndicator,


        commIndAndComment,
    }
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_BookView
    {

        private CT_ExtensionList extLstField = null;

        private ST_Visibility visibilityField;

        private bool minimizedField;

        private bool showHorizontalScrollField;

        private bool showVerticalScrollField;

        private bool showSheetTabsField;

        private int xWindowField;

        private bool xWindowFieldSpecified;

        private int yWindowField;

        private bool yWindowFieldSpecified;

        private uint windowWidthField;

        private bool windowWidthFieldSpecified;

        private uint windowHeightField;

        private bool windowHeightFieldSpecified;

        private uint tabRatioField;

        private uint firstSheetField;

        private uint activeTabField;

        private bool autoFilterDateGroupingField;

        public CT_BookView()
        {
            //            this.extLstField = new CT_ExtensionList();
            this.visibilityField = ST_Visibility.visible;
            this.minimizedField = false;
            this.showHorizontalScrollField = true;
            this.showVerticalScrollField = true;
            this.showSheetTabsField = true;
            this.tabRatioField = ((uint)(600));
            this.firstSheetField = ((uint)(0));
            this.activeTabField = ((uint)(0));
            this.autoFilterDateGroupingField = true;
        }
        public static CT_BookView Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_BookView ctObj = new CT_BookView();
            if (node.Attribute("visibility") != null)
                ctObj.visibility = (ST_Visibility)Enum.Parse(typeof(ST_Visibility), node.Attribute("visibility").Value);
            ctObj.minimized = XmlHelper.ReadBool(node.Attribute("minimized"));
            ctObj.showHorizontalScroll = XmlHelper.ReadBool(node.Attribute("showHorizontalScroll"), true);
            ctObj.showVerticalScroll = XmlHelper.ReadBool(node.Attribute("showVerticalScroll"), true);
            ctObj.showSheetTabs = XmlHelper.ReadBool(node.Attribute("showSheetTabs"), true);
            ctObj.xWindow = XmlHelper.ReadInt(node.Attribute("xWindow"));
            ctObj.yWindow = XmlHelper.ReadInt(node.Attribute("yWindow"));
            ctObj.windowWidth = XmlHelper.ReadUInt(node.Attribute("windowWidth"));
            ctObj.windowHeight = XmlHelper.ReadUInt(node.Attribute("windowHeight"));
            ctObj.tabRatio = XmlHelper.ReadUInt(node.Attribute("tabRatio"));
            ctObj.firstSheet = XmlHelper.ReadUInt(node.Attribute("firstSheet"));
            ctObj.activeTab = XmlHelper.ReadUInt(node.Attribute("activeTab"));
            ctObj.autoFilterDateGrouping = XmlHelper.ReadBool(node.Attribute("autoFilterDateGrouping"), true);
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            if(this.visibility!= ST_Visibility.visible)
                XmlHelper.WriteAttribute(sw, "visibility", this.visibility.ToString());
            XmlHelper.WriteAttribute(sw, "minimized", this.minimized, false);
            if (!this.showHorizontalScroll)
                XmlHelper.WriteAttribute(sw, "showHorizontalScroll", this.showHorizontalScroll);
            if (!this.showVerticalScroll)
                XmlHelper.WriteAttribute(sw, "showVerticalScroll", this.showVerticalScroll);
            if(!this.showSheetTabs)
                XmlHelper.WriteAttribute(sw, "showSheetTabs", this.showSheetTabs);
            XmlHelper.WriteAttribute(sw, "xWindow", this.xWindow);
            XmlHelper.WriteAttribute(sw, "yWindow", this.yWindow);
            XmlHelper.WriteAttribute(sw, "windowWidth", this.windowWidth);
            XmlHelper.WriteAttribute(sw, "windowHeight", this.windowHeight);
            XmlHelper.WriteAttribute(sw, "tabRatio", this.tabRatio);
            XmlHelper.WriteAttribute(sw, "firstSheet", this.firstSheet);
            XmlHelper.WriteAttribute(sw, "activeTab", this.activeTab);
            if (!this.autoFilterDateGrouping)
                XmlHelper.WriteAttribute(sw, "autoFilterDateGrouping", this.autoFilterDateGrouping);
            sw.Write(">");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</{0}>", nodeName));
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
        [XmlIgnore]
        public bool extLstSpecified
        {
            get { return null != this.extLstField; }
        }

        [DefaultValue(ST_Visibility.visible)]
        [XmlAttribute]
        public ST_Visibility visibility
        {
            get
            {
                return this.visibilityField;
            }
            set
            {
                this.visibilityField = value;
            }
        }

        [DefaultValue(false)]
        [XmlAttribute]
        public bool minimized
        {
            get
            {
                return this.minimizedField;
            }
            set
            {
                this.minimizedField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool showHorizontalScroll
        {
            get
            {
                return this.showHorizontalScrollField;
            }
            set
            {
                this.showHorizontalScrollField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool showVerticalScroll
        {
            get
            {
                return this.showVerticalScrollField;
            }
            set
            {
                this.showVerticalScrollField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool showSheetTabs
        {
            get
            {
                return this.showSheetTabsField;
            }
            set
            {
                this.showSheetTabsField = value;
            }
        }

        [XmlAttribute]
        public int xWindow
        {
            get
            {
                return this.xWindowField;
            }
            set
            {
                this.xWindowField = value;
                this.xWindowFieldSpecified = true;
            }
        }

        [XmlIgnore]
        public bool xWindowSpecified
        {
            get
            {
                return this.xWindowFieldSpecified;
            }
            set
            {
                this.xWindowFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public int yWindow
        {
            get
            {
                return this.yWindowField;
            }
            set
            {
                this.yWindowField = value;
                this.yWindowFieldSpecified = true;
            }
        }

        [XmlIgnore]
        public bool yWindowSpecified
        {
            get
            {
                return this.yWindowFieldSpecified;
            }
            set
            {
                this.yWindowFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public uint windowWidth
        {
            get
            {
                return this.windowWidthField;
            }
            set
            {
                this.windowWidthField = value;
                this.windowWidthFieldSpecified = true;
            }
        }

        [XmlIgnore]
        public bool windowWidthSpecified
        {
            get
            {
                return this.windowWidthFieldSpecified;
            }
            set
            {
                this.windowWidthFieldSpecified = value;
            }
        }

        [XmlAttribute]
        public uint windowHeight
        {
            get
            {
                return this.windowHeightField;
            }
            set
            {
                this.windowHeightField = value;
                this.windowHeightFieldSpecified = true;
            }
        }

        [XmlIgnore]
        public bool windowHeightSpecified
        {
            get
            {
                return this.windowHeightFieldSpecified;
            }
            set
            {
                this.windowHeightFieldSpecified = value;
            }
        }

        [DefaultValue(typeof(uint), "600")]
        [XmlAttribute]
        public uint tabRatio
        {
            get
            {
                return this.tabRatioField;
            }
            set
            {
                this.tabRatioField = value;
            }
        }

        [DefaultValue(typeof(uint), "0")]
        [XmlAttribute]
        public uint firstSheet
        {
            get
            {
                return this.firstSheetField;
            }
            set
            {
                this.firstSheetField = value;
            }
        }

        [DefaultValue(typeof(uint), "0")]
        [XmlAttribute]
        public uint activeTab
        {
            get
            {
                return this.activeTabField;
            }
            set
            {
                this.activeTabField = value;
            }
        }

        [DefaultValue(true)]
        [XmlAttribute]
        public bool autoFilterDateGrouping
        {
            get
            {
                return this.autoFilterDateGroupingField;
            }
            set
            {
                this.autoFilterDateGroupingField = value;
            }
        }
    }
    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_BookViews
    {

        private List<CT_BookView> workbookViewField;
        public static CT_BookViews Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_BookViews ctObj = new CT_BookViews();
            ctObj.workbookView = new List<CT_BookView>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "workbookView")
                    ctObj.workbookView.Add(CT_BookView.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            sw.Write(">");
            if (this.workbookView != null)
            {
                foreach (CT_BookView x in this.workbookView)
                {
                    x.Write(sw, "workbookView");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        public CT_BookViews()
        {
            //this.workbookViewField = new List<CT_BookView>();
        }
        public CT_BookView AddNewWorkbookView()
        {
            if (this.workbookViewField == null)
                this.workbookViewField = new List<CT_BookView>();
            CT_BookView bv = new CT_BookView();
            this.workbookViewField.Add(bv);
            return bv;
        }
        public CT_BookView GetWorkbookViewArray(int index)
        {
            if (this.workbookViewField == null)
                return null;
            return this.workbookViewField[index];
        }

        [XmlElement("workbookView")]
        public List<CT_BookView> workbookView
        {
            get
            {
                return this.workbookViewField;
            }
            set
            {
                this.workbookViewField = value;
            }
        }
    }

    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_CustomWorkbookView
    {

        private CT_ExtensionList extLstField;

        private string nameField;

        private string guidField;

        private bool autoUpdateField;

        private uint mergeIntervalField;

        private bool mergeIntervalFieldSpecified;

        private bool changesSavedWinField;

        private bool onlySyncField;

        private bool personalViewField;

        private bool includePrintSettingsField;

        private bool includeHiddenRowColField;

        private bool maximizedField;

        private bool minimizedField;

        private bool showHorizontalScrollField;

        private bool showVerticalScrollField;

        private bool showSheetTabsField;

        private int xWindowField;

        private int yWindowField;

        private uint windowWidthField;

        private uint windowHeightField;

        private uint tabRatioField;

        private uint activeSheetIdField;

        private bool showFormulaBarField;

        private bool showStatusbarField;

        private ST_Comments showCommentsField;

        private ST_Objects showObjectsField;

        public CT_CustomWorkbookView()
        {
            //this.extLstField = new CT_ExtensionList();
            this.autoUpdateField = false;
            this.changesSavedWinField = false;
            this.onlySyncField = false;
            this.personalViewField = false;
            this.includePrintSettingsField = true;
            this.includeHiddenRowColField = true;
            this.maximizedField = false;
            this.minimizedField = false;
            this.showHorizontalScrollField = true;
            this.showVerticalScrollField = true;
            this.showSheetTabsField = true;
            this.xWindowField = 0;
            this.yWindowField = 0;
            this.tabRatioField = ((uint)(600));
            this.showFormulaBarField = true;
            this.showStatusbarField = true;
            this.showCommentsField = ST_Comments.commIndicator;
            this.showObjectsField = ST_Objects.all;
        }
        public static CT_CustomWorkbookView Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_CustomWorkbookView ctObj = new CT_CustomWorkbookView();
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            ctObj.guid = XmlHelper.ReadString(node.Attribute("guid"));
            ctObj.autoUpdate = XmlHelper.ReadBool(node.Attribute("autoUpdate"));
            ctObj.mergeInterval = XmlHelper.ReadUInt(node.Attribute("mergeInterval"));
            ctObj.mergeIntervalSpecified = node.Attribute("mergeInterval") != null;
            ctObj.changesSavedWin = XmlHelper.ReadBool(node.Attribute("changesSavedWin"));
            ctObj.onlySync = XmlHelper.ReadBool(node.Attribute("onlySync"));
            ctObj.personalView = XmlHelper.ReadBool(node.Attribute("personalView"));
            ctObj.includePrintSettings = XmlHelper.ReadBool(node.Attribute("includePrintSettings"));
            ctObj.includeHiddenRowCol = XmlHelper.ReadBool(node.Attribute("includeHiddenRowCol"));
            ctObj.maximized = XmlHelper.ReadBool(node.Attribute("maximized"));
            ctObj.minimized = XmlHelper.ReadBool(node.Attribute("minimized"));
            ctObj.showHorizontalScroll = XmlHelper.ReadBool(node.Attribute("showHorizontalScroll"));
            ctObj.showVerticalScroll = XmlHelper.ReadBool(node.Attribute("showVerticalScroll"));
            ctObj.showSheetTabs = XmlHelper.ReadBool(node.Attribute("showSheetTabs"));
            ctObj.xWindow = XmlHelper.ReadInt(node.Attribute("xWindow"));
            ctObj.yWindow = XmlHelper.ReadInt(node.Attribute("yWindow"));
            ctObj.windowWidth = XmlHelper.ReadUInt(node.Attribute("windowWidth"));
            ctObj.windowHeight = XmlHelper.ReadUInt(node.Attribute("windowHeight"));
            ctObj.tabRatio = XmlHelper.ReadUInt(node.Attribute("tabRatio"));
            ctObj.activeSheetId = XmlHelper.ReadUInt(node.Attribute("activeSheetId"));
            ctObj.showFormulaBar = XmlHelper.ReadBool(node.Attribute("showFormulaBar"));
            ctObj.showStatusbar = XmlHelper.ReadBool(node.Attribute("showStatusbar"));
            if (node.Attribute("showComments") != null)
                ctObj.showComments = (ST_Comments)Enum.Parse(typeof(ST_Comments), node.Attribute("showComments").Value);
            if (node.Attribute("showObjects") != null)
                ctObj.showObjects = (ST_Objects)Enum.Parse(typeof(ST_Objects), node.Attribute("showObjects").Value);
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "guid", this.guid);
            XmlHelper.WriteAttribute(sw, "autoUpdate", this.autoUpdate);
            XmlHelper.WriteAttribute(sw, "mergeInterval", this.mergeInterval);
            XmlHelper.WriteAttribute(sw, "changesSavedWin", this.changesSavedWin);
            XmlHelper.WriteAttribute(sw, "onlySync", this.onlySync);
            XmlHelper.WriteAttribute(sw, "personalView", this.personalView);
            XmlHelper.WriteAttribute(sw, "includePrintSettings", this.includePrintSettings);
            XmlHelper.WriteAttribute(sw, "includeHiddenRowCol", this.includeHiddenRowCol);
            XmlHelper.WriteAttribute(sw, "maximized", this.maximized);
            XmlHelper.WriteAttribute(sw, "minimized", this.minimized);
            XmlHelper.WriteAttribute(sw, "showHorizontalScroll", this.showHorizontalScroll);
            XmlHelper.WriteAttribute(sw, "showVerticalScroll", this.showVerticalScroll);
            XmlHelper.WriteAttribute(sw, "showSheetTabs", this.showSheetTabs);
            XmlHelper.WriteAttribute(sw, "xWindow", this.xWindow);
            XmlHelper.WriteAttribute(sw, "yWindow", this.yWindow);
            XmlHelper.WriteAttribute(sw, "windowWidth", this.windowWidth);
            XmlHelper.WriteAttribute(sw, "windowHeight", this.windowHeight);
            XmlHelper.WriteAttribute(sw, "tabRatio", this.tabRatio);
            XmlHelper.WriteAttribute(sw, "activeSheetId", this.activeSheetId);
            XmlHelper.WriteAttribute(sw, "showFormulaBar", this.showFormulaBar);
            XmlHelper.WriteAttribute(sw, "showStatusbar", this.showStatusbar);
            XmlHelper.WriteAttribute(sw, "showComments", this.showComments.ToString());
            XmlHelper.WriteAttribute(sw, "showObjects", this.showObjects.ToString());
            sw.Write(">");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</{0}>", nodeName));
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
        public string guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool autoUpdate
        {
            get
            {
                return this.autoUpdateField;
            }
            set
            {
                this.autoUpdateField = value;
            }
        }
        [XmlAttribute]
        public uint mergeInterval
        {
            get
            {
                return this.mergeIntervalField;
            }
            set
            {
                this.mergeIntervalField = value;
            }
        }

        [XmlIgnore]
        public bool mergeIntervalSpecified
        {
            get
            {
                return this.mergeIntervalFieldSpecified;
            }
            set
            {
                this.mergeIntervalFieldSpecified = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool changesSavedWin
        {
            get
            {
                return this.changesSavedWinField;
            }
            set
            {
                this.changesSavedWinField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool onlySync
        {
            get
            {
                return this.onlySyncField;
            }
            set
            {
                this.onlySyncField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool personalView
        {
            get
            {
                return this.personalViewField;
            }
            set
            {
                this.personalViewField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(true)]
        public bool includePrintSettings
        {
            get
            {
                return this.includePrintSettingsField;
            }
            set
            {
                this.includePrintSettingsField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(true)]
        public bool includeHiddenRowCol
        {
            get
            {
                return this.includeHiddenRowColField;
            }
            set
            {
                this.includeHiddenRowColField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool maximized
        {
            get
            {
                return this.maximizedField;
            }
            set
            {
                this.maximizedField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(false)]
        public bool minimized
        {
            get
            {
                return this.minimizedField;
            }
            set
            {
                this.minimizedField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(true)]
        public bool showHorizontalScroll
        {
            get
            {
                return this.showHorizontalScrollField;
            }
            set
            {
                this.showHorizontalScrollField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(true)]
        public bool showVerticalScroll
        {
            get
            {
                return this.showVerticalScrollField;
            }
            set
            {
                this.showVerticalScrollField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(true)]
        public bool showSheetTabs
        {
            get
            {
                return this.showSheetTabsField;
            }
            set
            {
                this.showSheetTabsField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(0)]
        public int xWindow
        {
            get
            {
                return this.xWindowField;
            }
            set
            {
                this.xWindowField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(0)]
        public int yWindow
        {
            get
            {
                return this.yWindowField;
            }
            set
            {
                this.yWindowField = value;
            }
        }
        [XmlAttribute]
        public uint windowWidth
        {
            get
            {
                return this.windowWidthField;
            }
            set
            {
                this.windowWidthField = value;
            }
        }
        [XmlAttribute]
        public uint windowHeight
        {
            get
            {
                return this.windowHeightField;
            }
            set
            {
                this.windowHeightField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(typeof(uint), "600")]
        public uint tabRatio
        {
            get
            {
                return this.tabRatioField;
            }
            set
            {
                this.tabRatioField = value;
            }
        }
        [XmlAttribute]
        public uint activeSheetId
        {
            get
            {
                return this.activeSheetIdField;
            }
            set
            {
                this.activeSheetIdField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(true)]
        public bool showFormulaBar
        {
            get
            {
                return this.showFormulaBarField;
            }
            set
            {
                this.showFormulaBarField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(true)]
        public bool showStatusbar
        {
            get
            {
                return this.showStatusbarField;
            }
            set
            {
                this.showStatusbarField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(ST_Comments.commIndicator)]
        public ST_Comments showComments
        {
            get
            {
                return this.showCommentsField;
            }
            set
            {
                this.showCommentsField = value;
            }
        }
        [XmlAttribute]
        [DefaultValue(ST_Objects.all)]
        public ST_Objects showObjects
        {
            get
            {
                return this.showObjectsField;
            }
            set
            {
                this.showObjectsField = value;
            }
        }
    }
    [Serializable]
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public class CT_CustomWorkbookViews
    {

        private List<CT_CustomWorkbookView> customWorkbookViewField;
        public static CT_CustomWorkbookViews Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_CustomWorkbookViews ctObj = new CT_CustomWorkbookViews();
            ctObj.customWorkbookView = new List<CT_CustomWorkbookView>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "customWorkbookView")
                    ctObj.customWorkbookView.Add(CT_CustomWorkbookView.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            sw.Write(">");
            if (this.customWorkbookView != null)
            {
                foreach (CT_CustomWorkbookView x in this.customWorkbookView)
                {
                    x.Write(sw, "customWorkbookView");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        public CT_CustomWorkbookViews()
        {
            //this.customWorkbookViewField = new List<CT_CustomWorkbookView>();
        }
        [XmlElement]
        public List<CT_CustomWorkbookView> customWorkbookView
        {
            get
            {
                return this.customWorkbookViewField;
            }
            set
            {
                this.customWorkbookViewField = value;
            }
        }
    }
}
