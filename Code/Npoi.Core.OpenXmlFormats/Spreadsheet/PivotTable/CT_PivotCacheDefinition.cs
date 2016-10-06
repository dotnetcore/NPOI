using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Schema;
using NPOI.OpenXml4Net.Util;
using System.IO;
using System.Xml.Linq;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot("pivotCacheDefinition", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
    public partial class CT_PivotCacheDefinition
    {
        public static CT_PivotCacheDefinition Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PivotCacheDefinition ctObj = new CT_PivotCacheDefinition();
            ctObj.id = XmlHelper.ReadString(node.Attribute("r:id"));
            if (node.Attribute("invalid") != null)
                ctObj.invalid = XmlHelper.ReadBool(node.Attribute("invalid"));
            if (node.Attribute("saveData") != null)
                ctObj.saveData = XmlHelper.ReadBool(node.Attribute("saveData"));
            if (node.Attribute("refreshOnLoad") != null)
                ctObj.refreshOnLoad = XmlHelper.ReadBool(node.Attribute("refreshOnLoad"));
            if (node.Attribute("optimizeMemory") != null)
                ctObj.optimizeMemory = XmlHelper.ReadBool(node.Attribute("optimizeMemory"));
            if (node.Attribute("enableRefresh") != null)
                ctObj.enableRefresh = XmlHelper.ReadBool(node.Attribute("enableRefresh"));
            ctObj.refreshedBy = XmlHelper.ReadString(node.Attribute("refreshedBy"));
            if (node.Attribute("refreshedDate") != null)
                ctObj.refreshedDate = XmlHelper.ReadDouble(node.Attribute("refreshedDate"));
            if (node.Attribute("refreshedDateIso") != null)
                if (node.Attribute("backgroundQuery") != null)
                    ctObj.backgroundQuery = XmlHelper.ReadBool(node.Attribute("backgroundQuery"));
            if (node.Attribute("missingItemsLimit") != null)
                ctObj.missingItemsLimit = XmlHelper.ReadUInt(node.Attribute("missingItemsLimit"));
            if (node.Attribute("createdVersion") != null)
                ctObj.createdVersion = XmlHelper.ReadByte(node.Attribute("createdVersion"));
            if (node.Attribute("refreshedVersion") != null)
                ctObj.refreshedVersion = XmlHelper.ReadByte(node.Attribute("refreshedVersion"));
            if (node.Attribute("minRefreshableVersion") != null)
                ctObj.minRefreshableVersion = XmlHelper.ReadByte(node.Attribute("minRefreshableVersion"));
            if (node.Attribute("recordCount") != null)
                ctObj.recordCount = XmlHelper.ReadUInt(node.Attribute("recordCount"));
            if (node.Attribute("upgradeOnRefresh") != null)
                ctObj.upgradeOnRefresh = XmlHelper.ReadBool(node.Attribute("upgradeOnRefresh"));
            if (node.Attribute("tupleCache1") != null)
                ctObj.tupleCache1 = XmlHelper.ReadBool(node.Attribute("tupleCache1"));
            if (node.Attribute("supportSubquery") != null)
                ctObj.supportSubquery = XmlHelper.ReadBool(node.Attribute("supportSubquery"));
            if (node.Attribute("supportAdvancedDrill") != null)
                ctObj.supportAdvancedDrill = XmlHelper.ReadBool(node.Attribute("supportAdvancedDrill"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "cacheSource")
                    ctObj.cacheSource = CT_CacheSource.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "cacheFields")
                    ctObj.cacheFields = CT_CacheFields.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "cacheHierarchies")
                    ctObj.cacheHierarchies = CT_CacheHierarchies.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "kpis")
                    ctObj.kpis = CT_PCDKPIs.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "tupleCache")
                    ctObj.tupleCache = CT_TupleCache.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "calculatedItems")
                    ctObj.calculatedItems = CT_CalculatedItems.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "calculatedMembers")
                    ctObj.calculatedMembers = CT_CalculatedMembers.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "dimensions")
                    ctObj.dimensions = CT_Dimensions.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "measureGroups")
                    ctObj.measureGroups = CT_MeasureGroups.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "maps")
                    ctObj.maps = CT_MeasureDimensionMaps.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw)
        {
            sw.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
            sw.Write("<pivotCacheDefinition xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\" ");
            sw.Write("xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\" ");
            sw.Write("xmlns:s=\"http://schemas.openxmlformats.org/officeDocument/2006/sharedTypes\" ");
            XmlHelper.WriteAttribute(sw, "r:id", this.id);
            XmlHelper.WriteAttribute(sw, "invalid", this.invalid);
            XmlHelper.WriteAttribute(sw, "saveData", this.saveData);
            XmlHelper.WriteAttribute(sw, "refreshOnLoad", this.refreshOnLoad);
            XmlHelper.WriteAttribute(sw, "optimizeMemory", this.optimizeMemory);
            XmlHelper.WriteAttribute(sw, "enableRefresh", this.enableRefresh);
            XmlHelper.WriteAttribute(sw, "refreshedBy", this.refreshedBy);
            XmlHelper.WriteAttribute(sw, "refreshedDate", this.refreshedDate);
            XmlHelper.WriteAttribute(sw, "refreshedDateIso", this.refreshedDateIso);
            XmlHelper.WriteAttribute(sw, "backgroundQuery", this.backgroundQuery);
            XmlHelper.WriteAttribute(sw, "missingItemsLimit", this.missingItemsLimit);
            XmlHelper.WriteAttribute(sw, "createdVersion", this.createdVersion);
            XmlHelper.WriteAttribute(sw, "refreshedVersion", this.refreshedVersion);
            XmlHelper.WriteAttribute(sw, "minRefreshableVersion", this.minRefreshableVersion);
            XmlHelper.WriteAttribute(sw, "recordCount", this.recordCount);
            XmlHelper.WriteAttribute(sw, "upgradeOnRefresh", this.upgradeOnRefresh);
            XmlHelper.WriteAttribute(sw, "tupleCache1", this.tupleCache1);
            XmlHelper.WriteAttribute(sw, "supportSubquery", this.supportSubquery);
            XmlHelper.WriteAttribute(sw, "supportAdvancedDrill", this.supportAdvancedDrill);
            sw.Write(">");
            if (this.cacheSource != null)
                this.cacheSource.Write(sw, "cacheSource");
            if (this.cacheFields != null)
                this.cacheFields.Write(sw, "cacheFields");
            if (this.cacheHierarchies != null)
                this.cacheHierarchies.Write(sw, "cacheHierarchies");
            if (this.kpis != null)
                this.kpis.Write(sw, "kpis");
            if (this.tupleCache != null)
                this.tupleCache.Write(sw, "tupleCache");
            if (this.calculatedItems != null)
                this.calculatedItems.Write(sw, "calculatedItems");
            if (this.calculatedMembers != null)
                this.calculatedMembers.Write(sw, "calculatedMembers");
            if (this.dimensions != null)
                this.dimensions.Write(sw, "dimensions");
            if (this.measureGroups != null)
                this.measureGroups.Write(sw, "measureGroups");
            if (this.maps != null)
                this.maps.Write(sw, "maps");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</pivotCacheDefinition>"));
        }

        public void Save(Stream stream)
        {
            using (StreamWriter sw = new StreamWriter(stream))
            {
                //TODO add namespaceUri
                this.Write(sw);
            }
        }
        private CT_CacheSource cacheSourceField;

        private CT_CacheFields cacheFieldsField;

        private CT_CacheHierarchies cacheHierarchiesField;

        private CT_PCDKPIs kpisField;

        private CT_TupleCache tupleCacheField;

        private CT_CalculatedItems calculatedItemsField;

        private CT_CalculatedMembers calculatedMembersField;

        private CT_Dimensions dimensionsField;

        private CT_MeasureGroups measureGroupsField;

        private CT_MeasureDimensionMaps mapsField;

        private CT_ExtensionList extLstField;

        private string idField;

        private bool invalidField;

        private bool saveDataField;

        private bool refreshOnLoadField;

        private bool optimizeMemoryField;

        private bool enableRefreshField;

        private string refreshedByField;

        private double refreshedDateField;

        private bool refreshedDateFieldSpecified;

        private System.DateTime? refreshedDateIsoField;

        private bool refreshedDateIsoFieldSpecified;

        private bool backgroundQueryField;

        private uint missingItemsLimitField;

        private bool missingItemsLimitFieldSpecified;

        private byte createdVersionField;

        private byte refreshedVersionField;

        private byte minRefreshableVersionField;

        private uint recordCountField;

        private bool recordCountFieldSpecified;

        private bool upgradeOnRefreshField;

        private bool tupleCache1Field;

        private bool supportSubqueryField;

        private bool supportAdvancedDrillField;

        public CT_PivotCacheDefinition()
        {
            this.extLstField = new CT_ExtensionList();
            this.mapsField = new CT_MeasureDimensionMaps();
            this.measureGroupsField = new CT_MeasureGroups();
            this.dimensionsField = new CT_Dimensions();
            this.calculatedMembersField = new CT_CalculatedMembers();
            this.calculatedItemsField = new CT_CalculatedItems();
            this.tupleCacheField = new CT_TupleCache();
            this.kpisField = new CT_PCDKPIs();
            this.cacheHierarchiesField = new CT_CacheHierarchies();
            this.cacheFieldsField = new CT_CacheFields();
            this.cacheSourceField = new CT_CacheSource();
            this.invalidField = false;
            this.saveDataField = true;
            this.refreshOnLoadField = false;
            this.optimizeMemoryField = false;
            this.enableRefreshField = true;
            this.backgroundQueryField = false;
            this.createdVersionField = ((byte)(0));
            this.refreshedVersionField = ((byte)(0));
            this.minRefreshableVersionField = ((byte)(0));
            this.upgradeOnRefreshField = false;
            this.tupleCache1Field = false;
            this.supportSubqueryField = false;
            this.supportAdvancedDrillField = false;
        }

        [XmlElement(Order = 0)]
        public CT_CacheSource cacheSource
        {
            get
            {
                return this.cacheSourceField;
            }
            set
            {
                this.cacheSourceField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_CacheFields cacheFields
        {
            get
            {
                return this.cacheFieldsField;
            }
            set
            {
                this.cacheFieldsField = value;
            }
        }

        [XmlElement(Order = 2)]
        public CT_CacheHierarchies cacheHierarchies
        {
            get
            {
                return this.cacheHierarchiesField;
            }
            set
            {
                this.cacheHierarchiesField = value;
            }
        }

        [XmlElement(Order = 3)]
        public CT_PCDKPIs kpis
        {
            get
            {
                return this.kpisField;
            }
            set
            {
                this.kpisField = value;
            }
        }

        [XmlElement(Order = 4)]
        public CT_TupleCache tupleCache
        {
            get
            {
                return this.tupleCacheField;
            }
            set
            {
                this.tupleCacheField = value;
            }
        }

        [XmlElement(Order = 5)]
        public CT_CalculatedItems calculatedItems
        {
            get
            {
                return this.calculatedItemsField;
            }
            set
            {
                this.calculatedItemsField = value;
            }
        }

        [XmlElement(Order = 6)]
        public CT_CalculatedMembers calculatedMembers
        {
            get
            {
                return this.calculatedMembersField;
            }
            set
            {
                this.calculatedMembersField = value;
            }
        }

        [XmlElement(Order = 7)]
        public CT_Dimensions dimensions
        {
            get
            {
                return this.dimensionsField;
            }
            set
            {
                this.dimensionsField = value;
            }
        }

        [XmlElement(Order = 8)]
        public CT_MeasureGroups measureGroups
        {
            get
            {
                return this.measureGroupsField;
            }
            set
            {
                this.measureGroupsField = value;
            }
        }

        [XmlElement(Order = 9)]
        public CT_MeasureDimensionMaps maps
        {
            get
            {
                return this.mapsField;
            }
            set
            {
                this.mapsField = value;
            }
        }

        [XmlElement(Order = 10)]
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

        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
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

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool invalid
        {
            get
            {
                return this.invalidField;
            }
            set
            {
                this.invalidField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool saveData
        {
            get
            {
                return this.saveDataField;
            }
            set
            {
                this.saveDataField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool refreshOnLoad
        {
            get
            {
                return this.refreshOnLoadField;
            }
            set
            {
                this.refreshOnLoadField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool optimizeMemory
        {
            get
            {
                return this.optimizeMemoryField;
            }
            set
            {
                this.optimizeMemoryField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool enableRefresh
        {
            get
            {
                return this.enableRefreshField;
            }
            set
            {
                this.enableRefreshField = value;
            }
        }

        [XmlAttribute()]
        public string refreshedBy
        {
            get
            {
                return this.refreshedByField;
            }
            set
            {
                this.refreshedByField = value;
            }
        }

        [XmlAttribute()]
        public double refreshedDate
        {
            get
            {
                return this.refreshedDateField;
            }
            set
            {
                this.refreshedDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool refreshedDateSpecified
        {
            get
            {
                return this.refreshedDateFieldSpecified;
            }
            set
            {
                this.refreshedDateFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public System.DateTime? refreshedDateIso
        {
            get
            {
                return this.refreshedDateIsoField;
            }
            set
            {
                this.refreshedDateIsoField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool refreshedDateIsoSpecified
        {
            get
            {
                return this.refreshedDateIsoFieldSpecified;
            }
            set
            {
                this.refreshedDateIsoFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool backgroundQuery
        {
            get
            {
                return this.backgroundQueryField;
            }
            set
            {
                this.backgroundQueryField = value;
            }
        }

        [XmlAttribute()]
        public uint missingItemsLimit
        {
            get
            {
                return this.missingItemsLimitField;
            }
            set
            {
                this.missingItemsLimitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool missingItemsLimitSpecified
        {
            get
            {
                return this.missingItemsLimitFieldSpecified;
            }
            set
            {
                this.missingItemsLimitFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
        public byte createdVersion
        {
            get
            {
                return this.createdVersionField;
            }
            set
            {
                this.createdVersionField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
        public byte refreshedVersion
        {
            get
            {
                return this.refreshedVersionField;
            }
            set
            {
                this.refreshedVersionField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
        public byte minRefreshableVersion
        {
            get
            {
                return this.minRefreshableVersionField;
            }
            set
            {
                this.minRefreshableVersionField = value;
            }
        }

        [XmlAttribute()]
        public uint recordCount
        {
            get
            {
                return this.recordCountField;
            }
            set
            {
                this.recordCountField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recordCountSpecified
        {
            get
            {
                return this.recordCountFieldSpecified;
            }
            set
            {
                this.recordCountFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool upgradeOnRefresh
        {
            get
            {
                return this.upgradeOnRefreshField;
            }
            set
            {
                this.upgradeOnRefreshField = value;
            }
        }

        [XmlAttribute("tupleCache")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool tupleCache1
        {
            get
            {
                return this.tupleCache1Field;
            }
            set
            {
                this.tupleCache1Field = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool supportSubquery
        {
            get
            {
                return this.supportSubqueryField;
            }
            set
            {
                this.supportSubqueryField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool supportAdvancedDrill
        {
            get
            {
                return this.supportAdvancedDrillField;
            }
            set
            {
                this.supportAdvancedDrillField = value;
            }
        }

        public CT_CacheFields AddNewCacheFields()
        {
            this.cacheFieldsField = new CT_CacheFields();
            return this.cacheFieldsField;
        }


        public CT_CacheSource AddNewCacheSource()
        {
            this.cacheSourceField = new CT_CacheSource();
            return this.cacheSourceField;
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Pages
    {
        public static CT_Pages Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Pages ctObj = new CT_Pages();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.page = new List<CT_PCDSCPage>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "page")
                    ctObj.page.Add(CT_PCDSCPage.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.page != null)
            {
                foreach (CT_PCDSCPage x in this.page)
                {
                    x.Write(sw, "page");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_PCDSCPage> pageField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_Pages()
        {
            this.pageField = new List<CT_PCDSCPage>();
        }

        [XmlElement("page", Order = 0)]
        public List<CT_PCDSCPage> page
        {
            get
            {
                return this.pageField;
            }
            set
            {
                this.pageField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_PCDSCPage
    {
        public static CT_PCDSCPage Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PCDSCPage ctObj = new CT_PCDSCPage();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.pageItem = new List<CT_PageItem>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "pageItem")
                    ctObj.pageItem.Add(CT_PageItem.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.pageItem != null)
            {
                foreach (CT_PageItem x in this.pageItem)
                {
                    x.Write(sw, "pageItem");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_PageItem> pageItemField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_PCDSCPage()
        {
            this.pageItemField = new List<CT_PageItem>();
        }

        [XmlElement("pageItem", Order = 0)]
        public List<CT_PageItem> pageItem
        {
            get
            {
                return this.pageItemField;
            }
            set
            {
                this.pageItemField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_PageItem
    {
        public static CT_PageItem Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PageItem ctObj = new CT_PageItem();
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "name", this.name);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private string nameField;

        [XmlAttribute()]
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
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_RangeSets
    {
        public static CT_RangeSets Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_RangeSets ctObj = new CT_RangeSets();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.rangeSet = new List<CT_RangeSet>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "rangeSet")
                    ctObj.rangeSet.Add(CT_RangeSet.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.rangeSet != null)
            {
                foreach (CT_RangeSet x in this.rangeSet)
                {
                    x.Write(sw, "rangeSet");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_RangeSet> rangeSetField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_RangeSets()
        {
            this.rangeSetField = new List<CT_RangeSet>();
        }

        [XmlElement("rangeSet", Order = 0)]
        public List<CT_RangeSet> rangeSet
        {
            get
            {
                return this.rangeSetField;
            }
            set
            {
                this.rangeSetField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_RangeSet
    {
        public static CT_RangeSet Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_RangeSet ctObj = new CT_RangeSet();
            if (node.Attribute("i1") != null)
                ctObj.i1 = XmlHelper.ReadUInt(node.Attribute("i1"));
            if (node.Attribute("i2") != null)
                ctObj.i2 = XmlHelper.ReadUInt(node.Attribute("i2"));
            if (node.Attribute("i3") != null)
                ctObj.i3 = XmlHelper.ReadUInt(node.Attribute("i3"));
            if (node.Attribute("i4") != null)
                ctObj.i4 = XmlHelper.ReadUInt(node.Attribute("i4"));
            ctObj.@ref = XmlHelper.ReadString(node.Attribute("ref"));
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            ctObj.sheet = XmlHelper.ReadString(node.Attribute("sheet"));
            ctObj.id = XmlHelper.ReadString(node.Attribute("r:id"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "i1", this.i1);
            XmlHelper.WriteAttribute(sw, "i2", this.i2);
            XmlHelper.WriteAttribute(sw, "i3", this.i3);
            XmlHelper.WriteAttribute(sw, "i4", this.i4);
            XmlHelper.WriteAttribute(sw, "ref", this.@ref);
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "sheet", this.sheet);
            XmlHelper.WriteAttribute(sw, "r:id", this.id);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private uint i1Field;

        private bool i1FieldSpecified;

        private uint i2Field;

        private bool i2FieldSpecified;

        private uint i3Field;

        private bool i3FieldSpecified;

        private uint i4Field;

        private bool i4FieldSpecified;

        private string refField;

        private string nameField;

        private string sheetField;

        private string idField;

        [XmlAttribute()]
        public uint i1
        {
            get
            {
                return this.i1Field;
            }
            set
            {
                this.i1Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool i1Specified
        {
            get
            {
                return this.i1FieldSpecified;
            }
            set
            {
                this.i1FieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public uint i2
        {
            get
            {
                return this.i2Field;
            }
            set
            {
                this.i2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool i2Specified
        {
            get
            {
                return this.i2FieldSpecified;
            }
            set
            {
                this.i2FieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public uint i3
        {
            get
            {
                return this.i3Field;
            }
            set
            {
                this.i3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool i3Specified
        {
            get
            {
                return this.i3FieldSpecified;
            }
            set
            {
                this.i3FieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public uint i4
        {
            get
            {
                return this.i4Field;
            }
            set
            {
                this.i4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool i4Specified
        {
            get
            {
                return this.i4FieldSpecified;
            }
            set
            {
                this.i4FieldSpecified = value;
            }
        }

        [XmlAttribute()]
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

        [XmlAttribute()]
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

        [XmlAttribute()]
        public string sheet
        {
            get
            {
                return this.sheetField;
            }
            set
            {
                this.sheetField = value;
            }
        }

        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
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
    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Consolidation
    {
        public static CT_Consolidation Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Consolidation ctObj = new CT_Consolidation();
            if (node.Attribute("autoPage") != null)
                ctObj.autoPage = XmlHelper.ReadBool(node.Attribute("autoPage"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "pages")
                    ctObj.pages = CT_Pages.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "rangeSets")
                    ctObj.rangeSets = CT_RangeSets.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "autoPage", this.autoPage);
            sw.Write(">");
            if (this.pages != null)
                this.pages.Write(sw, "pages");
            if (this.rangeSets != null)
                this.rangeSets.Write(sw, "rangeSets");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_Pages pagesField;

        private CT_RangeSets rangeSetsField;

        private bool autoPageField;

        public CT_Consolidation()
        {
            this.rangeSetsField = new CT_RangeSets();
            this.pagesField = new CT_Pages();
            this.autoPageField = true;
        }

        [XmlElement(Order = 0)]
        public CT_Pages pages
        {
            get
            {
                return this.pagesField;
            }
            set
            {
                this.pagesField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_RangeSets rangeSets
        {
            get
            {
                return this.rangeSetsField;
            }
            set
            {
                this.rangeSetsField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool autoPage
        {
            get
            {
                return this.autoPageField;
            }
            set
            {
                this.autoPageField = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_WorksheetSource
    {
        public static CT_WorksheetSource Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_WorksheetSource ctObj = new CT_WorksheetSource();
            ctObj.@ref = XmlHelper.ReadString(node.Attribute("ref"));
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            ctObj.sheet = XmlHelper.ReadString(node.Attribute("sheet"));
            ctObj.id = XmlHelper.ReadString(node.Attribute("r:id"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "ref", this.@ref);
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "sheet", this.sheet);
            XmlHelper.WriteAttribute(sw, "r:id", this.id);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private string refField;

        private string nameField;

        private string sheetField;

        private string idField;

        [XmlAttribute()]
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

        [XmlAttribute()]
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

        [XmlAttribute()]
        public string sheet
        {
            get
            {
                return this.sheetField;
            }
            set
            {
                this.sheetField = value;
            }
        }

        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
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

    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
    public enum ST_SourceType
    {

        /// <remarks/>
        worksheet,

        /// <remarks/>
        external,

        /// <remarks/>
        consolidation,

        /// <remarks/>
        scenario,
    }
    
    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_CacheSource
    {
        public static CT_CacheSource Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_CacheSource ctObj = new CT_CacheSource();
            if (node.Attribute("type") != null)
                ctObj.type = (ST_SourceType)Enum.Parse(typeof(ST_SourceType), node.Attribute("type").Value);
            if (node.Attribute("connectionId") != null)
                ctObj.connectionId = XmlHelper.ReadUInt(node.Attribute("connectionId"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "worksheetSource")
                    ctObj.worksheetSource = CT_WorksheetSource.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "consolidation")
                    ctObj.consolidation = CT_Consolidation.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
            XmlHelper.WriteAttribute(sw, "connectionId", this.connectionId);
            sw.Write(">");

            if (this.worksheetSource != null)
                this.worksheetSource.Write(sw, "worksheetSource");
            if (this.consolidation != null)
                this.consolidation.Write(sw, "consolidation");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</{0}>", nodeName));
        }


        private object itemField;

        private ST_SourceType typeField;

        private uint connectionIdField;

        private CT_WorksheetSource worksheetSourceField;

        private CT_ExtensionList extLstField;

        private CT_Consolidation consolidationField;

        public CT_CacheSource()
        {
            this.connectionIdField = ((uint)(0));
        }

        [XmlElement("consolidation", typeof(CT_Consolidation), Order = 0)]
        [XmlElement("extLst", typeof(CT_ExtensionList), Order = 0)]
        [XmlElement("worksheetSource", typeof(CT_WorksheetSource), Order = 0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlAttribute()]
        public ST_SourceType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
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

        public CT_WorksheetSource worksheetSource
        {
            get
            {
                return this.worksheetSourceField;
            }
            set
            {
                this.worksheetSourceField = value;
            }
        }

        public CT_Consolidation consolidation
        {
            get
            {
                return this.consolidationField;
            }
            set
            {
                this.consolidationField = value;
            }
        }

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
        public CT_WorksheetSource AddNewWorksheetSource()
        {
            this.worksheetSourceField = new CT_WorksheetSource();
            return this.worksheetSourceField;
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_CacheFields
    {
        public static CT_CacheFields Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_CacheFields ctObj = new CT_CacheFields();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.cacheField = new List<CT_CacheField>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "cacheField")
                    ctObj.cacheField.Add(CT_CacheField.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.cacheField != null)
            {
                foreach (CT_CacheField x in this.cacheField)
                {
                    x.Write(sw, "cacheField");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_CacheField> cacheFieldField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_CacheFields()
        {
            this.cacheFieldField = new List<CT_CacheField>();
        }

        [XmlElement("cacheField", Order = 0)]
        public List<CT_CacheField> cacheField
        {
            get
            {
                return this.cacheFieldField;
            }
            set
            {
                this.cacheFieldField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

        public CT_CacheField AddNewCacheField()
        {
            CT_CacheField f = new CT_CacheField();
            this.cacheFieldField.Add(f);
            return f;
        }

        public uint SizeOfCacheFieldArray()
        {
            if (this.cacheFieldField == null)
                return 0;
            return (uint)this.cacheFieldField.Count;
        }
    }
    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_SharedItems
    {
        public static CT_SharedItems Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_SharedItems ctObj = new CT_SharedItems();
            if (node.Attribute("containsSemiMixedTypes") != null)
                ctObj.containsSemiMixedTypes = XmlHelper.ReadBool(node.Attribute("containsSemiMixedTypes"));
            if (node.Attribute("containsNonDate") != null)
                ctObj.containsNonDate = XmlHelper.ReadBool(node.Attribute("containsNonDate"));
            if (node.Attribute("containsDate") != null)
                ctObj.containsDate = XmlHelper.ReadBool(node.Attribute("containsDate"));
            if (node.Attribute("containsString") != null)
                ctObj.containsString = XmlHelper.ReadBool(node.Attribute("containsString"));
            if (node.Attribute("containsBlank") != null)
                ctObj.containsBlank = XmlHelper.ReadBool(node.Attribute("containsBlank"));
            if (node.Attribute("containsMixedTypes") != null)
                ctObj.containsMixedTypes = XmlHelper.ReadBool(node.Attribute("containsMixedTypes"));
            if (node.Attribute("containsNumber") != null)
                ctObj.containsNumber = XmlHelper.ReadBool(node.Attribute("containsNumber"));
            if (node.Attribute("containsInteger") != null)
                ctObj.containsInteger = XmlHelper.ReadBool(node.Attribute("containsInteger"));
            if (node.Attribute("minValue") != null)
                ctObj.minValue = XmlHelper.ReadDouble(node.Attribute("minValue"));
            if (node.Attribute("maxValue") != null)
                ctObj.maxValue = XmlHelper.ReadDouble(node.Attribute("maxValue"));
            if (node.Attribute("minDate") != null)
                ctObj.minDate = XmlHelper.ReadDateTime(node.Attribute("minDate"));
            if (node.Attribute("maxDate") != null)
                ctObj.maxDate = XmlHelper.ReadDateTime(node.Attribute("maxDate"));
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            if (node.Attribute("longText") != null)
                ctObj.longText = XmlHelper.ReadBool(node.Attribute("longText"));
            ctObj.Items = new List<Object>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "n")
                {
                    ctObj.Items.Add(CT_Number.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.n);
                }
                else if (childNode.Name.LocalName == "b")
                {
                    ctObj.Items.Add(CT_Boolean.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.b);
                }
                else if (childNode.Name.LocalName == "d")
                {
                    ctObj.Items.Add(CT_DateTime.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.d);
                }
                else if (childNode.Name.LocalName == "e")
                {
                    ctObj.Items.Add(CT_Error.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.e);
                }
                else if (childNode.Name.LocalName == "m")
                {
                    ctObj.Items.Add(CT_Missing.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.m);
                }
                else if (childNode.Name.LocalName == "s")
                {
                    ctObj.Items.Add(CT_String.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.s);
                }
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "containsSemiMixedTypes", this.containsSemiMixedTypes);
            XmlHelper.WriteAttribute(sw, "containsNonDate", this.containsNonDate);
            XmlHelper.WriteAttribute(sw, "containsDate", this.containsDate);
            XmlHelper.WriteAttribute(sw, "containsString", this.containsString);
            XmlHelper.WriteAttribute(sw, "containsBlank", this.containsBlank);
            XmlHelper.WriteAttribute(sw, "containsMixedTypes", this.containsMixedTypes);
            XmlHelper.WriteAttribute(sw, "containsNumber", this.containsNumber);
            XmlHelper.WriteAttribute(sw, "containsInteger", this.containsInteger);
            XmlHelper.WriteAttribute(sw, "minValue", this.minValue);
            XmlHelper.WriteAttribute(sw, "maxValue", this.maxValue);
            XmlHelper.WriteAttribute(sw, "minDate", this.minDate);
            XmlHelper.WriteAttribute(sw, "maxDate", this.maxDate);
            XmlHelper.WriteAttribute(sw, "count", this.count);
            XmlHelper.WriteAttribute(sw, "longText", this.longText);
            sw.Write(">");

            foreach (object o in this.Items)
            {
                if (o is CT_Number)
                    ((CT_Number)o).Write(sw, "n");
                else if (o is CT_Boolean)
                    ((CT_Boolean)o).Write(sw, "b");
                else if (o is CT_DateTime)
                    ((CT_DateTime)o).Write(sw, "d");
                else if (o is CT_Error)
                    ((CT_Error)o).Write(sw, "e");
                else if (o is CT_Missing)
                    ((CT_Missing)o).Write(sw, "m");
                else if (o is CT_String)
                    ((CT_String)o).Write(sw, "s");
            }

            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<object> itemsField;

        private bool containsSemiMixedTypesField;

        private bool containsNonDateField;

        private bool containsDateField;

        private bool containsStringField;

        private bool containsBlankField;

        private bool containsMixedTypesField;

        private bool containsNumberField;

        private bool containsIntegerField;

        private double minValueField;

        private bool minValueFieldSpecified;

        private double maxValueField;

        private bool maxValueFieldSpecified;

        private System.DateTime? minDateField;

        private bool minDateFieldSpecified;

        private System.DateTime? maxDateField;

        private bool maxDateFieldSpecified;

        private uint countField;

        private bool countFieldSpecified;

        private bool longTextField;

        public CT_SharedItems()
        {
            this.itemsField = new List<object>();
            this.containsSemiMixedTypesField = true;
            this.containsNonDateField = true;
            this.containsDateField = false;
            this.containsStringField = true;
            this.containsBlankField = false;
            this.containsMixedTypesField = false;
            this.containsNumberField = false;
            this.containsIntegerField = false;
            this.longTextField = false;
        }

        [XmlElement("b", typeof(CT_Boolean), Order = 0)]
        [XmlElement("d", typeof(CT_DateTime), Order = 0)]
        [XmlElement("e", typeof(CT_Error), Order = 0)]
        [XmlElement("m", typeof(CT_Missing), Order = 0)]
        [XmlElement("n", typeof(CT_Number), Order = 0)]
        [XmlElement("s", typeof(CT_String), Order = 0)]
        public List<object> Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool containsSemiMixedTypes
        {
            get
            {
                return this.containsSemiMixedTypesField;
            }
            set
            {
                this.containsSemiMixedTypesField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool containsNonDate
        {
            get
            {
                return this.containsNonDateField;
            }
            set
            {
                this.containsNonDateField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool containsDate
        {
            get
            {
                return this.containsDateField;
            }
            set
            {
                this.containsDateField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool containsString
        {
            get
            {
                return this.containsStringField;
            }
            set
            {
                this.containsStringField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool containsBlank
        {
            get
            {
                return this.containsBlankField;
            }
            set
            {
                this.containsBlankField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool containsMixedTypes
        {
            get
            {
                return this.containsMixedTypesField;
            }
            set
            {
                this.containsMixedTypesField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool containsNumber
        {
            get
            {
                return this.containsNumberField;
            }
            set
            {
                this.containsNumberField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool containsInteger
        {
            get
            {
                return this.containsIntegerField;
            }
            set
            {
                this.containsIntegerField = value;
            }
        }

        [XmlAttribute()]
        public double minValue
        {
            get
            {
                return this.minValueField;
            }
            set
            {
                this.minValueField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minValueSpecified
        {
            get
            {
                return this.minValueFieldSpecified;
            }
            set
            {
                this.minValueFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public double maxValue
        {
            get
            {
                return this.maxValueField;
            }
            set
            {
                this.maxValueField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxValueSpecified
        {
            get
            {
                return this.maxValueFieldSpecified;
            }
            set
            {
                this.maxValueFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public System.DateTime? minDate
        {
            get
            {
                return this.minDateField;
            }
            set
            {
                this.minDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minDateSpecified
        {
            get
            {
                return this.minDateFieldSpecified;
            }
            set
            {
                this.minDateFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public System.DateTime? maxDate
        {
            get
            {
                return this.maxDateField;
            }
            set
            {
                this.maxDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxDateSpecified
        {
            get
            {
                return this.maxDateFieldSpecified;
            }
            set
            {
                this.maxDateFieldSpecified = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool longText
        {
            get
            {
                return this.longTextField;
            }
            set
            {
                this.longTextField = value;
            }
        }
    }
    
    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_CacheField
    {
        public static CT_CacheField Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_CacheField ctObj = new CT_CacheField();
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            ctObj.caption = XmlHelper.ReadString(node.Attribute("caption"));
            ctObj.propertyName = XmlHelper.ReadString(node.Attribute("propertyName"));
            if (node.Attribute("serverField") != null)
                ctObj.serverField = XmlHelper.ReadBool(node.Attribute("serverField"));
            if (node.Attribute("uniqueList") != null)
                ctObj.uniqueList = XmlHelper.ReadBool(node.Attribute("uniqueList"));
            if (node.Attribute("numFmtId") != null)
                ctObj.numFmtId = XmlHelper.ReadUInt(node.Attribute("numFmtId"));
            ctObj.formula = XmlHelper.ReadString(node.Attribute("formula"));
            if (node.Attribute("sqlType") != null)
                ctObj.sqlType = XmlHelper.ReadInt(node.Attribute("sqlType"));
            if (node.Attribute("hierarchy") != null)
                ctObj.hierarchy = XmlHelper.ReadInt(node.Attribute("hierarchy"));
            if (node.Attribute("level") != null)
                ctObj.level = XmlHelper.ReadUInt(node.Attribute("level"));
            if (node.Attribute("databaseField") != null)
                ctObj.databaseField = XmlHelper.ReadBool(node.Attribute("databaseField"));
            if (node.Attribute("mappingCount") != null)
                ctObj.mappingCount = XmlHelper.ReadUInt(node.Attribute("mappingCount"));
            if (node.Attribute("memberPropertyField") != null)
                ctObj.memberPropertyField = XmlHelper.ReadBool(node.Attribute("memberPropertyField"));
            ctObj.mpMap = new List<CT_X>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "sharedItems")
                    ctObj.sharedItems = CT_SharedItems.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "fieldGroup")
                    ctObj.fieldGroup = CT_FieldGroup.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "mpMap")
                    ctObj.mpMap.Add(CT_X.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "caption", this.caption);
            XmlHelper.WriteAttribute(sw, "propertyName", this.propertyName);
            XmlHelper.WriteAttribute(sw, "serverField", this.serverField);
            XmlHelper.WriteAttribute(sw, "uniqueList", this.uniqueList);
            XmlHelper.WriteAttribute(sw, "numFmtId", this.numFmtId);
            XmlHelper.WriteAttribute(sw, "formula", this.formula);
            XmlHelper.WriteAttribute(sw, "sqlType", this.sqlType);
            XmlHelper.WriteAttribute(sw, "hierarchy", this.hierarchy);
            XmlHelper.WriteAttribute(sw, "level", this.level);
            XmlHelper.WriteAttribute(sw, "databaseField", this.databaseField);
            XmlHelper.WriteAttribute(sw, "mappingCount", this.mappingCount);
            XmlHelper.WriteAttribute(sw, "memberPropertyField", this.memberPropertyField);
            sw.Write(">");
            if (this.sharedItems != null)
                this.sharedItems.Write(sw, "sharedItems");
            if (this.fieldGroup != null)
                this.fieldGroup.Write(sw, "fieldGroup");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            if (this.mpMap != null)
            {
                foreach (CT_X x in this.mpMap)
                {
                    x.Write(sw, "mpMap");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_SharedItems sharedItemsField;

        private CT_FieldGroup fieldGroupField;

        private List<CT_X> mpMapField;

        private CT_ExtensionList extLstField;

        private string nameField;

        private string captionField;

        private string propertyNameField;

        private bool serverFieldField;

        private bool uniqueListField;

        private uint numFmtIdField;

        private bool numFmtIdFieldSpecified;

        private string formulaField;

        private int sqlTypeField;

        private int hierarchyField;

        private uint levelField;

        private bool databaseFieldField;

        private uint mappingCountField;

        private bool mappingCountFieldSpecified;

        private bool memberPropertyFieldField;

        public CT_CacheField()
        {
            this.extLstField = new CT_ExtensionList();
            this.mpMapField = new List<CT_X>();
            this.fieldGroupField = new CT_FieldGroup();
            this.sharedItemsField = new CT_SharedItems();
            this.serverFieldField = false;
            this.uniqueListField = true;
            this.sqlTypeField = 0;
            this.hierarchyField = 0;
            this.levelField = ((uint)(0));
            this.databaseFieldField = true;
            this.memberPropertyFieldField = false;
        }

        [XmlElement(Order = 0)]
        public CT_SharedItems sharedItems
        {
            get
            {
                return this.sharedItemsField;
            }
            set
            {
                this.sharedItemsField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_FieldGroup fieldGroup
        {
            get
            {
                return this.fieldGroupField;
            }
            set
            {
                this.fieldGroupField = value;
            }
        }

        [XmlElement("mpMap", Order = 2)]
        public List<CT_X> mpMap
        {
            get
            {
                return this.mpMapField;
            }
            set
            {
                this.mpMapField = value;
            }
        }

        [XmlElement(Order = 3)]
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

        [XmlAttribute()]
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

        [XmlAttribute()]
        public string caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }

        [XmlAttribute()]
        public string propertyName
        {
            get
            {
                return this.propertyNameField;
            }
            set
            {
                this.propertyNameField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool serverField
        {
            get
            {
                return this.serverFieldField;
            }
            set
            {
                this.serverFieldField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool uniqueList
        {
            get
            {
                return this.uniqueListField;
            }
            set
            {
                this.uniqueListField = value;
            }
        }

        [XmlAttribute()]
        public uint numFmtId
        {
            get
            {
                return this.numFmtIdField;
            }
            set
            {
                this.numFmtIdField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numFmtIdSpecified
        {
            get
            {
                return this.numFmtIdFieldSpecified;
            }
            set
            {
                this.numFmtIdFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string formula
        {
            get
            {
                return this.formulaField;
            }
            set
            {
                this.formulaField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int sqlType
        {
            get
            {
                return this.sqlTypeField;
            }
            set
            {
                this.sqlTypeField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int hierarchy
        {
            get
            {
                return this.hierarchyField;
            }
            set
            {
                this.hierarchyField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool databaseField
        {
            get
            {
                return this.databaseFieldField;
            }
            set
            {
                this.databaseFieldField = value;
            }
        }

        [XmlAttribute()]
        public uint mappingCount
        {
            get
            {
                return this.mappingCountField;
            }
            set
            {
                this.mappingCountField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool mappingCountSpecified
        {
            get
            {
                return this.mappingCountFieldSpecified;
            }
            set
            {
                this.mappingCountFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool memberPropertyField
        {
            get
            {
                return this.memberPropertyFieldField;
            }
            set
            {
                this.memberPropertyFieldField = value;
            }
        }

        public CT_SharedItems AddNewSharedItems()
        {
            this.sharedItemsField = new CT_SharedItems();
            return this.sharedItemsField;
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_CacheHierarchies
    {
        public static CT_CacheHierarchies Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_CacheHierarchies ctObj = new CT_CacheHierarchies();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.cacheHierarchy = new List<CT_CacheHierarchy>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "cacheHierarchy")
                    ctObj.cacheHierarchy.Add(CT_CacheHierarchy.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.cacheHierarchy != null)
            {
                foreach (CT_CacheHierarchy x in this.cacheHierarchy)
                {
                    x.Write(sw, "cacheHierarchy");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_CacheHierarchy> cacheHierarchyField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_CacheHierarchies()
        {
            this.cacheHierarchyField = new List<CT_CacheHierarchy>();
        }

        [XmlElement("cacheHierarchy", Order = 0)]
        public List<CT_CacheHierarchy> cacheHierarchy
        {
            get
            {
                return this.cacheHierarchyField;
            }
            set
            {
                this.cacheHierarchyField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Boolean
    {
        public static CT_Boolean Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Boolean ctObj = new CT_Boolean();
            if (node.Attribute("v") != null)
                ctObj.v = XmlHelper.ReadBool(node.Attribute("v"));
            if (node.Attribute("u") != null)
                ctObj.u = XmlHelper.ReadBool(node.Attribute("u"));
            if (node.Attribute("f") != null)
                ctObj.f = XmlHelper.ReadBool(node.Attribute("f"));
            ctObj.c = XmlHelper.ReadString(node.Attribute("c"));
            if (node.Attribute("cp") != null)
                ctObj.cp = XmlHelper.ReadUInt(node.Attribute("cp"));
            ctObj.x = new List<CT_X>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "x")
                    ctObj.x.Add(CT_X.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "v", this.v);
            XmlHelper.WriteAttribute(sw, "u", this.u);
            XmlHelper.WriteAttribute(sw, "f", this.f);
            XmlHelper.WriteAttribute(sw, "c", this.c);
            XmlHelper.WriteAttribute(sw, "cp", this.cp);
            sw.Write(">");
            if (this.x != null)
            {
                foreach (CT_X x in this.x)
                {
                    x.Write(sw, "x");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_X> xField;

        private bool vField;

        private bool uField;

        private bool uFieldSpecified;

        private bool fField;

        private bool fFieldSpecified;

        private string cField;

        private uint cpField;

        private bool cpFieldSpecified;

        public CT_Boolean()
        {
            this.xField = new List<CT_X>();
        }

        [XmlElement("x", Order = 0)]
        public List<CT_X> x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        [XmlAttribute()]
        public bool v
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }

        [XmlAttribute()]
        public bool u
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uSpecified
        {
            get
            {
                return this.uFieldSpecified;
            }
            set
            {
                this.uFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public bool f
        {
            get
            {
                return this.fField;
            }
            set
            {
                this.fField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fSpecified
        {
            get
            {
                return this.fFieldSpecified;
            }
            set
            {
                this.fFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string c
        {
            get
            {
                return this.cField;
            }
            set
            {
                this.cField = value;
            }
        }

        [XmlAttribute()]
        public uint cp
        {
            get
            {
                return this.cpField;
            }
            set
            {
                this.cpField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cpSpecified
        {
            get
            {
                return this.cpFieldSpecified;
            }
            set
            {
                this.cpFieldSpecified = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_X
    {

        private int vField;

        public CT_X()
        {
            this.vField = 0;
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int v
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }

        public static CT_X Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_X ctObj = new CT_X();
            if (node.Attribute("v") != null)
                ctObj.v = XmlHelper.ReadInt(node.Attribute("v"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "v", this.v);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_DateTime
    {
        public static CT_DateTime Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_DateTime ctObj = new CT_DateTime();
            if (node.Attribute("v") != null)
                ctObj.v = XmlHelper.ReadDateTime(node.Attribute("v")); 
            if (node.Attribute("u") != null)
                ctObj.u = XmlHelper.ReadBool(node.Attribute("u"));
            if (node.Attribute("f") != null)
                ctObj.f = XmlHelper.ReadBool(node.Attribute("f"));
            ctObj.c = XmlHelper.ReadString(node.Attribute("c"));
            if (node.Attribute("cp") != null)
                ctObj.cp = XmlHelper.ReadUInt(node.Attribute("cp"));
            ctObj.x = new List<CT_X>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "x")
                    ctObj.x.Add(CT_X.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "v", this.v);
            XmlHelper.WriteAttribute(sw, "u", this.u);
            XmlHelper.WriteAttribute(sw, "f", this.f);
            XmlHelper.WriteAttribute(sw, "c", this.c);
            XmlHelper.WriteAttribute(sw, "cp", this.cp);
            sw.Write(">");
            if (this.x != null)
            {
                foreach (CT_X x in this.x)
                {
                    x.Write(sw, "x");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_X> xField;

        private System.DateTime? vField;

        private bool uField;

        private bool uFieldSpecified;

        private bool fField;

        private bool fFieldSpecified;

        private string cField;

        private uint cpField;

        private bool cpFieldSpecified;

        public CT_DateTime()
        {
            this.xField = new List<CT_X>();
        }

        [XmlElement("x", Order = 0)]
        public List<CT_X> x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        [XmlAttribute()]
        public System.DateTime? v
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }

        [XmlAttribute()]
        public bool u
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uSpecified
        {
            get
            {
                return this.uFieldSpecified;
            }
            set
            {
                this.uFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public bool f
        {
            get
            {
                return this.fField;
            }
            set
            {
                this.fField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fSpecified
        {
            get
            {
                return this.fFieldSpecified;
            }
            set
            {
                this.fFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string c
        {
            get
            {
                return this.cField;
            }
            set
            {
                this.cField = value;
            }
        }

        [XmlAttribute()]
        public uint cp
        {
            get
            {
                return this.cpField;
            }
            set
            {
                this.cpField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cpSpecified
        {
            get
            {
                return this.cpFieldSpecified;
            }
            set
            {
                this.cpFieldSpecified = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Error
    {

        private CT_Tuples tplsField;

        private List<CT_X> xField;

        private string vField;

        private bool uField;

        private bool uFieldSpecified;

        private bool fField;

        private bool fFieldSpecified;

        private string cField;

        private uint cpField;

        private bool cpFieldSpecified;

        private uint inField;

        private bool inFieldSpecified;

        private byte[] bcField;

        private byte[] fcField;

        private bool iField;

        private bool unField;

        private bool stField;

        private bool bField;

        public CT_Error()
        {
            this.xField = new List<CT_X>();
            this.tplsField = new CT_Tuples();
            this.iField = false;
            this.unField = false;
            this.stField = false;
            this.bField = false;
        }

        [XmlElement(Order = 0)]
        public CT_Tuples tpls
        {
            get
            {
                return this.tplsField;
            }
            set
            {
                this.tplsField = value;
            }
        }

        [XmlElement("x", Order = 1)]
        public List<CT_X> x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        [XmlAttribute()]
        public string v
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }

        [XmlAttribute()]
        public bool u
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uSpecified
        {
            get
            {
                return this.uFieldSpecified;
            }
            set
            {
                this.uFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public bool f
        {
            get
            {
                return this.fField;
            }
            set
            {
                this.fField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fSpecified
        {
            get
            {
                return this.fFieldSpecified;
            }
            set
            {
                this.fFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string c
        {
            get
            {
                return this.cField;
            }
            set
            {
                this.cField = value;
            }
        }

        [XmlAttribute()]
        public uint cp
        {
            get
            {
                return this.cpField;
            }
            set
            {
                this.cpField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cpSpecified
        {
            get
            {
                return this.cpFieldSpecified;
            }
            set
            {
                this.cpFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public uint @in
        {
            get
            {
                return this.inField;
            }
            set
            {
                this.inField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inSpecified
        {
            get
            {
                return this.inFieldSpecified;
            }
            set
            {
                this.inFieldSpecified = value;
            }
        }

        [XmlAttribute(DataType = "hexBinary")]
        public byte[] bc
        {
            get
            {
                return this.bcField;
            }
            set
            {
                this.bcField = value;
            }
        }

        [XmlAttribute(DataType = "hexBinary")]
        public byte[] fc
        {
            get
            {
                return this.fcField;
            }
            set
            {
                this.fcField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool i
        {
            get
            {
                return this.iField;
            }
            set
            {
                this.iField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool un
        {
            get
            {
                return this.unField;
            }
            set
            {
                this.unField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool st
        {
            get
            {
                return this.stField;
            }
            set
            {
                this.stField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool b
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }

        public static CT_Error Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Error ctObj = new CT_Error();
            ctObj.v = XmlHelper.ReadString(node.Attribute("v"));
            if (node.Attribute("u") != null)
                ctObj.u = XmlHelper.ReadBool(node.Attribute("u"));
            if (node.Attribute("f") != null)
                ctObj.f = XmlHelper.ReadBool(node.Attribute("f"));
            ctObj.c = XmlHelper.ReadString(node.Attribute("c"));
            if (node.Attribute("cp") != null)
                ctObj.cp = XmlHelper.ReadUInt(node.Attribute("cp"));
            if (node.Attribute("in") != null)
                ctObj.@in = XmlHelper.ReadUInt(node.Attribute("in"));
            ctObj.bc = XmlHelper.ReadBytes(node.Attribute("bc"));
            ctObj.fc = XmlHelper.ReadBytes(node.Attribute("fc"));
            if (node.Attribute("i") != null)
                ctObj.i = XmlHelper.ReadBool(node.Attribute("i"));
            if (node.Attribute("un") != null)
                ctObj.un = XmlHelper.ReadBool(node.Attribute("un"));
            if (node.Attribute("st") != null)
                ctObj.st = XmlHelper.ReadBool(node.Attribute("st"));
            if (node.Attribute("b") != null)
                ctObj.b = XmlHelper.ReadBool(node.Attribute("b"));
            ctObj.x = new List<CT_X>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "tpls")
                    ctObj.tpls = CT_Tuples.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "x")
                    ctObj.x.Add(CT_X.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "v", this.v);
            XmlHelper.WriteAttribute(sw, "u", this.u);
            XmlHelper.WriteAttribute(sw, "f", this.f);
            XmlHelper.WriteAttribute(sw, "c", this.c);
            XmlHelper.WriteAttribute(sw, "cp", this.cp);
            XmlHelper.WriteAttribute(sw, "in", this.@in);
            XmlHelper.WriteAttribute(sw, "bc", this.bc);
            XmlHelper.WriteAttribute(sw, "fc", this.fc);
            XmlHelper.WriteAttribute(sw, "i", this.i);
            XmlHelper.WriteAttribute(sw, "un", this.un);
            XmlHelper.WriteAttribute(sw, "st", this.st);
            XmlHelper.WriteAttribute(sw, "b", this.b);
            sw.Write(">");
            if (this.tpls != null)
                this.tpls.Write(sw, "tpls");
            if (this.x != null)
            {
                foreach (CT_X x in this.x)
                {
                    x.Write(sw, "x");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Tuples
    {

        private List<CT_Tuple> tplField;

        private uint cField;

        private bool cFieldSpecified;

        public CT_Tuples()
        {
            this.tplField = new List<CT_Tuple>();
        }

        [XmlElement("tpl", Order = 0)]
        public List<CT_Tuple> tpl
        {
            get
            {
                return this.tplField;
            }
            set
            {
                this.tplField = value;
            }
        }

        [XmlAttribute()]
        public uint c
        {
            get
            {
                return this.cField;
            }
            set
            {
                this.cField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cSpecified
        {
            get
            {
                return this.cFieldSpecified;
            }
            set
            {
                this.cFieldSpecified = value;
            }
        }

        public static CT_Tuples Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Tuples ctObj = new CT_Tuples();
            if (node.Attribute("c") != null)
                ctObj.c = XmlHelper.ReadUInt(node.Attribute("c"));
            ctObj.tpl = new List<CT_Tuple>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "tpl")
                    ctObj.tpl.Add(CT_Tuple.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "c", this.c);
            sw.Write(">");
            if (this.tpl != null)
            {
                foreach (CT_Tuple x in this.tpl)
                {
                    x.Write(sw, "tpl");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Tuple
    {

        private uint fldField;

        private bool fldFieldSpecified;

        private uint hierField;

        private bool hierFieldSpecified;

        private uint itemField;

        [XmlAttribute()]
        public uint fld
        {
            get
            {
                return this.fldField;
            }
            set
            {
                this.fldField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fldSpecified
        {
            get
            {
                return this.fldFieldSpecified;
            }
            set
            {
                this.fldFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public uint hier
        {
            get
            {
                return this.hierField;
            }
            set
            {
                this.hierField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hierSpecified
        {
            get
            {
                return this.hierFieldSpecified;
            }
            set
            {
                this.hierFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public uint item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        public static CT_Tuple Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Tuple ctObj = new CT_Tuple();
            if (node.Attribute("fld") != null)
                ctObj.fld = XmlHelper.ReadUInt(node.Attribute("fld"));
            if (node.Attribute("hier") != null)
                ctObj.hier = XmlHelper.ReadUInt(node.Attribute("hier"));
            if (node.Attribute("item") != null)
                ctObj.item = XmlHelper.ReadUInt(node.Attribute("item"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "fld", this.fld);
            XmlHelper.WriteAttribute(sw, "hier", this.hier);
            XmlHelper.WriteAttribute(sw, "item", this.item);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

    }




    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Missing
    {

        private List<CT_Tuples> tplsField;

        private List<CT_X> xField;

        private bool uField;

        private bool uFieldSpecified;

        private bool fField;

        private bool fFieldSpecified;

        private string cField;

        private uint cpField;

        private bool cpFieldSpecified;

        private uint inField;

        private bool inFieldSpecified;

        private byte[] bcField;

        private byte[] fcField;

        private bool iField;

        private bool unField;

        private bool stField;

        private bool bField;

        public CT_Missing()
        {
            this.xField = new List<CT_X>();
            this.tplsField = new List<CT_Tuples>();
            this.iField = false;
            this.unField = false;
            this.stField = false;
            this.bField = false;
        }

        [XmlElement("tpls", Order = 0)]
        public List<CT_Tuples> tpls
        {
            get
            {
                return this.tplsField;
            }
            set
            {
                this.tplsField = value;
            }
        }

        [XmlElement("x", Order = 1)]
        public List<CT_X> x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        [XmlAttribute()]
        public bool u
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uSpecified
        {
            get
            {
                return this.uFieldSpecified;
            }
            set
            {
                this.uFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public bool f
        {
            get
            {
                return this.fField;
            }
            set
            {
                this.fField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fSpecified
        {
            get
            {
                return this.fFieldSpecified;
            }
            set
            {
                this.fFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string c
        {
            get
            {
                return this.cField;
            }
            set
            {
                this.cField = value;
            }
        }

        [XmlAttribute()]
        public uint cp
        {
            get
            {
                return this.cpField;
            }
            set
            {
                this.cpField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cpSpecified
        {
            get
            {
                return this.cpFieldSpecified;
            }
            set
            {
                this.cpFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public uint @in
        {
            get
            {
                return this.inField;
            }
            set
            {
                this.inField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inSpecified
        {
            get
            {
                return this.inFieldSpecified;
            }
            set
            {
                this.inFieldSpecified = value;
            }
        }

        [XmlAttribute(DataType = "hexBinary")]
        public byte[] bc
        {
            get
            {
                return this.bcField;
            }
            set
            {
                this.bcField = value;
            }
        }

        [XmlAttribute(DataType = "hexBinary")]
        public byte[] fc
        {
            get
            {
                return this.fcField;
            }
            set
            {
                this.fcField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool i
        {
            get
            {
                return this.iField;
            }
            set
            {
                this.iField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool un
        {
            get
            {
                return this.unField;
            }
            set
            {
                this.unField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool st
        {
            get
            {
                return this.stField;
            }
            set
            {
                this.stField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool b
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }

        public static CT_Missing Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Missing ctObj = new CT_Missing();
            if (node.Attribute("u") != null)
                ctObj.u = XmlHelper.ReadBool(node.Attribute("u"));
            if (node.Attribute("f") != null)
                ctObj.f = XmlHelper.ReadBool(node.Attribute("f"));
            ctObj.c = XmlHelper.ReadString(node.Attribute("c"));
            if (node.Attribute("cp") != null)
                ctObj.cp = XmlHelper.ReadUInt(node.Attribute("cp"));
            if (node.Attribute("in") != null)
                ctObj.@in = XmlHelper.ReadUInt(node.Attribute("in"));
            ctObj.bc = XmlHelper.ReadBytes(node.Attribute("bc"));
            ctObj.fc = XmlHelper.ReadBytes(node.Attribute("fc"));
            if (node.Attribute("i") != null)
                ctObj.i = XmlHelper.ReadBool(node.Attribute("i"));
            if (node.Attribute("un") != null)
                ctObj.un = XmlHelper.ReadBool(node.Attribute("un"));
            if (node.Attribute("st") != null)
                ctObj.st = XmlHelper.ReadBool(node.Attribute("st"));
            if (node.Attribute("b") != null)
                ctObj.b = XmlHelper.ReadBool(node.Attribute("b"));
            ctObj.tpls = new List<CT_Tuples>();
            ctObj.x = new List<CT_X>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "tpls")
                    ctObj.tpls.Add(CT_Tuples.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "x")
                    ctObj.x.Add(CT_X.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "u", this.u);
            XmlHelper.WriteAttribute(sw, "f", this.f);
            XmlHelper.WriteAttribute(sw, "c", this.c);
            XmlHelper.WriteAttribute(sw, "cp", this.cp);
            XmlHelper.WriteAttribute(sw, "in", this.@in);
            XmlHelper.WriteAttribute(sw, "bc", this.bc);
            XmlHelper.WriteAttribute(sw, "fc", this.fc);
            XmlHelper.WriteAttribute(sw, "i", this.i);
            XmlHelper.WriteAttribute(sw, "un", this.un);
            XmlHelper.WriteAttribute(sw, "st", this.st);
            XmlHelper.WriteAttribute(sw, "b", this.b);
            sw.Write(">");
            if (this.tpls != null)
            {
                foreach (CT_Tuples x in this.tpls)
                {
                    x.Write(sw, "tpls");
                }
            }
            if (this.x != null)
            {
                foreach (CT_X x in this.x)
                {
                    x.Write(sw, "x");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Number
    {

        private List<CT_Tuples> tplsField;

        private List<CT_X> xField;

        private double vField;

        private bool uField;

        private bool uFieldSpecified;

        private bool fField;

        private bool fFieldSpecified;

        private string cField;

        private uint cpField;

        private bool cpFieldSpecified;

        private uint inField;

        private bool inFieldSpecified;

        private byte[] bcField;

        private byte[] fcField;

        private bool iField;

        private bool unField;

        private bool stField;

        private bool bField;

        public CT_Number()
        {
            this.xField = new List<CT_X>();
            this.tplsField = new List<CT_Tuples>();
            this.iField = false;
            this.unField = false;
            this.stField = false;
            this.bField = false;
        }

        [XmlElement("tpls", Order = 0)]
        public List<CT_Tuples> tpls
        {
            get
            {
                return this.tplsField;
            }
            set
            {
                this.tplsField = value;
            }
        }

        [XmlElement("x", Order = 1)]
        public List<CT_X> x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        [XmlAttribute()]
        public double v
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }

        [XmlAttribute()]
        public bool u
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uSpecified
        {
            get
            {
                return this.uFieldSpecified;
            }
            set
            {
                this.uFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public bool f
        {
            get
            {
                return this.fField;
            }
            set
            {
                this.fField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fSpecified
        {
            get
            {
                return this.fFieldSpecified;
            }
            set
            {
                this.fFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string c
        {
            get
            {
                return this.cField;
            }
            set
            {
                this.cField = value;
            }
        }

        [XmlAttribute()]
        public uint cp
        {
            get
            {
                return this.cpField;
            }
            set
            {
                this.cpField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cpSpecified
        {
            get
            {
                return this.cpFieldSpecified;
            }
            set
            {
                this.cpFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public uint @in
        {
            get
            {
                return this.inField;
            }
            set
            {
                this.inField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inSpecified
        {
            get
            {
                return this.inFieldSpecified;
            }
            set
            {
                this.inFieldSpecified = value;
            }
        }

        [XmlAttribute(DataType = "hexBinary")]
        public byte[] bc
        {
            get
            {
                return this.bcField;
            }
            set
            {
                this.bcField = value;
            }
        }

        [XmlAttribute(DataType = "hexBinary")]
        public byte[] fc
        {
            get
            {
                return this.fcField;
            }
            set
            {
                this.fcField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool i
        {
            get
            {
                return this.iField;
            }
            set
            {
                this.iField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool un
        {
            get
            {
                return this.unField;
            }
            set
            {
                this.unField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool st
        {
            get
            {
                return this.stField;
            }
            set
            {
                this.stField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool b
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }

        public static CT_Number Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Number ctObj = new CT_Number();
            if (node.Attribute("v") != null)
                ctObj.v = XmlHelper.ReadDouble(node.Attribute("v"));
            if (node.Attribute("u") != null)
                ctObj.u = XmlHelper.ReadBool(node.Attribute("u"));
            if (node.Attribute("f") != null)
                ctObj.f = XmlHelper.ReadBool(node.Attribute("f"));
            ctObj.c = XmlHelper.ReadString(node.Attribute("c"));
            if (node.Attribute("cp") != null)
                ctObj.cp = XmlHelper.ReadUInt(node.Attribute("cp"));
            if (node.Attribute("in") != null)
                ctObj.@in = XmlHelper.ReadUInt(node.Attribute("in"));
            ctObj.bc = XmlHelper.ReadBytes(node.Attribute("bc"));
            ctObj.fc = XmlHelper.ReadBytes(node.Attribute("fc"));
            if (node.Attribute("i") != null)
                ctObj.i = XmlHelper.ReadBool(node.Attribute("i"));
            if (node.Attribute("un") != null)
                ctObj.un = XmlHelper.ReadBool(node.Attribute("un"));
            if (node.Attribute("st") != null)
                ctObj.st = XmlHelper.ReadBool(node.Attribute("st"));
            if (node.Attribute("b") != null)
                ctObj.b = XmlHelper.ReadBool(node.Attribute("b"));
            ctObj.tpls = new List<CT_Tuples>();
            ctObj.x = new List<CT_X>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "tpls")
                    ctObj.tpls.Add(CT_Tuples.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "x")
                    ctObj.x.Add(CT_X.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "v", this.v);
            XmlHelper.WriteAttribute(sw, "u", this.u);
            XmlHelper.WriteAttribute(sw, "f", this.f);
            XmlHelper.WriteAttribute(sw, "c", this.c);
            XmlHelper.WriteAttribute(sw, "cp", this.cp);
            XmlHelper.WriteAttribute(sw, "in", this.@in);
            XmlHelper.WriteAttribute(sw, "bc", this.bc);
            XmlHelper.WriteAttribute(sw, "fc", this.fc);
            XmlHelper.WriteAttribute(sw, "i", this.i);
            XmlHelper.WriteAttribute(sw, "un", this.un);
            XmlHelper.WriteAttribute(sw, "st", this.st);
            XmlHelper.WriteAttribute(sw, "b", this.b);
            sw.Write(">");
            if (this.tpls != null)
            {
                foreach (CT_Tuples x in this.tpls)
                {
                    x.Write(sw, "tpls");
                }
            }
            if (this.x != null)
            {
                foreach (CT_X x in this.x)
                {
                    x.Write(sw, "x");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_String
    {

        private List<CT_Tuples> tplsField;

        private List<CT_X> xField;

        private string vField;

        private bool uField;

        private bool uFieldSpecified;

        private bool fField;

        private bool fFieldSpecified;

        private string cField;

        private uint cpField;

        private bool cpFieldSpecified;

        private uint inField;

        private bool inFieldSpecified;

        private byte[] bcField;

        private byte[] fcField;

        private bool iField;

        private bool unField;

        private bool stField;

        private bool bField;

        public CT_String()
        {
            this.xField = new List<CT_X>();
            this.tplsField = new List<CT_Tuples>();
            this.iField = false;
            this.unField = false;
            this.stField = false;
            this.bField = false;
        }

        [XmlElement("tpls", Order = 0)]
        public List<CT_Tuples> tpls
        {
            get
            {
                return this.tplsField;
            }
            set
            {
                this.tplsField = value;
            }
        }

        [XmlElement("x", Order = 1)]
        public List<CT_X> x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        [XmlAttribute()]
        public string v
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }

        [XmlAttribute()]
        public bool u
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool uSpecified
        {
            get
            {
                return this.uFieldSpecified;
            }
            set
            {
                this.uFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public bool f
        {
            get
            {
                return this.fField;
            }
            set
            {
                this.fField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fSpecified
        {
            get
            {
                return this.fFieldSpecified;
            }
            set
            {
                this.fFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string c
        {
            get
            {
                return this.cField;
            }
            set
            {
                this.cField = value;
            }
        }

        [XmlAttribute()]
        public uint cp
        {
            get
            {
                return this.cpField;
            }
            set
            {
                this.cpField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cpSpecified
        {
            get
            {
                return this.cpFieldSpecified;
            }
            set
            {
                this.cpFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public uint @in
        {
            get
            {
                return this.inField;
            }
            set
            {
                this.inField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inSpecified
        {
            get
            {
                return this.inFieldSpecified;
            }
            set
            {
                this.inFieldSpecified = value;
            }
        }

        [XmlAttribute(DataType = "hexBinary")]
        public byte[] bc
        {
            get
            {
                return this.bcField;
            }
            set
            {
                this.bcField = value;
            }
        }

        [XmlAttribute(DataType = "hexBinary")]
        public byte[] fc
        {
            get
            {
                return this.fcField;
            }
            set
            {
                this.fcField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool i
        {
            get
            {
                return this.iField;
            }
            set
            {
                this.iField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool un
        {
            get
            {
                return this.unField;
            }
            set
            {
                this.unField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool st
        {
            get
            {
                return this.stField;
            }
            set
            {
                this.stField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool b
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }

        public static CT_String Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_String ctObj = new CT_String();
            ctObj.v = XmlHelper.ReadString(node.Attribute("v"));
            if (node.Attribute("u") != null)
                ctObj.u = XmlHelper.ReadBool(node.Attribute("u"));
            if (node.Attribute("f") != null)
                ctObj.f = XmlHelper.ReadBool(node.Attribute("f"));
            ctObj.c = XmlHelper.ReadString(node.Attribute("c"));
            if (node.Attribute("cp") != null)
                ctObj.cp = XmlHelper.ReadUInt(node.Attribute("cp"));
            if (node.Attribute("in") != null)
                ctObj.@in = XmlHelper.ReadUInt(node.Attribute("in"));
            ctObj.bc = XmlHelper.ReadBytes(node.Attribute("bc"));
            ctObj.fc = XmlHelper.ReadBytes(node.Attribute("fc"));
            if (node.Attribute("i") != null)
                ctObj.i = XmlHelper.ReadBool(node.Attribute("i"));
            if (node.Attribute("un") != null)
                ctObj.un = XmlHelper.ReadBool(node.Attribute("un"));
            if (node.Attribute("st") != null)
                ctObj.st = XmlHelper.ReadBool(node.Attribute("st"));
            if (node.Attribute("b") != null)
                ctObj.b = XmlHelper.ReadBool(node.Attribute("b"));
            ctObj.tpls = new List<CT_Tuples>();
            ctObj.x = new List<CT_X>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "tpls")
                    ctObj.tpls.Add(CT_Tuples.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "x")
                    ctObj.x.Add(CT_X.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "v", this.v);
            XmlHelper.WriteAttribute(sw, "u", this.u);
            XmlHelper.WriteAttribute(sw, "f", this.f);
            XmlHelper.WriteAttribute(sw, "c", this.c);
            XmlHelper.WriteAttribute(sw, "cp", this.cp);
            XmlHelper.WriteAttribute(sw, "in", this.@in);
            XmlHelper.WriteAttribute(sw, "bc", this.bc);
            XmlHelper.WriteAttribute(sw, "fc", this.fc);
            XmlHelper.WriteAttribute(sw, "i", this.i);
            XmlHelper.WriteAttribute(sw, "un", this.un);
            XmlHelper.WriteAttribute(sw, "st", this.st);
            XmlHelper.WriteAttribute(sw, "b", this.b);
            sw.Write(">");
            if (this.tpls != null)
            {
                foreach (CT_Tuples x in this.tpls)
                {
                    x.Write(sw, "tpls");
                }
            }
            if (this.x != null)
            {
                foreach (CT_X x in this.x)
                {
                    x.Write(sw, "x");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_FieldGroup
    {
        public static CT_FieldGroup Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_FieldGroup ctObj = new CT_FieldGroup();
            if (node.Attribute("par") != null)
                ctObj.par = XmlHelper.ReadUInt(node.Attribute("par"));
            if (node.Attribute("base") != null)
                ctObj.@base = XmlHelper.ReadUInt(node.Attribute("base"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "rangePr")
                    ctObj.rangePr = CT_RangePr.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "discretePr")
                    ctObj.discretePr = CT_DiscretePr.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "groupItems")
                    ctObj.groupItems = CT_GroupItems.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "par", this.par);
            XmlHelper.WriteAttribute(sw, "base", this.@base);
            sw.Write(">");
            if (this.rangePr != null)
                this.rangePr.Write(sw, "rangePr");
            if (this.discretePr != null)
                this.discretePr.Write(sw, "discretePr");
            if (this.groupItems != null)
                this.groupItems.Write(sw, "groupItems");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_RangePr rangePrField;

        private CT_DiscretePr discretePrField;

        private CT_GroupItems groupItemsField;

        private uint parField;

        private bool parFieldSpecified;

        private uint baseField;

        private bool baseFieldSpecified;

        public CT_FieldGroup()
        {
            this.groupItemsField = new CT_GroupItems();
            this.discretePrField = new CT_DiscretePr();
            this.rangePrField = new CT_RangePr();
        }

        [XmlElement(Order = 0)]
        public CT_RangePr rangePr
        {
            get
            {
                return this.rangePrField;
            }
            set
            {
                this.rangePrField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_DiscretePr discretePr
        {
            get
            {
                return this.discretePrField;
            }
            set
            {
                this.discretePrField = value;
            }
        }

        [XmlElement(Order = 2)]
        public CT_GroupItems groupItems
        {
            get
            {
                return this.groupItemsField;
            }
            set
            {
                this.groupItemsField = value;
            }
        }

        [XmlAttribute()]
        public uint par
        {
            get
            {
                return this.parField;
            }
            set
            {
                this.parField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parSpecified
        {
            get
            {
                return this.parFieldSpecified;
            }
            set
            {
                this.parFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public uint @base
        {
            get
            {
                return this.baseField;
            }
            set
            {
                this.baseField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool baseSpecified
        {
            get
            {
                return this.baseFieldSpecified;
            }
            set
            {
                this.baseFieldSpecified = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_RangePr
    {
        public static CT_RangePr Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_RangePr ctObj = new CT_RangePr();
            if (node.Attribute("autoStart") != null)
                ctObj.autoStart = XmlHelper.ReadBool(node.Attribute("autoStart"));
            if (node.Attribute("autoEnd") != null)
                ctObj.autoEnd = XmlHelper.ReadBool(node.Attribute("autoEnd"));
            if (node.Attribute("groupBy") != null)
                ctObj.groupBy = (ST_GroupBy)Enum.Parse(typeof(ST_GroupBy), node.Attribute("groupBy").Value);
            if (node.Attribute("startNum") != null)
                ctObj.startNum = XmlHelper.ReadDouble(node.Attribute("startNum"));
            if (node.Attribute("endNum") != null)
                ctObj.endNum = XmlHelper.ReadDouble(node.Attribute("endNum"));
            if (node.Attribute("startDate") != null)
                ctObj.startDate = XmlHelper.ReadDateTime(node.Attribute("startDate"));
            if (node.Attribute("endDate") != null)
                ctObj.endDate = XmlHelper.ReadDateTime(node.Attribute("endDate"));
            if (node.Attribute("groupInterval") != null)
                ctObj.groupInterval = XmlHelper.ReadDouble(node.Attribute("groupInterval"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "autoStart", this.autoStart);
            XmlHelper.WriteAttribute(sw, "autoEnd", this.autoEnd);
            XmlHelper.WriteAttribute(sw, "groupBy", this.groupBy.ToString());
            XmlHelper.WriteAttribute(sw, "startNum", this.startNum);
            XmlHelper.WriteAttribute(sw, "endNum", this.endNum);
            XmlHelper.WriteAttribute(sw, "startDate", this.startDate);
            XmlHelper.WriteAttribute(sw, "endDate", this.endDate);
            XmlHelper.WriteAttribute(sw, "groupInterval", this.groupInterval);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private bool autoStartField;

        private bool autoEndField;

        private ST_GroupBy groupByField;

        private double startNumField;

        private bool startNumFieldSpecified;

        private double endNumField;

        private bool endNumFieldSpecified;

        private System.DateTime? startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime? endDateField;

        private bool endDateFieldSpecified;

        private double groupIntervalField;

        public CT_RangePr()
        {
            this.autoStartField = true;
            this.autoEndField = true;
            this.groupByField = ST_GroupBy.range;
            this.groupIntervalField = 1D;
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool autoStart
        {
            get
            {
                return this.autoStartField;
            }
            set
            {
                this.autoStartField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool autoEnd
        {
            get
            {
                return this.autoEndField;
            }
            set
            {
                this.autoEndField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ST_GroupBy.range)]
        public ST_GroupBy groupBy
        {
            get
            {
                return this.groupByField;
            }
            set
            {
                this.groupByField = value;
            }
        }

        [XmlAttribute()]
        public double startNum
        {
            get
            {
                return this.startNumField;
            }
            set
            {
                this.startNumField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startNumSpecified
        {
            get
            {
                return this.startNumFieldSpecified;
            }
            set
            {
                this.startNumFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public double endNum
        {
            get
            {
                return this.endNumField;
            }
            set
            {
                this.endNumField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endNumSpecified
        {
            get
            {
                return this.endNumFieldSpecified;
            }
            set
            {
                this.endNumFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public System.DateTime? startDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateSpecified
        {
            get
            {
                return this.startDateFieldSpecified;
            }
            set
            {
                this.startDateFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public System.DateTime? endDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDateSpecified
        {
            get
            {
                return this.endDateFieldSpecified;
            }
            set
            {
                this.endDateFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(1D)]
        public double groupInterval
        {
            get
            {
                return this.groupIntervalField;
            }
            set
            {
                this.groupIntervalField = value;
            }
        }
    }

    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
    public enum ST_GroupBy
    {

        /// <remarks/>
        range,

        /// <remarks/>
        seconds,

        /// <remarks/>
        minutes,

        /// <remarks/>
        hours,

        /// <remarks/>
        days,

        /// <remarks/>
        months,

        /// <remarks/>
        quarters,

        /// <remarks/>
        years,
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_DiscretePr
    {
        public static CT_DiscretePr Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_DiscretePr ctObj = new CT_DiscretePr();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.x = new List<CT_Index>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "x")
                    ctObj.x.Add(CT_Index.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.x != null)
            {
                foreach (CT_Index x in this.x)
                {
                    x.Write(sw, "x");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_Index> xField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_DiscretePr()
        {
            this.xField = new List<CT_Index>();
        }

        [XmlElement("x", Order = 0)]
        public List<CT_Index> x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_GroupItems
    {
        public static CT_GroupItems Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_GroupItems ctObj = new CT_GroupItems();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "e")
                {
                    ctObj.Items.Add(CT_Error.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.e);
                }
                else if (childNode.Name.LocalName == "b")
                {
                    ctObj.Items.Add(CT_Boolean.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.b);
                }
                else if (childNode.Name.LocalName == "d")
                {
                    ctObj.Items.Add(CT_DateTime.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.d);
                }
                else if (childNode.Name.LocalName == "n")
                {
                    ctObj.Items.Add(CT_Number.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.n);
                }
                else if (childNode.Name.LocalName == "m")
                {
                    ctObj.Items.Add(CT_Missing.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.m);
                }
                else if (childNode.Name.LocalName == "s")
                {
                    ctObj.Items.Add(CT_String.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.s);
                }
            }
            return ctObj;
        }

        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            sw.Write(">");
            foreach (object o in this.Items)
            {
                if (o is CT_Error)
                    ((CT_Error)o).Write(sw, "e");
                else if (o is CT_Boolean)
                    ((CT_Boolean)o).Write(sw, "b");
                else if (o is CT_DateTime)
                    ((CT_DateTime)o).Write(sw, "d");
                else if (o is CT_Number)
                    ((CT_Number)o).Write(sw, "n");
                else if (o is CT_Missing)
                    ((CT_Missing)o).Write(sw, "m");
                else if (o is CT_String)
                    ((CT_String)o).Write(sw, "s");
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<object> itemsField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_GroupItems()
        {
            this.itemsField = new List<object>();
        }

        [XmlElement("b", typeof(CT_Boolean), Order = 0)]
        [XmlElement("d", typeof(CT_DateTime), Order = 0)]
        [XmlElement("e", typeof(CT_Error), Order = 0)]
        [XmlElement("m", typeof(CT_Missing), Order = 0)]
        [XmlElement("n", typeof(CT_Number), Order = 0)]
        [XmlElement("s", typeof(CT_String), Order = 0)]
        public List<object> Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_FieldsUsage
    {
        public static CT_FieldsUsage Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_FieldsUsage ctObj = new CT_FieldsUsage();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.fieldUsage = new List<CT_FieldUsage>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "fieldUsage")
                    ctObj.fieldUsage.Add(CT_FieldUsage.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.fieldUsage != null)
            {
                foreach (CT_FieldUsage x in this.fieldUsage)
                {
                    x.Write(sw, "fieldUsage");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_FieldUsage> fieldUsageField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_FieldsUsage()
        {
            this.fieldUsageField = new List<CT_FieldUsage>();
        }

        [XmlElement("fieldUsage", Order = 0)]
        public List<CT_FieldUsage> fieldUsage
        {
            get
            {
                return this.fieldUsageField;
            }
            set
            {
                this.fieldUsageField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_FieldUsage
    {
        public static CT_FieldUsage Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_FieldUsage ctObj = new CT_FieldUsage();
            if (node.Attribute("x") != null)
                ctObj.x = XmlHelper.ReadInt(node.Attribute("x"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "x", this.x);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private int xField;

        [XmlAttribute()]
        public int x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_GroupLevels
    {
        public static CT_GroupLevels Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_GroupLevels ctObj = new CT_GroupLevels();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.groupLevel = new List<CT_GroupLevel>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "groupLevel")
                    ctObj.groupLevel.Add(CT_GroupLevel.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.groupLevel != null)
            {
                foreach (CT_GroupLevel x in this.groupLevel)
                {
                    x.Write(sw, "groupLevel");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_GroupLevel> groupLevelField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_GroupLevels()
        {
            this.groupLevelField = new List<CT_GroupLevel>();
        }

        [XmlElement("groupLevel", Order = 0)]
        public List<CT_GroupLevel> groupLevel
        {
            get
            {
                return this.groupLevelField;
            }
            set
            {
                this.groupLevelField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_GroupLevel
    {
        public static CT_GroupLevel Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_GroupLevel ctObj = new CT_GroupLevel();
            ctObj.uniqueName = XmlHelper.ReadString(node.Attribute("uniqueName"));
            ctObj.caption = XmlHelper.ReadString(node.Attribute("caption"));
            if (node.Attribute("user") != null)
                ctObj.user = XmlHelper.ReadBool(node.Attribute("user"));
            if (node.Attribute("customRollUp") != null)
                ctObj.customRollUp = XmlHelper.ReadBool(node.Attribute("customRollUp"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "groups")
                    ctObj.groups = CT_Groups.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "uniqueName", this.uniqueName);
            XmlHelper.WriteAttribute(sw, "caption", this.caption);
            XmlHelper.WriteAttribute(sw, "user", this.user);
            XmlHelper.WriteAttribute(sw, "customRollUp", this.customRollUp);
            sw.Write(">");
            if (this.groups != null)
                this.groups.Write(sw, "groups");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_Groups groupsField;

        private CT_ExtensionList extLstField;

        private string uniqueNameField;

        private string captionField;

        private bool userField;

        private bool customRollUpField;

        public CT_GroupLevel()
        {
            this.extLstField = new CT_ExtensionList();
            this.groupsField = new CT_Groups();
            this.userField = false;
            this.customRollUpField = false;
        }

        [XmlElement(Order = 0)]
        public CT_Groups groups
        {
            get
            {
                return this.groupsField;
            }
            set
            {
                this.groupsField = value;
            }
        }

        [XmlElement(Order = 1)]
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

        [XmlAttribute()]
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

        [XmlAttribute()]
        public string caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool user
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool customRollUp
        {
            get
            {
                return this.customRollUpField;
            }
            set
            {
                this.customRollUpField = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Groups
    {
        public static CT_Groups Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Groups ctObj = new CT_Groups();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.group = new List<CT_LevelGroup>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "group")
                    ctObj.group.Add(CT_LevelGroup.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.group != null)
            {
                foreach (CT_LevelGroup x in this.group)
                {
                    x.Write(sw, "group");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_LevelGroup> groupField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_Groups()
        {
            this.groupField = new List<CT_LevelGroup>();
        }

        [XmlElement("group", Order = 0)]
        public List<CT_LevelGroup> group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_LevelGroup
    {
        public static CT_LevelGroup Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_LevelGroup ctObj = new CT_LevelGroup();
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            ctObj.uniqueName = XmlHelper.ReadString(node.Attribute("uniqueName"));
            ctObj.caption = XmlHelper.ReadString(node.Attribute("caption"));
            ctObj.uniqueParent = XmlHelper.ReadString(node.Attribute("uniqueParent"));
            if (node.Attribute("id") != null)
                ctObj.id = XmlHelper.ReadInt(node.Attribute("id"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "groupMembers")
                    ctObj.groupMembers = CT_GroupMembers.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "uniqueName", this.uniqueName);
            XmlHelper.WriteAttribute(sw, "caption", this.caption);
            XmlHelper.WriteAttribute(sw, "uniqueParent", this.uniqueParent);
            XmlHelper.WriteAttribute(sw, "id", this.id);
            sw.Write(">");
            if (this.groupMembers != null)
                this.groupMembers.Write(sw, "groupMembers");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_GroupMembers groupMembersField;

        private string nameField;

        private string uniqueNameField;

        private string captionField;

        private string uniqueParentField;

        private int idField;

        private bool idFieldSpecified;

        public CT_LevelGroup()
        {
            this.groupMembersField = new CT_GroupMembers();
        }

        [XmlElement(Order = 0)]
        public CT_GroupMembers groupMembers
        {
            get
            {
                return this.groupMembersField;
            }
            set
            {
                this.groupMembersField = value;
            }
        }

        [XmlAttribute()]
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

        [XmlAttribute()]
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

        [XmlAttribute()]
        public string caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }

        [XmlAttribute()]
        public string uniqueParent
        {
            get
            {
                return this.uniqueParentField;
            }
            set
            {
                this.uniqueParentField = value;
            }
        }

        [XmlAttribute()]
        public int id
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_GroupMembers
    {
        public static CT_GroupMembers Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_GroupMembers ctObj = new CT_GroupMembers();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.groupMember = new List<CT_GroupMember>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "groupMember")
                    ctObj.groupMember.Add(CT_GroupMember.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.groupMember != null)
            {
                foreach (CT_GroupMember x in this.groupMember)
                {
                    x.Write(sw, "groupMember");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_GroupMember> groupMemberField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_GroupMembers()
        {
            this.groupMemberField = new List<CT_GroupMember>();
        }

        [XmlElement("groupMember", Order = 0)]
        public List<CT_GroupMember> groupMember
        {
            get
            {
                return this.groupMemberField;
            }
            set
            {
                this.groupMemberField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_GroupMember
    {
        public static CT_GroupMember Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_GroupMember ctObj = new CT_GroupMember();
            ctObj.uniqueName = XmlHelper.ReadString(node.Attribute("uniqueName"));
            if (node.Attribute("group") != null)
                ctObj.group = XmlHelper.ReadBool(node.Attribute("group"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "uniqueName", this.uniqueName);
            XmlHelper.WriteAttribute(sw, "group", this.group);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private string uniqueNameField;

        private bool groupField;

        public CT_GroupMember()
        {
            this.groupField = false;
        }

        [XmlAttribute()]
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

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }
    }
    
    
    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_CacheHierarchy
    {
        public static CT_CacheHierarchy Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_CacheHierarchy ctObj = new CT_CacheHierarchy();
            ctObj.uniqueName = XmlHelper.ReadString(node.Attribute("uniqueName"));
            ctObj.caption = XmlHelper.ReadString(node.Attribute("caption"));
            if (node.Attribute("measure") != null)
                ctObj.measure = XmlHelper.ReadBool(node.Attribute("measure"));
            if (node.Attribute("set") != null)
                ctObj.set = XmlHelper.ReadBool(node.Attribute("set"));
            if (node.Attribute("parentSet") != null)
                ctObj.parentSet = XmlHelper.ReadUInt(node.Attribute("parentSet"));
            if (node.Attribute("iconSet") != null)
                ctObj.iconSet = XmlHelper.ReadInt(node.Attribute("iconSet"));
            if (node.Attribute("attribute") != null)
                ctObj.attribute = XmlHelper.ReadBool(node.Attribute("attribute"));
            if (node.Attribute("time") != null)
                ctObj.time = XmlHelper.ReadBool(node.Attribute("time"));
            if (node.Attribute("keyAttribute") != null)
                ctObj.keyAttribute = XmlHelper.ReadBool(node.Attribute("keyAttribute"));
            ctObj.defaultMemberUniqueName = XmlHelper.ReadString(node.Attribute("defaultMemberUniqueName"));
            ctObj.allUniqueName = XmlHelper.ReadString(node.Attribute("allUniqueName"));
            ctObj.allCaption = XmlHelper.ReadString(node.Attribute("allCaption"));
            ctObj.dimensionUniqueName = XmlHelper.ReadString(node.Attribute("dimensionUniqueName"));
            ctObj.displayFolder = XmlHelper.ReadString(node.Attribute("displayFolder"));
            ctObj.measureGroup = XmlHelper.ReadString(node.Attribute("measureGroup"));
            if (node.Attribute("measures") != null)
                ctObj.measures = XmlHelper.ReadBool(node.Attribute("measures"));
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            if (node.Attribute("oneField") != null)
                ctObj.oneField = XmlHelper.ReadBool(node.Attribute("oneField"));
            if (node.Attribute("memberValueDatatype") != null)
                ctObj.memberValueDatatype = XmlHelper.ReadUShort(node.Attribute("memberValueDatatype"));
            if (node.Attribute("unbalanced") != null)
                ctObj.unbalanced = XmlHelper.ReadBool(node.Attribute("unbalanced"));
            if (node.Attribute("unbalancedGroup") != null)
                ctObj.unbalancedGroup = XmlHelper.ReadBool(node.Attribute("unbalancedGroup"));
            if (node.Attribute("hidden") != null)
                ctObj.hidden = XmlHelper.ReadBool(node.Attribute("hidden"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "fieldsUsage")
                    ctObj.fieldsUsage = CT_FieldsUsage.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "groupLevels")
                    ctObj.groupLevels = CT_GroupLevels.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "uniqueName", this.uniqueName);
            XmlHelper.WriteAttribute(sw, "caption", this.caption);
            XmlHelper.WriteAttribute(sw, "measure", this.measure);
            XmlHelper.WriteAttribute(sw, "set", this.set);
            XmlHelper.WriteAttribute(sw, "parentSet", this.parentSet);
            XmlHelper.WriteAttribute(sw, "iconSet", this.iconSet);
            XmlHelper.WriteAttribute(sw, "attribute", this.attribute);
            XmlHelper.WriteAttribute(sw, "time", this.time);
            XmlHelper.WriteAttribute(sw, "keyAttribute", this.keyAttribute);
            XmlHelper.WriteAttribute(sw, "defaultMemberUniqueName", this.defaultMemberUniqueName);
            XmlHelper.WriteAttribute(sw, "allUniqueName", this.allUniqueName);
            XmlHelper.WriteAttribute(sw, "allCaption", this.allCaption);
            XmlHelper.WriteAttribute(sw, "dimensionUniqueName", this.dimensionUniqueName);
            XmlHelper.WriteAttribute(sw, "displayFolder", this.displayFolder);
            XmlHelper.WriteAttribute(sw, "measureGroup", this.measureGroup);
            XmlHelper.WriteAttribute(sw, "measures", this.measures);
            XmlHelper.WriteAttribute(sw, "count", this.count);
            XmlHelper.WriteAttribute(sw, "oneField", this.oneField);
            XmlHelper.WriteAttribute(sw, "memberValueDatatype", this.memberValueDatatype);
            XmlHelper.WriteAttribute(sw, "unbalanced", this.unbalanced);
            XmlHelper.WriteAttribute(sw, "unbalancedGroup", this.unbalancedGroup);
            XmlHelper.WriteAttribute(sw, "hidden", this.hidden);
            sw.Write(">");
            if (this.fieldsUsage != null)
                this.fieldsUsage.Write(sw, "fieldsUsage");
            if (this.groupLevels != null)
                this.groupLevels.Write(sw, "groupLevels");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_FieldsUsage fieldsUsageField;

        private CT_GroupLevels groupLevelsField;

        private CT_ExtensionList extLstField;

        private string uniqueNameField;

        private string captionField;

        private bool measureField;

        private bool setField;

        private uint parentSetField;

        private bool parentSetFieldSpecified;

        private int iconSetField;

        private bool attributeField;

        private bool timeField;

        private bool keyAttributeField;

        private string defaultMemberUniqueNameField;

        private string allUniqueNameField;

        private string allCaptionField;

        private string dimensionUniqueNameField;

        private string displayFolderField;

        private string measureGroupField;

        private bool measuresField;

        private uint countField;

        private bool oneFieldField;

        private ushort memberValueDatatypeField;

        private bool memberValueDatatypeFieldSpecified;

        private bool unbalancedField;

        private bool unbalancedFieldSpecified;

        private bool unbalancedGroupField;

        private bool unbalancedGroupFieldSpecified;

        private bool hiddenField;

        public CT_CacheHierarchy()
        {
            this.extLstField = new CT_ExtensionList();
            this.groupLevelsField = new CT_GroupLevels();
            this.fieldsUsageField = new CT_FieldsUsage();
            this.measureField = false;
            this.setField = false;
            this.iconSetField = 0;
            this.attributeField = false;
            this.timeField = false;
            this.keyAttributeField = false;
            this.measuresField = false;
            this.oneFieldField = false;
            this.hiddenField = false;
        }

        [XmlElement(Order = 0)]
        public CT_FieldsUsage fieldsUsage
        {
            get
            {
                return this.fieldsUsageField;
            }
            set
            {
                this.fieldsUsageField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_GroupLevels groupLevels
        {
            get
            {
                return this.groupLevelsField;
            }
            set
            {
                this.groupLevelsField = value;
            }
        }

        [XmlElement(Order = 2)]
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

        [XmlAttribute()]
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

        [XmlAttribute()]
        public string caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool set
        {
            get
            {
                return this.setField;
            }
            set
            {
                this.setField = value;
            }
        }

        [XmlAttribute()]
        public uint parentSet
        {
            get
            {
                return this.parentSetField;
            }
            set
            {
                this.parentSetField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parentSetSpecified
        {
            get
            {
                return this.parentSetFieldSpecified;
            }
            set
            {
                this.parentSetFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int iconSet
        {
            get
            {
                return this.iconSetField;
            }
            set
            {
                this.iconSetField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool keyAttribute
        {
            get
            {
                return this.keyAttributeField;
            }
            set
            {
                this.keyAttributeField = value;
            }
        }

        [XmlAttribute()]
        public string defaultMemberUniqueName
        {
            get
            {
                return this.defaultMemberUniqueNameField;
            }
            set
            {
                this.defaultMemberUniqueNameField = value;
            }
        }

        [XmlAttribute()]
        public string allUniqueName
        {
            get
            {
                return this.allUniqueNameField;
            }
            set
            {
                this.allUniqueNameField = value;
            }
        }

        [XmlAttribute()]
        public string allCaption
        {
            get
            {
                return this.allCaptionField;
            }
            set
            {
                this.allCaptionField = value;
            }
        }

        [XmlAttribute()]
        public string dimensionUniqueName
        {
            get
            {
                return this.dimensionUniqueNameField;
            }
            set
            {
                this.dimensionUniqueNameField = value;
            }
        }

        [XmlAttribute()]
        public string displayFolder
        {
            get
            {
                return this.displayFolderField;
            }
            set
            {
                this.displayFolderField = value;
            }
        }

        [XmlAttribute()]
        public string measureGroup
        {
            get
            {
                return this.measureGroupField;
            }
            set
            {
                this.measureGroupField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool measures
        {
            get
            {
                return this.measuresField;
            }
            set
            {
                this.measuresField = value;
            }
        }

        [XmlAttribute()]
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

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool oneField
        {
            get
            {
                return this.oneFieldField;
            }
            set
            {
                this.oneFieldField = value;
            }
        }

        [XmlAttribute()]
        public ushort memberValueDatatype
        {
            get
            {
                return this.memberValueDatatypeField;
            }
            set
            {
                this.memberValueDatatypeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool memberValueDatatypeSpecified
        {
            get
            {
                return this.memberValueDatatypeFieldSpecified;
            }
            set
            {
                this.memberValueDatatypeFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public bool unbalanced
        {
            get
            {
                return this.unbalancedField;
            }
            set
            {
                this.unbalancedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unbalancedSpecified
        {
            get
            {
                return this.unbalancedFieldSpecified;
            }
            set
            {
                this.unbalancedFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public bool unbalancedGroup
        {
            get
            {
                return this.unbalancedGroupField;
            }
            set
            {
                this.unbalancedGroupField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unbalancedGroupSpecified
        {
            get
            {
                return this.unbalancedGroupFieldSpecified;
            }
            set
            {
                this.unbalancedGroupFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
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
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_PCDKPIs
    {
        public static CT_PCDKPIs Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PCDKPIs ctObj = new CT_PCDKPIs();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.kpi = new List<CT_PCDKPI>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "kpi")
                    ctObj.kpi.Add(CT_PCDKPI.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.kpi != null)
            {
                foreach (CT_PCDKPI x in this.kpi)
                {
                    x.Write(sw, "kpi");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_PCDKPI> kpiField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_PCDKPIs()
        {
            this.kpiField = new List<CT_PCDKPI>();
        }

        [XmlElement("kpi", Order = 0)]
        public List<CT_PCDKPI> kpi
        {
            get
            {
                return this.kpiField;
            }
            set
            {
                this.kpiField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_PCDKPI
    {
        public static CT_PCDKPI Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PCDKPI ctObj = new CT_PCDKPI();
            ctObj.uniqueName = XmlHelper.ReadString(node.Attribute("uniqueName"));
            ctObj.caption = XmlHelper.ReadString(node.Attribute("caption"));
            ctObj.displayFolder = XmlHelper.ReadString(node.Attribute("displayFolder"));
            ctObj.measureGroup = XmlHelper.ReadString(node.Attribute("measureGroup"));
            ctObj.parent = XmlHelper.ReadString(node.Attribute("parent"));
            ctObj.value = XmlHelper.ReadString(node.Attribute("value"));
            ctObj.goal = XmlHelper.ReadString(node.Attribute("goal"));
            ctObj.status = XmlHelper.ReadString(node.Attribute("status"));
            ctObj.trend = XmlHelper.ReadString(node.Attribute("trend"));
            ctObj.weight = XmlHelper.ReadString(node.Attribute("weight"));
            ctObj.time = XmlHelper.ReadString(node.Attribute("time"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "uniqueName", this.uniqueName);
            XmlHelper.WriteAttribute(sw, "caption", this.caption);
            XmlHelper.WriteAttribute(sw, "displayFolder", this.displayFolder);
            XmlHelper.WriteAttribute(sw, "measureGroup", this.measureGroup);
            XmlHelper.WriteAttribute(sw, "parent", this.parent);
            XmlHelper.WriteAttribute(sw, "value", this.value);
            XmlHelper.WriteAttribute(sw, "goal", this.goal);
            XmlHelper.WriteAttribute(sw, "status", this.status);
            XmlHelper.WriteAttribute(sw, "trend", this.trend);
            XmlHelper.WriteAttribute(sw, "weight", this.weight);
            XmlHelper.WriteAttribute(sw, "time", this.time);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private string uniqueNameField;

        private string captionField;

        private string displayFolderField;

        private string measureGroupField;

        private string parentField;

        private string valueField;

        private string goalField;

        private string statusField;

        private string trendField;

        private string weightField;

        private string timeField;

        [XmlAttribute()]
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

        [XmlAttribute()]
        public string caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }

        [XmlAttribute()]
        public string displayFolder
        {
            get
            {
                return this.displayFolderField;
            }
            set
            {
                this.displayFolderField = value;
            }
        }

        [XmlAttribute()]
        public string measureGroup
        {
            get
            {
                return this.measureGroupField;
            }
            set
            {
                this.measureGroupField = value;
            }
        }

        [XmlAttribute()]
        public string parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
            }
        }

        [XmlAttribute()]
        public string value
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

        [XmlAttribute()]
        public string goal
        {
            get
            {
                return this.goalField;
            }
            set
            {
                this.goalField = value;
            }
        }

        [XmlAttribute()]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        [XmlAttribute()]
        public string trend
        {
            get
            {
                return this.trendField;
            }
            set
            {
                this.trendField = value;
            }
        }

        [XmlAttribute()]
        public string weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        [XmlAttribute()]
        public string time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_TupleCache
    {
        public static CT_TupleCache Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_TupleCache ctObj = new CT_TupleCache();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "entries")
                    ctObj.entries = CT_PCDSDTCEntries.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "sets")
                    ctObj.sets = CT_Sets.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "queryCache")
                    ctObj.queryCache = CT_QueryCache.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "serverFormats")
                    ctObj.serverFormats = CT_ServerFormats.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            sw.Write(">");
            if (this.entries != null)
                this.entries.Write(sw, "entries");
            if (this.sets != null)
                this.sets.Write(sw, "sets");
            if (this.queryCache != null)
                this.queryCache.Write(sw, "queryCache");
            if (this.serverFormats != null)
                this.serverFormats.Write(sw, "serverFormats");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_PCDSDTCEntries entriesField;

        private CT_Sets setsField;

        private CT_QueryCache queryCacheField;

        private CT_ServerFormats serverFormatsField;

        private CT_ExtensionList extLstField;

        public CT_TupleCache()
        {
            this.extLstField = new CT_ExtensionList();
            this.serverFormatsField = new CT_ServerFormats();
            this.queryCacheField = new CT_QueryCache();
            this.setsField = new CT_Sets();
            this.entriesField = new CT_PCDSDTCEntries();
        }

        [XmlElement(Order = 0)]
        public CT_PCDSDTCEntries entries
        {
            get
            {
                return this.entriesField;
            }
            set
            {
                this.entriesField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_Sets sets
        {
            get
            {
                return this.setsField;
            }
            set
            {
                this.setsField = value;
            }
        }

        [XmlElement(Order = 2)]
        public CT_QueryCache queryCache
        {
            get
            {
                return this.queryCacheField;
            }
            set
            {
                this.queryCacheField = value;
            }
        }

        [XmlElement(Order = 3)]
        public CT_ServerFormats serverFormats
        {
            get
            {
                return this.serverFormatsField;
            }
            set
            {
                this.serverFormatsField = value;
            }
        }

        [XmlElement(Order = 4)]
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
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_PCDSDTCEntries
    {
        public static CT_PCDSDTCEntries Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PCDSDTCEntries ctObj = new CT_PCDSDTCEntries();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "m")
                {
                    ctObj.Items.Add(CT_Missing.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.m);
                }
                else if (childNode.Name.LocalName == "n")
                {
                    ctObj.Items.Add(CT_Number.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.n);
                }
                else if (childNode.Name.LocalName == "e")
                {
                    ctObj.Items.Add(CT_Error.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.e);
                }
                else if (childNode.Name.LocalName == "s")
                {
                    ctObj.Items.Add(CT_String.Parse(childNode, namespaceManager));
                    //ctObj.ItemsElementName.Add(ItemsChoiceType1.s);
                }
            }
            return ctObj;
        }

        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            sw.Write(">");
            foreach (object o in this.Items)
            {
                if (o is CT_Missing)
                    ((CT_Missing)o).Write(sw, "m");
                else if (o is CT_Number)
                    ((CT_Number)o).Write(sw, "n");
                else if (o is CT_Error)
                    ((CT_Error)o).Write(sw, "e");
                else if (o is CT_String)
                    ((CT_String)o).Write(sw, "s");
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<object> itemsField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_PCDSDTCEntries()
        {
            this.itemsField = new List<object>();
        }

        [XmlElement("e", typeof(CT_Error), Order = 0)]
        [XmlElement("m", typeof(CT_Missing), Order = 0)]
        [XmlElement("n", typeof(CT_Number), Order = 0)]
        [XmlElement("s", typeof(CT_String), Order = 0)]
        public List<object> Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Sets
    {
        public static CT_Sets Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Sets ctObj = new CT_Sets();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.set = new List<CT_Set>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "set")
                    ctObj.set.Add(CT_Set.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.set != null)
            {
                foreach (CT_Set x in this.set)
                {
                    x.Write(sw, "set");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_Set> setField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_Sets()
        {
            this.setField = new List<CT_Set>();
        }

        [XmlElement("set", Order = 0)]
        public List<CT_Set> set
        {
            get
            {
                return this.setField;
            }
            set
            {
                this.setField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Set
    {
        public static CT_Set Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Set ctObj = new CT_Set();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            if (node.Attribute("maxRank") != null)
                ctObj.maxRank = XmlHelper.ReadInt(node.Attribute("maxRank"));
            ctObj.setDefinition = XmlHelper.ReadString(node.Attribute("setDefinition"));
            if (node.Attribute("sortType") != null)
                ctObj.sortType = (ST_SortType)Enum.Parse(typeof(ST_SortType), node.Attribute("sortType").Value);
            if (node.Attribute("queryFailed") != null)
                ctObj.queryFailed = XmlHelper.ReadBool(node.Attribute("queryFailed"));
            ctObj.tpls = new List<CT_Tuples>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "sortByTuple")
                    ctObj.sortByTuple = CT_Tuples.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "tpls")
                    ctObj.tpls.Add(CT_Tuples.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            XmlHelper.WriteAttribute(sw, "maxRank", this.maxRank);
            XmlHelper.WriteAttribute(sw, "setDefinition", this.setDefinition);
            XmlHelper.WriteAttribute(sw, "sortType", this.sortType.ToString());
            XmlHelper.WriteAttribute(sw, "queryFailed", this.queryFailed);
            sw.Write(">");
            if (this.sortByTuple != null)
                this.sortByTuple.Write(sw, "sortByTuple");
            if (this.tpls != null)
            {
                foreach (CT_Tuples x in this.tpls)
                {
                    x.Write(sw, "tpls");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_Tuples> tplsField;

        private CT_Tuples sortByTupleField;

        private uint countField;

        private bool countFieldSpecified;

        private int maxRankField;

        private string setDefinitionField;

        private ST_SortType sortTypeField;

        private bool queryFailedField;

        public CT_Set()
        {
            this.sortByTupleField = new CT_Tuples();
            this.tplsField = new List<CT_Tuples>();
            this.sortTypeField = ST_SortType.none;
            this.queryFailedField = false;
        }

        [XmlElement("tpls", Order = 0)]
        public List<CT_Tuples> tpls
        {
            get
            {
                return this.tplsField;
            }
            set
            {
                this.tplsField = value;
            }
        }

        [XmlElement(Order = 1)]
        public CT_Tuples sortByTuple
        {
            get
            {
                return this.sortByTupleField;
            }
            set
            {
                this.sortByTupleField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

        [XmlAttribute()]
        public int maxRank
        {
            get
            {
                return this.maxRankField;
            }
            set
            {
                this.maxRankField = value;
            }
        }

        [XmlAttribute()]
        public string setDefinition
        {
            get
            {
                return this.setDefinitionField;
            }
            set
            {
                this.setDefinitionField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ST_SortType.none)]
        public ST_SortType sortType
        {
            get
            {
                return this.sortTypeField;
            }
            set
            {
                this.sortTypeField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool queryFailed
        {
            get
            {
                return this.queryFailedField;
            }
            set
            {
                this.queryFailedField = value;
            }
        }
    }

    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
    public enum ST_SortType
    {

        /// <remarks/>
        none,

        /// <remarks/>
        ascending,

        /// <remarks/>
        descending,

        /// <remarks/>
        ascendingAlpha,

        /// <remarks/>
        descendingAlpha,

        /// <remarks/>
        ascendingNatural,

        /// <remarks/>
        descendingNatural,
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_QueryCache
    {
        public static CT_QueryCache Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_QueryCache ctObj = new CT_QueryCache();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.query = new List<CT_Query>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "query")
                    ctObj.query.Add(CT_Query.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.query != null)
            {
                foreach (CT_Query x in this.query)
                {
                    x.Write(sw, "query");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_Query> queryField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_QueryCache()
        {
            this.queryField = new List<CT_Query>();
        }

        [XmlElement("query", Order = 0)]
        public List<CT_Query> query
        {
            get
            {
                return this.queryField;
            }
            set
            {
                this.queryField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Query
    {
        public static CT_Query Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Query ctObj = new CT_Query();
            ctObj.mdx = XmlHelper.ReadString(node.Attribute("mdx"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "tpls")
                    ctObj.tpls = CT_Tuples.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "mdx", this.mdx);
            sw.Write(">");
            if (this.tpls != null)
                this.tpls.Write(sw, "tpls");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_Tuples tplsField;

        private string mdxField;

        public CT_Query()
        {
            this.tplsField = new CT_Tuples();
        }

        [XmlElement(Order = 0)]
        public CT_Tuples tpls
        {
            get
            {
                return this.tplsField;
            }
            set
            {
                this.tplsField = value;
            }
        }

        [XmlAttribute()]
        public string mdx
        {
            get
            {
                return this.mdxField;
            }
            set
            {
                this.mdxField = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_ServerFormats
    {
        public static CT_ServerFormats Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_ServerFormats ctObj = new CT_ServerFormats();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.serverFormat = new List<CT_ServerFormat>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "serverFormat")
                    ctObj.serverFormat.Add(CT_ServerFormat.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.serverFormat != null)
            {
                foreach (CT_ServerFormat x in this.serverFormat)
                {
                    x.Write(sw, "serverFormat");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_ServerFormat> serverFormatField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_ServerFormats()
        {
            this.serverFormatField = new List<CT_ServerFormat>();
        }

        [XmlElement("serverFormat", Order = 0)]
        public List<CT_ServerFormat> serverFormat
        {
            get
            {
                return this.serverFormatField;
            }
            set
            {
                this.serverFormatField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_ServerFormat
    {
        public static CT_ServerFormat Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_ServerFormat ctObj = new CT_ServerFormat();
            ctObj.culture = XmlHelper.ReadString(node.Attribute("culture"));
            ctObj.format = XmlHelper.ReadString(node.Attribute("format"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "culture", this.culture);
            XmlHelper.WriteAttribute(sw, "format", this.format);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private string cultureField;

        private string formatField;

        [XmlAttribute()]
        public string culture
        {
            get
            {
                return this.cultureField;
            }
            set
            {
                this.cultureField = value;
            }
        }

        [XmlAttribute()]
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_CalculatedItems
    {
        public static CT_CalculatedItems Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_CalculatedItems ctObj = new CT_CalculatedItems();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.calculatedItem = new List<CT_CalculatedItem>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "calculatedItem")
                    ctObj.calculatedItem.Add(CT_CalculatedItem.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.calculatedItem != null)
            {
                foreach (CT_CalculatedItem x in this.calculatedItem)
                {
                    x.Write(sw, "calculatedItem");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_CalculatedItem> calculatedItemField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_CalculatedItems()
        {
            this.calculatedItemField = new List<CT_CalculatedItem>();
        }

        [XmlElement("calculatedItem", Order = 0)]
        public List<CT_CalculatedItem> calculatedItem
        {
            get
            {
                return this.calculatedItemField;
            }
            set
            {
                this.calculatedItemField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_CalculatedItem
    {
        public static CT_CalculatedItem Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_CalculatedItem ctObj = new CT_CalculatedItem();
            if (node.Attribute("field") != null)
                ctObj.field = XmlHelper.ReadUInt(node.Attribute("field"));
            ctObj.formula = XmlHelper.ReadString(node.Attribute("formula"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "pivotArea")
                    ctObj.pivotArea = CT_PivotArea.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "field", this.field);
            XmlHelper.WriteAttribute(sw, "formula", this.formula);
            sw.Write(">");
            if (this.pivotArea != null)
                this.pivotArea.Write(sw, "pivotArea");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_PivotArea pivotAreaField;

        private CT_ExtensionList extLstField;

        private uint fieldField;

        private bool fieldFieldSpecified;

        private string formulaField;

        public CT_CalculatedItem()
        {
            this.extLstField = new CT_ExtensionList();
            this.pivotAreaField = new CT_PivotArea();
        }

        [XmlElement(Order = 0)]
        public CT_PivotArea pivotArea
        {
            get
            {
                return this.pivotAreaField;
            }
            set
            {
                this.pivotAreaField = value;
            }
        }

        [XmlElement(Order = 1)]
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

        [XmlAttribute()]
        public uint field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fieldSpecified
        {
            get
            {
                return this.fieldFieldSpecified;
            }
            set
            {
                this.fieldFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string formula
        {
            get
            {
                return this.formulaField;
            }
            set
            {
                this.formulaField = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_CalculatedMembers
    {
        public static CT_CalculatedMembers Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_CalculatedMembers ctObj = new CT_CalculatedMembers();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.calculatedMember = new List<CT_CalculatedMember>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "calculatedMember")
                    ctObj.calculatedMember.Add(CT_CalculatedMember.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.calculatedMember != null)
            {
                foreach (CT_CalculatedMember x in this.calculatedMember)
                {
                    x.Write(sw, "calculatedMember");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_CalculatedMember> calculatedMemberField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_CalculatedMembers()
        {
            this.calculatedMemberField = new List<CT_CalculatedMember>();
        }

        [XmlElement("calculatedMember", Order = 0)]
        public List<CT_CalculatedMember> calculatedMember
        {
            get
            {
                return this.calculatedMemberField;
            }
            set
            {
                this.calculatedMemberField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_CalculatedMember
    {
        public static CT_CalculatedMember Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_CalculatedMember ctObj = new CT_CalculatedMember();
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            ctObj.mdx = XmlHelper.ReadString(node.Attribute("mdx"));
            ctObj.memberName = XmlHelper.ReadString(node.Attribute("memberName"));
            ctObj.hierarchy = XmlHelper.ReadString(node.Attribute("hierarchy"));
            ctObj.parent = XmlHelper.ReadString(node.Attribute("parent"));
            if (node.Attribute("solveOrder") != null)
                ctObj.solveOrder = XmlHelper.ReadInt(node.Attribute("solveOrder"));
            if (node.Attribute("set") != null)
                ctObj.set = XmlHelper.ReadBool(node.Attribute("set"));
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
            XmlHelper.WriteAttribute(sw, "mdx", this.mdx);
            XmlHelper.WriteAttribute(sw, "memberName", this.memberName);
            XmlHelper.WriteAttribute(sw, "hierarchy", this.hierarchy);
            XmlHelper.WriteAttribute(sw, "parent", this.parent);
            XmlHelper.WriteAttribute(sw, "solveOrder", this.solveOrder);
            XmlHelper.WriteAttribute(sw, "set", this.set);
            sw.Write(">");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_ExtensionList extLstField;

        private string nameField;

        private string mdxField;

        private string memberNameField;

        private string hierarchyField;

        private string parentField;

        private int solveOrderField;

        private bool setField;

        public CT_CalculatedMember()
        {
            this.extLstField = new CT_ExtensionList();
            this.solveOrderField = 0;
            this.setField = false;
        }

        [XmlElement(Order = 0)]
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

        [XmlAttribute()]
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

        [XmlAttribute()]
        public string mdx
        {
            get
            {
                return this.mdxField;
            }
            set
            {
                this.mdxField = value;
            }
        }

        [XmlAttribute()]
        public string memberName
        {
            get
            {
                return this.memberNameField;
            }
            set
            {
                this.memberNameField = value;
            }
        }

        [XmlAttribute()]
        public string hierarchy
        {
            get
            {
                return this.hierarchyField;
            }
            set
            {
                this.hierarchyField = value;
            }
        }

        [XmlAttribute()]
        public string parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int solveOrder
        {
            get
            {
                return this.solveOrderField;
            }
            set
            {
                this.solveOrderField = value;
            }
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool set
        {
            get
            {
                return this.setField;
            }
            set
            {
                this.setField = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Dimensions
    {
        public static CT_Dimensions Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Dimensions ctObj = new CT_Dimensions();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.dimension = new List<CT_PivotDimension>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "dimension")
                    ctObj.dimension.Add(CT_PivotDimension.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.dimension != null)
            {
                foreach (CT_PivotDimension x in this.dimension)
                {
                    x.Write(sw, "dimension");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_PivotDimension> dimensionField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_Dimensions()
        {
            this.dimensionField = new List<CT_PivotDimension>();
        }

        [XmlElement("dimension", Order = 0)]
        public List<CT_PivotDimension> dimension
        {
            get
            {
                return this.dimensionField;
            }
            set
            {
                this.dimensionField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_PivotDimension
    {
        public static CT_PivotDimension Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PivotDimension ctObj = new CT_PivotDimension();
            if (node.Attribute("measure") != null)
                ctObj.measure = XmlHelper.ReadBool(node.Attribute("measure"));
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            ctObj.uniqueName = XmlHelper.ReadString(node.Attribute("uniqueName"));
            ctObj.caption = XmlHelper.ReadString(node.Attribute("caption"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "measure", this.measure);
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "uniqueName", this.uniqueName);
            XmlHelper.WriteAttribute(sw, "caption", this.caption);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private bool measureField;

        private string nameField;

        private string uniqueNameField;

        private string captionField;

        public CT_PivotDimension()
        {
            this.measureField = false;
        }

        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [XmlAttribute()]
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

        [XmlAttribute()]
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

        [XmlAttribute()]
        public string caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_MeasureGroups
    {
        public static CT_MeasureGroups Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_MeasureGroups ctObj = new CT_MeasureGroups();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.measureGroup = new List<CT_MeasureGroup>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "measureGroup")
                    ctObj.measureGroup.Add(CT_MeasureGroup.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.measureGroup != null)
            {
                foreach (CT_MeasureGroup x in this.measureGroup)
                {
                    x.Write(sw, "measureGroup");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_MeasureGroup> measureGroupField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_MeasureGroups()
        {
            this.measureGroupField = new List<CT_MeasureGroup>();
        }

        [XmlElement("measureGroup", Order = 0)]
        public List<CT_MeasureGroup> measureGroup
        {
            get
            {
                return this.measureGroupField;
            }
            set
            {
                this.measureGroupField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_MeasureGroup
    {
        public static CT_MeasureGroup Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_MeasureGroup ctObj = new CT_MeasureGroup();
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            ctObj.caption = XmlHelper.ReadString(node.Attribute("caption"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "caption", this.caption);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private string nameField;

        private string captionField;

        [XmlAttribute()]
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

        [XmlAttribute()]
        public string caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_MeasureDimensionMaps
    {
        public static CT_MeasureDimensionMaps Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_MeasureDimensionMaps ctObj = new CT_MeasureDimensionMaps();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.map = new List<CT_MeasureDimensionMap>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "map")
                    ctObj.map.Add(CT_MeasureDimensionMap.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.map != null)
            {
                foreach (CT_MeasureDimensionMap x in this.map)
                {
                    x.Write(sw, "map");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_MeasureDimensionMap> mapField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_MeasureDimensionMaps()
        {
            this.mapField = new List<CT_MeasureDimensionMap>();
        }

        [XmlElement("map", Order = 0)]
        public List<CT_MeasureDimensionMap> map
        {
            get
            {
                return this.mapField;
            }
            set
            {
                this.mapField = value;
            }
        }

        [XmlAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
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

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_MeasureDimensionMap
    {
        public static CT_MeasureDimensionMap Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_MeasureDimensionMap ctObj = new CT_MeasureDimensionMap();
            if (node.Attribute("measureGroup") != null)
                ctObj.measureGroup = XmlHelper.ReadUInt(node.Attribute("measureGroup"));
            if (node.Attribute("dimension") != null)
                ctObj.dimension = XmlHelper.ReadUInt(node.Attribute("dimension"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "measureGroup", this.measureGroup);
            XmlHelper.WriteAttribute(sw, "dimension", this.dimension);
            sw.Write("/>");
        }

        private uint measureGroupField;

        private bool measureGroupFieldSpecified;

        private uint dimensionField;

        private bool dimensionFieldSpecified;

        [XmlAttribute()]
        public uint measureGroup
        {
            get
            {
                return this.measureGroupField;
            }
            set
            {
                this.measureGroupField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureGroupSpecified
        {
            get
            {
                return this.measureGroupFieldSpecified;
            }
            set
            {
                this.measureGroupFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public uint dimension
        {
            get
            {
                return this.dimensionField;
            }
            set
            {
                this.dimensionField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dimensionSpecified
        {
            get
            {
                return this.dimensionFieldSpecified;
            }
            set
            {
                this.dimensionFieldSpecified = value;
            }
        }
    }
}
