using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using NPOI.OpenXml4Net.Util;
using System.IO;
using System.Xml.Linq;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot("pivotTableDefinition", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
    public partial class CT_PivotTableDefinition
    {
        public static CT_PivotTableDefinition Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PivotTableDefinition ctObj = new CT_PivotTableDefinition();
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            if (node.Attribute("cacheId") != null)
                ctObj.cacheId = XmlHelper.ReadUInt(node.Attribute("cacheId"));
            if (node.Attribute("dataOnRows") != null)
                ctObj.dataOnRows = XmlHelper.ReadBool(node.Attribute("dataOnRows"));
            if (node.Attribute("dataPosition") != null)
                ctObj.dataPosition = XmlHelper.ReadUInt(node.Attribute("dataPosition"));
            if (node.Attribute("autoFormatId") != null)
                ctObj.autoFormatId = XmlHelper.ReadUInt(node.Attribute("autoFormatId"));
            if (node.Attribute("applyNumberFormats") != null)
                ctObj.applyNumberFormats = XmlHelper.ReadBool(node.Attribute("applyNumberFormats"));
            if (node.Attribute("applyBorderFormats") != null)
                ctObj.applyBorderFormats = XmlHelper.ReadBool(node.Attribute("applyBorderFormats"));
            if (node.Attribute("applyFontFormats") != null)
                ctObj.applyFontFormats = XmlHelper.ReadBool(node.Attribute("applyFontFormats"));
            if (node.Attribute("applyPatternFormats") != null)
                ctObj.applyPatternFormats = XmlHelper.ReadBool(node.Attribute("applyPatternFormats"));
            if (node.Attribute("applyAlignmentFormats") != null)
                ctObj.applyAlignmentFormats = XmlHelper.ReadBool(node.Attribute("applyAlignmentFormats"));
            if (node.Attribute("applyWidthHeightFormats") != null)
                ctObj.applyWidthHeightFormats = XmlHelper.ReadBool(node.Attribute("applyWidthHeightFormats"));
            ctObj.dataCaption = XmlHelper.ReadString(node.Attribute("dataCaption"));
            ctObj.grandTotalCaption = XmlHelper.ReadString(node.Attribute("grandTotalCaption"));
            ctObj.errorCaption = XmlHelper.ReadString(node.Attribute("errorCaption"));
            if (node.Attribute("showError") != null)
                ctObj.showError = XmlHelper.ReadBool(node.Attribute("showError"));
            ctObj.missingCaption = XmlHelper.ReadString(node.Attribute("missingCaption"));
            if (node.Attribute("showMissing") != null)
                ctObj.showMissing = XmlHelper.ReadBool(node.Attribute("showMissing"));
            ctObj.pageStyle = XmlHelper.ReadString(node.Attribute("pageStyle"));
            ctObj.pivotTableStyle = XmlHelper.ReadString(node.Attribute("pivotTableStyle"));
            ctObj.vacatedStyle = XmlHelper.ReadString(node.Attribute("vacatedStyle"));
            ctObj.tag = XmlHelper.ReadString(node.Attribute("tag"));
            if (node.Attribute("updatedVersion") != null)
                ctObj.updatedVersion = XmlHelper.ReadByte(node.Attribute("updatedVersion"));
            if (node.Attribute("minRefreshableVersion") != null)
                ctObj.minRefreshableVersion = XmlHelper.ReadByte(node.Attribute("minRefreshableVersion"));
            if (node.Attribute("asteriskTotals") != null)
                ctObj.asteriskTotals = XmlHelper.ReadBool(node.Attribute("asteriskTotals"));
            if (node.Attribute("showItems") != null)
                ctObj.showItems = XmlHelper.ReadBool(node.Attribute("showItems"));
            if (node.Attribute("editData") != null)
                ctObj.editData = XmlHelper.ReadBool(node.Attribute("editData"));
            if (node.Attribute("disableFieldList") != null)
                ctObj.disableFieldList = XmlHelper.ReadBool(node.Attribute("disableFieldList"));
            if (node.Attribute("showCalcMbrs") != null)
                ctObj.showCalcMbrs = XmlHelper.ReadBool(node.Attribute("showCalcMbrs"));
            if (node.Attribute("visualTotals") != null)
                ctObj.visualTotals = XmlHelper.ReadBool(node.Attribute("visualTotals"));
            if (node.Attribute("showMultipleLabel") != null)
                ctObj.showMultipleLabel = XmlHelper.ReadBool(node.Attribute("showMultipleLabel"));
            if (node.Attribute("showDataDropDown") != null)
                ctObj.showDataDropDown = XmlHelper.ReadBool(node.Attribute("showDataDropDown"));
            if (node.Attribute("showDrill") != null)
                ctObj.showDrill = XmlHelper.ReadBool(node.Attribute("showDrill"));
            if (node.Attribute("printDrill") != null)
                ctObj.printDrill = XmlHelper.ReadBool(node.Attribute("printDrill"));
            if (node.Attribute("showMemberPropertyTips") != null)
                ctObj.showMemberPropertyTips = XmlHelper.ReadBool(node.Attribute("showMemberPropertyTips"));
            if (node.Attribute("showDataTips") != null)
                ctObj.showDataTips = XmlHelper.ReadBool(node.Attribute("showDataTips"));
            if (node.Attribute("enableWizard") != null)
                ctObj.enableWizard = XmlHelper.ReadBool(node.Attribute("enableWizard"));
            if (node.Attribute("enableDrill") != null)
                ctObj.enableDrill = XmlHelper.ReadBool(node.Attribute("enableDrill"));
            if (node.Attribute("enableFieldProperties") != null)
                ctObj.enableFieldProperties = XmlHelper.ReadBool(node.Attribute("enableFieldProperties"));
            if (node.Attribute("preserveFormatting") != null)
                ctObj.preserveFormatting = XmlHelper.ReadBool(node.Attribute("preserveFormatting"));
            if (node.Attribute("useAutoFormatting") != null)
                ctObj.useAutoFormatting = XmlHelper.ReadBool(node.Attribute("useAutoFormatting"));
            if (node.Attribute("pageWrap") != null)
                ctObj.pageWrap = XmlHelper.ReadUInt(node.Attribute("pageWrap"));
            if (node.Attribute("pageOverThenDown") != null)
                ctObj.pageOverThenDown = XmlHelper.ReadBool(node.Attribute("pageOverThenDown"));
            if (node.Attribute("subtotalHiddenItems") != null)
                ctObj.subtotalHiddenItems = XmlHelper.ReadBool(node.Attribute("subtotalHiddenItems"));
            if (node.Attribute("rowGrandTotals") != null)
                ctObj.rowGrandTotals = XmlHelper.ReadBool(node.Attribute("rowGrandTotals"));
            if (node.Attribute("colGrandTotals") != null)
                ctObj.colGrandTotals = XmlHelper.ReadBool(node.Attribute("colGrandTotals"));
            if (node.Attribute("fieldPrintTitles") != null)
                ctObj.fieldPrintTitles = XmlHelper.ReadBool(node.Attribute("fieldPrintTitles"));
            if (node.Attribute("itemPrintTitles") != null)
                ctObj.itemPrintTitles = XmlHelper.ReadBool(node.Attribute("itemPrintTitles"));
            if (node.Attribute("mergeItem") != null)
                ctObj.mergeItem = XmlHelper.ReadBool(node.Attribute("mergeItem"));
            if (node.Attribute("showDropZones") != null)
                ctObj.showDropZones = XmlHelper.ReadBool(node.Attribute("showDropZones"));
            if (node.Attribute("createdVersion") != null)
                ctObj.createdVersion = XmlHelper.ReadByte(node.Attribute("createdVersion"));
            if (node.Attribute("indent") != null)
                ctObj.indent = XmlHelper.ReadUInt(node.Attribute("indent"));
            if (node.Attribute("showEmptyRow") != null)
                ctObj.showEmptyRow = XmlHelper.ReadBool(node.Attribute("showEmptyRow"));
            if (node.Attribute("showEmptyCol") != null)
                ctObj.showEmptyCol = XmlHelper.ReadBool(node.Attribute("showEmptyCol"));
            if (node.Attribute("showHeaders") != null)
                ctObj.showHeaders = XmlHelper.ReadBool(node.Attribute("showHeaders"));
            if (node.Attribute("compact") != null)
                ctObj.compact = XmlHelper.ReadBool(node.Attribute("compact"));
            if (node.Attribute("outline") != null)
                ctObj.outline = XmlHelper.ReadBool(node.Attribute("outline"));
            if (node.Attribute("outlineData") != null)
                ctObj.outlineData = XmlHelper.ReadBool(node.Attribute("outlineData"));
            if (node.Attribute("compactData") != null)
                ctObj.compactData = XmlHelper.ReadBool(node.Attribute("compactData"));
            if (node.Attribute("published") != null)
                ctObj.published = XmlHelper.ReadBool(node.Attribute("published"));
            if (node.Attribute("gridDropZones") != null)
                ctObj.gridDropZones = XmlHelper.ReadBool(node.Attribute("gridDropZones"));
            if (node.Attribute("immersive") != null)
                ctObj.immersive = XmlHelper.ReadBool(node.Attribute("immersive"));
            if (node.Attribute("multipleFieldFilters") != null)
                ctObj.multipleFieldFilters = XmlHelper.ReadBool(node.Attribute("multipleFieldFilters"));
            if (node.Attribute("chartFormat") != null)
                ctObj.chartFormat = XmlHelper.ReadUInt(node.Attribute("chartFormat"));
            ctObj.rowHeaderCaption = XmlHelper.ReadString(node.Attribute("rowHeaderCaption"));
            ctObj.colHeaderCaption = XmlHelper.ReadString(node.Attribute("colHeaderCaption"));
            if (node.Attribute("fieldListSortAscending") != null)
                ctObj.fieldListSortAscending = XmlHelper.ReadBool(node.Attribute("fieldListSortAscending"));
            if (node.Attribute("mdxSubqueries") != null)
                ctObj.mdxSubqueries = XmlHelper.ReadBool(node.Attribute("mdxSubqueries"));
            if (node.Attribute("customListSort") != null)
                ctObj.customListSort = XmlHelper.ReadBool(node.Attribute("customListSort"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "location")
                    ctObj.location = CT_Location.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "pivotFields")
                    ctObj.pivotFields = CT_PivotFields.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "rowFields")
                    ctObj.rowFields = CT_RowFields.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "rowItems")
                    ctObj.rowItems = CT_rowItems.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "colFields")
                    ctObj.colFields = CT_ColFields.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "colItems")
                    ctObj.colItems = CT_colItems.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "pageFields")
                    ctObj.pageFields = CT_PageFields.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "dataFields")
                    ctObj.dataFields = CT_DataFields.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "formats")
                    ctObj.formats = CT_Formats.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "conditionalFormats")
                    ctObj.conditionalFormats = CT_ConditionalFormats.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "chartFormats")
                    ctObj.chartFormats = CT_ChartFormats.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "pivotHierarchies")
                    ctObj.pivotHierarchies = CT_PivotHierarchies.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "pivotTableStyleInfo")
                    ctObj.pivotTableStyleInfo = CT_PivotTableStyle.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "filters")
                    ctObj.filters = CT_PivotFilters.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "rowHierarchiesUsage")
                    ctObj.rowHierarchiesUsage = CT_RowHierarchiesUsage.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "colHierarchiesUsage")
                    ctObj.colHierarchiesUsage = CT_ColHierarchiesUsage.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw)
        {
            sw.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
            sw.Write("<pivotTableDefinition xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\" ");
            sw.Write("xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\" ");
            sw.Write("xmlns:s=\"http://schemas.openxmlformats.org/officeDocument/2006/sharedTypes\" ");
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "cacheId", this.cacheId);
            XmlHelper.WriteAttribute(sw, "dataOnRows", this.dataOnRows);
            XmlHelper.WriteAttribute(sw, "dataPosition", this.dataPosition);
            XmlHelper.WriteAttribute(sw, "autoFormatId", this.autoFormatId);
            XmlHelper.WriteAttribute(sw, "applyNumberFormats", this.applyNumberFormats);
            XmlHelper.WriteAttribute(sw, "applyBorderFormats", this.applyBorderFormats);
            XmlHelper.WriteAttribute(sw, "applyFontFormats", this.applyFontFormats);
            XmlHelper.WriteAttribute(sw, "applyPatternFormats", this.applyPatternFormats);
            XmlHelper.WriteAttribute(sw, "applyAlignmentFormats", this.applyAlignmentFormats);
            XmlHelper.WriteAttribute(sw, "applyWidthHeightFormats", this.applyWidthHeightFormats);
            XmlHelper.WriteAttribute(sw, "dataCaption", this.dataCaption);
            XmlHelper.WriteAttribute(sw, "grandTotalCaption", this.grandTotalCaption);
            XmlHelper.WriteAttribute(sw, "errorCaption", this.errorCaption);
            XmlHelper.WriteAttribute(sw, "showError", this.showError);
            XmlHelper.WriteAttribute(sw, "missingCaption", this.missingCaption);
            XmlHelper.WriteAttribute(sw, "showMissing", this.showMissing);
            XmlHelper.WriteAttribute(sw, "pageStyle", this.pageStyle);
            XmlHelper.WriteAttribute(sw, "pivotTableStyle", this.pivotTableStyle);
            XmlHelper.WriteAttribute(sw, "vacatedStyle", this.vacatedStyle);
            XmlHelper.WriteAttribute(sw, "tag", this.tag);
            XmlHelper.WriteAttribute(sw, "updatedVersion", this.updatedVersion);
            XmlHelper.WriteAttribute(sw, "minRefreshableVersion", this.minRefreshableVersion);
            XmlHelper.WriteAttribute(sw, "asteriskTotals", this.asteriskTotals);
            XmlHelper.WriteAttribute(sw, "showItems", this.showItems);
            XmlHelper.WriteAttribute(sw, "editData", this.editData);
            XmlHelper.WriteAttribute(sw, "disableFieldList", this.disableFieldList);
            XmlHelper.WriteAttribute(sw, "showCalcMbrs", this.showCalcMbrs);
            XmlHelper.WriteAttribute(sw, "visualTotals", this.visualTotals);
            XmlHelper.WriteAttribute(sw, "showMultipleLabel", this.showMultipleLabel);
            XmlHelper.WriteAttribute(sw, "showDataDropDown", this.showDataDropDown);
            XmlHelper.WriteAttribute(sw, "showDrill", this.showDrill);
            XmlHelper.WriteAttribute(sw, "printDrill", this.printDrill);
            XmlHelper.WriteAttribute(sw, "showMemberPropertyTips", this.showMemberPropertyTips);
            XmlHelper.WriteAttribute(sw, "showDataTips", this.showDataTips);
            XmlHelper.WriteAttribute(sw, "enableWizard", this.enableWizard);
            XmlHelper.WriteAttribute(sw, "enableDrill", this.enableDrill);
            XmlHelper.WriteAttribute(sw, "enableFieldProperties", this.enableFieldProperties);
            XmlHelper.WriteAttribute(sw, "preserveFormatting", this.preserveFormatting);
            XmlHelper.WriteAttribute(sw, "useAutoFormatting", this.useAutoFormatting);
            XmlHelper.WriteAttribute(sw, "pageWrap", this.pageWrap);
            XmlHelper.WriteAttribute(sw, "pageOverThenDown", this.pageOverThenDown);
            XmlHelper.WriteAttribute(sw, "subtotalHiddenItems", this.subtotalHiddenItems);
            XmlHelper.WriteAttribute(sw, "rowGrandTotals", this.rowGrandTotals);
            XmlHelper.WriteAttribute(sw, "colGrandTotals", this.colGrandTotals);
            XmlHelper.WriteAttribute(sw, "fieldPrintTitles", this.fieldPrintTitles);
            XmlHelper.WriteAttribute(sw, "itemPrintTitles", this.itemPrintTitles);
            XmlHelper.WriteAttribute(sw, "mergeItem", this.mergeItem);
            XmlHelper.WriteAttribute(sw, "showDropZones", this.showDropZones);
            XmlHelper.WriteAttribute(sw, "createdVersion", this.createdVersion);
            XmlHelper.WriteAttribute(sw, "indent", this.indent);
            XmlHelper.WriteAttribute(sw, "showEmptyRow", this.showEmptyRow);
            XmlHelper.WriteAttribute(sw, "showEmptyCol", this.showEmptyCol);
            XmlHelper.WriteAttribute(sw, "showHeaders", this.showHeaders);
            XmlHelper.WriteAttribute(sw, "compact", this.compact);
            XmlHelper.WriteAttribute(sw, "outline", this.outline);
            XmlHelper.WriteAttribute(sw, "outlineData", this.outlineData);
            XmlHelper.WriteAttribute(sw, "compactData", this.compactData);
            XmlHelper.WriteAttribute(sw, "published", this.published);
            XmlHelper.WriteAttribute(sw, "gridDropZones", this.gridDropZones);
            XmlHelper.WriteAttribute(sw, "immersive", this.immersive);
            XmlHelper.WriteAttribute(sw, "multipleFieldFilters", this.multipleFieldFilters);
            XmlHelper.WriteAttribute(sw, "chartFormat", this.chartFormat);
            XmlHelper.WriteAttribute(sw, "rowHeaderCaption", this.rowHeaderCaption);
            XmlHelper.WriteAttribute(sw, "colHeaderCaption", this.colHeaderCaption);
            XmlHelper.WriteAttribute(sw, "fieldListSortAscending", this.fieldListSortAscending);
            XmlHelper.WriteAttribute(sw, "mdxSubqueries", this.mdxSubqueries);
            XmlHelper.WriteAttribute(sw, "customListSort", this.customListSort);
            sw.Write(">");
            if (this.location != null)
                this.location.Write(sw, "location");
            if (this.pivotFields != null)
                this.pivotFields.Write(sw, "pivotFields");
            if (this.rowFields != null)
                this.rowFields.Write(sw, "rowFields");
            if (this.rowItems != null)
                this.rowItems.Write(sw, "rowItems");
            if (this.colFields != null)
                this.colFields.Write(sw, "colFields");
            if (this.colItems != null)
                this.colItems.Write(sw, "colItems");
            if (this.pageFields != null)
                this.pageFields.Write(sw, "pageFields");
            if (this.dataFields != null)
                this.dataFields.Write(sw, "dataFields");
            if (this.formats != null)
                this.formats.Write(sw, "formats");
            if (this.conditionalFormats != null)
                this.conditionalFormats.Write(sw, "conditionalFormats");
            if (this.chartFormats != null)
                this.chartFormats.Write(sw, "chartFormats");
            if (this.pivotHierarchies != null)
                this.pivotHierarchies.Write(sw, "pivotHierarchies");
            if (this.pivotTableStyleInfo != null)
                this.pivotTableStyleInfo.Write(sw, "pivotTableStyleInfo");
            if (this.filters != null)
                this.filters.Write(sw, "filters");
            if (this.rowHierarchiesUsage != null)
                this.rowHierarchiesUsage.Write(sw, "rowHierarchiesUsage");
            if (this.colHierarchiesUsage != null)
                this.colHierarchiesUsage.Write(sw, "colHierarchiesUsage");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</pivotTableDefinition>"));
        }
        public void Save(Stream stream)
        {
            using (StreamWriter sw = new StreamWriter(stream))
            {
                this.Write(sw);
            }
        }
        private CT_Location locationField;

        private CT_PivotFields pivotFieldsField;

        private CT_RowFields rowFieldsField;

        private CT_rowItems rowItemsField;

        private CT_ColFields colFieldsField;

        private CT_colItems colItemsField;

        private CT_PageFields pageFieldsField;

        private CT_DataFields dataFieldsField;

        private CT_Formats formatsField;

        private CT_ConditionalFormats conditionalFormatsField;

        private CT_ChartFormats chartFormatsField;

        private CT_PivotHierarchies pivotHierarchiesField;

        private CT_PivotTableStyle pivotTableStyleInfoField;

        private CT_PivotFilters filtersField;

        private CT_RowHierarchiesUsage rowHierarchiesUsageField;

        private CT_ColHierarchiesUsage colHierarchiesUsageField;

        private CT_ExtensionList extLstField;

        private string nameField;

        private uint cacheIdField;

        private bool dataOnRowsField;

        private uint dataPositionField;

        private bool dataPositionFieldSpecified;

        private uint autoFormatIdField;

        private bool autoFormatIdFieldSpecified;

        private bool applyNumberFormatsField;

        private bool applyNumberFormatsFieldSpecified;

        private bool applyBorderFormatsField;

        private bool applyBorderFormatsFieldSpecified;

        private bool applyFontFormatsField;

        private bool applyFontFormatsFieldSpecified;

        private bool applyPatternFormatsField;

        private bool applyPatternFormatsFieldSpecified;

        private bool applyAlignmentFormatsField;

        private bool applyAlignmentFormatsFieldSpecified;

        private bool applyWidthHeightFormatsField;

        private bool applyWidthHeightFormatsFieldSpecified;

        private string dataCaptionField;

        private string grandTotalCaptionField;

        private string errorCaptionField;

        private bool showErrorField;

        private string missingCaptionField;

        private bool showMissingField;

        private string pageStyleField;

        private string pivotTableStyleField;

        private string vacatedStyleField;

        private string tagField;

        private byte updatedVersionField;

        private byte minRefreshableVersionField;

        private bool asteriskTotalsField;

        private bool showItemsField;

        private bool editDataField;

        private bool disableFieldListField;

        private bool showCalcMbrsField;

        private bool visualTotalsField;

        private bool showMultipleLabelField;

        private bool showDataDropDownField;

        private bool showDrillField;

        private bool printDrillField;

        private bool showMemberPropertyTipsField;

        private bool showDataTipsField;

        private bool enableWizardField;

        private bool enableDrillField;

        private bool enableFieldPropertiesField;

        private bool preserveFormattingField;

        private bool useAutoFormattingField;

        private uint pageWrapField;

        private bool pageOverThenDownField;

        private bool subtotalHiddenItemsField;

        private bool rowGrandTotalsField;

        private bool colGrandTotalsField;

        private bool fieldPrintTitlesField;

        private bool itemPrintTitlesField;

        private bool mergeItemField;

        private bool showDropZonesField;

        private byte createdVersionField;

        private uint indentField;

        private bool showEmptyRowField;

        private bool showEmptyColField;

        private bool showHeadersField;

        private bool compactField;

        private bool outlineField;

        private bool outlineDataField;

        private bool compactDataField;

        private bool publishedField;

        private bool gridDropZonesField;

        private bool immersiveField;

        private bool multipleFieldFiltersField;

        private uint chartFormatField;

        private string rowHeaderCaptionField;

        private string colHeaderCaptionField;

        private bool fieldListSortAscendingField;

        private bool mdxSubqueriesField;

        private bool customListSortField;

        public CT_PivotTableDefinition()
        {
            //this.extLstField = new CT_ExtensionList();
            //this.colHierarchiesUsageField = new CT_ColHierarchiesUsage();
            //this.rowHierarchiesUsageField = new CT_RowHierarchiesUsage();
            //this.filtersField = new CT_PivotFilters();
            //this.pivotTableStyleInfoField = new CT_PivotTableStyle();
            //this.pivotHierarchiesField = new CT_PivotHierarchies();
            //this.chartFormatsField = new CT_ChartFormats();
            //this.conditionalFormatsField = new CT_ConditionalFormats();
            //this.formatsField = new CT_Formats();
            //this.dataFieldsField = new CT_DataFields();
            //this.pageFieldsField = new CT_PageFields();
            //this.colItemsField = new CT_colItems();
            //this.colFieldsField = new CT_ColFields();
            //this.rowItemsField = new CT_rowItems();
            //this.rowFieldsField = new CT_RowFields();
            //this.pivotFieldsField = new CT_PivotFields();
            //this.locationField = new CT_Location();
            this.dataOnRowsField = false;
            this.showErrorField = false;
            this.showMissingField = true;
            this.updatedVersionField = ((byte)(0));
            this.minRefreshableVersionField = ((byte)(0));
            this.asteriskTotalsField = false;
            this.showItemsField = true;
            this.editDataField = false;
            this.disableFieldListField = false;
            this.showCalcMbrsField = true;
            this.visualTotalsField = true;
            this.showMultipleLabelField = true;
            this.showDataDropDownField = true;
            this.showDrillField = true;
            this.printDrillField = false;
            this.showMemberPropertyTipsField = true;
            this.showDataTipsField = true;
            this.enableWizardField = true;
            this.enableDrillField = true;
            this.enableFieldPropertiesField = true;
            this.preserveFormattingField = true;
            this.useAutoFormattingField = false;
            this.pageWrapField = ((uint)(0));
            this.pageOverThenDownField = false;
            this.subtotalHiddenItemsField = false;
            this.rowGrandTotalsField = true;
            this.colGrandTotalsField = true;
            this.fieldPrintTitlesField = false;
            this.itemPrintTitlesField = false;
            this.mergeItemField = false;
            this.showDropZonesField = true;
            this.createdVersionField = ((byte)(0));
            this.indentField = ((uint)(1));
            this.showEmptyRowField = false;
            this.showEmptyColField = false;
            this.showHeadersField = true;
            this.compactField = true;
            this.outlineField = false;
            this.outlineDataField = false;
            this.compactDataField = true;
            this.publishedField = false;
            this.gridDropZonesField = false;
            this.immersiveField = true;
            this.multipleFieldFiltersField = true;
            this.chartFormatField = ((uint)(0));
            this.fieldListSortAscendingField = false;
            this.mdxSubqueriesField = false;
            this.customListSortField = true;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CT_Location location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CT_PivotFields pivotFields
        {
            get
            {
                return this.pivotFieldsField;
            }
            set
            {
                this.pivotFieldsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CT_RowFields rowFields
        {
            get
            {
                return this.rowFieldsField;
            }
            set
            {
                this.rowFieldsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CT_rowItems rowItems
        {
            get
            {
                return this.rowItemsField;
            }
            set
            {
                this.rowItemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public CT_ColFields colFields
        {
            get
            {
                return this.colFieldsField;
            }
            set
            {
                this.colFieldsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public CT_colItems colItems
        {
            get
            {
                return this.colItemsField;
            }
            set
            {
                this.colItemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public CT_PageFields pageFields
        {
            get
            {
                return this.pageFieldsField;
            }
            set
            {
                this.pageFieldsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public CT_DataFields dataFields
        {
            get
            {
                return this.dataFieldsField;
            }
            set
            {
                this.dataFieldsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public CT_Formats formats
        {
            get
            {
                return this.formatsField;
            }
            set
            {
                this.formatsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public CT_ConditionalFormats conditionalFormats
        {
            get
            {
                return this.conditionalFormatsField;
            }
            set
            {
                this.conditionalFormatsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public CT_ChartFormats chartFormats
        {
            get
            {
                return this.chartFormatsField;
            }
            set
            {
                this.chartFormatsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public CT_PivotHierarchies pivotHierarchies
        {
            get
            {
                return this.pivotHierarchiesField;
            }
            set
            {
                this.pivotHierarchiesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public CT_PivotTableStyle pivotTableStyleInfo
        {
            get
            {
                return this.pivotTableStyleInfoField;
            }
            set
            {
                this.pivotTableStyleInfoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public CT_PivotFilters filters
        {
            get
            {
                return this.filtersField;
            }
            set
            {
                this.filtersField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public CT_RowHierarchiesUsage rowHierarchiesUsage
        {
            get
            {
                return this.rowHierarchiesUsageField;
            }
            set
            {
                this.rowHierarchiesUsageField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public CT_ColHierarchiesUsage colHierarchiesUsage
        {
            get
            {
                return this.colHierarchiesUsageField;
            }
            set
            {
                this.colHierarchiesUsageField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint cacheId
        {
            get
            {
                return this.cacheIdField;
            }
            set
            {
                this.cacheIdField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool dataOnRows
        {
            get
            {
                return this.dataOnRowsField;
            }
            set
            {
                this.dataOnRowsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint dataPosition
        {
            get
            {
                return this.dataPositionField;
            }
            set
            {
                this.dataPositionField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataPositionSpecified
        {
            get
            {
                return this.dataPositionFieldSpecified;
            }
            set
            {
                this.dataPositionFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint autoFormatId
        {
            get
            {
                return this.autoFormatIdField;
            }
            set
            {
                this.autoFormatIdField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autoFormatIdSpecified
        {
            get
            {
                return this.autoFormatIdFieldSpecified;
            }
            set
            {
                this.autoFormatIdFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool applyNumberFormats
        {
            get
            {
                return this.applyNumberFormatsField;
            }
            set
            {
                this.applyNumberFormatsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applyNumberFormatsSpecified
        {
            get
            {
                return this.applyNumberFormatsFieldSpecified;
            }
            set
            {
                this.applyNumberFormatsFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool applyBorderFormats
        {
            get
            {
                return this.applyBorderFormatsField;
            }
            set
            {
                this.applyBorderFormatsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applyBorderFormatsSpecified
        {
            get
            {
                return this.applyBorderFormatsFieldSpecified;
            }
            set
            {
                this.applyBorderFormatsFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool applyFontFormats
        {
            get
            {
                return this.applyFontFormatsField;
            }
            set
            {
                this.applyFontFormatsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applyFontFormatsSpecified
        {
            get
            {
                return this.applyFontFormatsFieldSpecified;
            }
            set
            {
                this.applyFontFormatsFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool applyPatternFormats
        {
            get
            {
                return this.applyPatternFormatsField;
            }
            set
            {
                this.applyPatternFormatsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applyPatternFormatsSpecified
        {
            get
            {
                return this.applyPatternFormatsFieldSpecified;
            }
            set
            {
                this.applyPatternFormatsFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool applyAlignmentFormats
        {
            get
            {
                return this.applyAlignmentFormatsField;
            }
            set
            {
                this.applyAlignmentFormatsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applyAlignmentFormatsSpecified
        {
            get
            {
                return this.applyAlignmentFormatsFieldSpecified;
            }
            set
            {
                this.applyAlignmentFormatsFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool applyWidthHeightFormats
        {
            get
            {
                return this.applyWidthHeightFormatsField;
            }
            set
            {
                this.applyWidthHeightFormatsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applyWidthHeightFormatsSpecified
        {
            get
            {
                return this.applyWidthHeightFormatsFieldSpecified;
            }
            set
            {
                this.applyWidthHeightFormatsFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dataCaption
        {
            get
            {
                return this.dataCaptionField;
            }
            set
            {
                this.dataCaptionField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string grandTotalCaption
        {
            get
            {
                return this.grandTotalCaptionField;
            }
            set
            {
                this.grandTotalCaptionField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string errorCaption
        {
            get
            {
                return this.errorCaptionField;
            }
            set
            {
                this.errorCaptionField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool showError
        {
            get
            {
                return this.showErrorField;
            }
            set
            {
                this.showErrorField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string missingCaption
        {
            get
            {
                return this.missingCaptionField;
            }
            set
            {
                this.missingCaptionField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool showMissing
        {
            get
            {
                return this.showMissingField;
            }
            set
            {
                this.showMissingField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pageStyle
        {
            get
            {
                return this.pageStyleField;
            }
            set
            {
                this.pageStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pivotTableStyle
        {
            get
            {
                return this.pivotTableStyleField;
            }
            set
            {
                this.pivotTableStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vacatedStyle
        {
            get
            {
                return this.vacatedStyleField;
            }
            set
            {
                this.vacatedStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tag
        {
            get
            {
                return this.tagField;
            }
            set
            {
                this.tagField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
        public byte updatedVersion
        {
            get
            {
                return this.updatedVersionField;
            }
            set
            {
                this.updatedVersionField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool asteriskTotals
        {
            get
            {
                return this.asteriskTotalsField;
            }
            set
            {
                this.asteriskTotalsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool showItems
        {
            get
            {
                return this.showItemsField;
            }
            set
            {
                this.showItemsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool editData
        {
            get
            {
                return this.editDataField;
            }
            set
            {
                this.editDataField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool disableFieldList
        {
            get
            {
                return this.disableFieldListField;
            }
            set
            {
                this.disableFieldListField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool showCalcMbrs
        {
            get
            {
                return this.showCalcMbrsField;
            }
            set
            {
                this.showCalcMbrsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool visualTotals
        {
            get
            {
                return this.visualTotalsField;
            }
            set
            {
                this.visualTotalsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool showMultipleLabel
        {
            get
            {
                return this.showMultipleLabelField;
            }
            set
            {
                this.showMultipleLabelField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool showDataDropDown
        {
            get
            {
                return this.showDataDropDownField;
            }
            set
            {
                this.showDataDropDownField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool showDrill
        {
            get
            {
                return this.showDrillField;
            }
            set
            {
                this.showDrillField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool printDrill
        {
            get
            {
                return this.printDrillField;
            }
            set
            {
                this.printDrillField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool showMemberPropertyTips
        {
            get
            {
                return this.showMemberPropertyTipsField;
            }
            set
            {
                this.showMemberPropertyTipsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool showDataTips
        {
            get
            {
                return this.showDataTipsField;
            }
            set
            {
                this.showDataTipsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool enableWizard
        {
            get
            {
                return this.enableWizardField;
            }
            set
            {
                this.enableWizardField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool enableDrill
        {
            get
            {
                return this.enableDrillField;
            }
            set
            {
                this.enableDrillField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool enableFieldProperties
        {
            get
            {
                return this.enableFieldPropertiesField;
            }
            set
            {
                this.enableFieldPropertiesField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool preserveFormatting
        {
            get
            {
                return this.preserveFormattingField;
            }
            set
            {
                this.preserveFormattingField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool useAutoFormatting
        {
            get
            {
                return this.useAutoFormattingField;
            }
            set
            {
                this.useAutoFormattingField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint pageWrap
        {
            get
            {
                return this.pageWrapField;
            }
            set
            {
                this.pageWrapField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool pageOverThenDown
        {
            get
            {
                return this.pageOverThenDownField;
            }
            set
            {
                this.pageOverThenDownField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool subtotalHiddenItems
        {
            get
            {
                return this.subtotalHiddenItemsField;
            }
            set
            {
                this.subtotalHiddenItemsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool rowGrandTotals
        {
            get
            {
                return this.rowGrandTotalsField;
            }
            set
            {
                this.rowGrandTotalsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool colGrandTotals
        {
            get
            {
                return this.colGrandTotalsField;
            }
            set
            {
                this.colGrandTotalsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool fieldPrintTitles
        {
            get
            {
                return this.fieldPrintTitlesField;
            }
            set
            {
                this.fieldPrintTitlesField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool itemPrintTitles
        {
            get
            {
                return this.itemPrintTitlesField;
            }
            set
            {
                this.itemPrintTitlesField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool mergeItem
        {
            get
            {
                return this.mergeItemField;
            }
            set
            {
                this.mergeItemField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool showDropZones
        {
            get
            {
                return this.showDropZonesField;
            }
            set
            {
                this.showDropZonesField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "1")]
        public uint indent
        {
            get
            {
                return this.indentField;
            }
            set
            {
                this.indentField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool showEmptyRow
        {
            get
            {
                return this.showEmptyRowField;
            }
            set
            {
                this.showEmptyRowField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool showEmptyCol
        {
            get
            {
                return this.showEmptyColField;
            }
            set
            {
                this.showEmptyColField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool showHeaders
        {
            get
            {
                return this.showHeadersField;
            }
            set
            {
                this.showHeadersField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool compact
        {
            get
            {
                return this.compactField;
            }
            set
            {
                this.compactField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool outline
        {
            get
            {
                return this.outlineField;
            }
            set
            {
                this.outlineField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool outlineData
        {
            get
            {
                return this.outlineDataField;
            }
            set
            {
                this.outlineDataField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool compactData
        {
            get
            {
                return this.compactDataField;
            }
            set
            {
                this.compactDataField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool gridDropZones
        {
            get
            {
                return this.gridDropZonesField;
            }
            set
            {
                this.gridDropZonesField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool immersive
        {
            get
            {
                return this.immersiveField;
            }
            set
            {
                this.immersiveField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool multipleFieldFilters
        {
            get
            {
                return this.multipleFieldFiltersField;
            }
            set
            {
                this.multipleFieldFiltersField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint chartFormat
        {
            get
            {
                return this.chartFormatField;
            }
            set
            {
                this.chartFormatField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rowHeaderCaption
        {
            get
            {
                return this.rowHeaderCaptionField;
            }
            set
            {
                this.rowHeaderCaptionField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string colHeaderCaption
        {
            get
            {
                return this.colHeaderCaptionField;
            }
            set
            {
                this.colHeaderCaptionField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool fieldListSortAscending
        {
            get
            {
                return this.fieldListSortAscendingField;
            }
            set
            {
                this.fieldListSortAscendingField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool mdxSubqueries
        {
            get
            {
                return this.mdxSubqueriesField;
            }
            set
            {
                this.mdxSubqueriesField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool customListSort
        {
            get
            {
                return this.customListSortField;
            }
            set
            {
                this.customListSortField = value;
            }
        }


        public CT_PivotTableStyle AddNewPivotTableStyleInfo()
        {
            this.pivotTableStyleInfoField = new CT_PivotTableStyle();
            return this.pivotTableStyleInfoField;
        }

        public CT_RowFields AddNewRowFields()
        {
            this.rowFieldsField = new CT_RowFields();
            return this.rowFieldsField;
        }

        public CT_ColFields AddNewColFields()
        {
            this.colFieldsField = new CT_ColFields();
            return this.colFieldsField;
        }

        public CT_DataFields AddNewDataFields()
        {
            this.dataFieldsField = new CT_DataFields();
            return this.dataFieldsField;
        }

        public CT_PageFields AddNewPageFields()
        {
            this.pageFieldsField = new CT_PageFields();
            return this.pageFieldsField;
        }

        public CT_PivotFields AddNewPivotFields()
        {
            this.pivotFieldsField = new CT_PivotFields();
            return this.pivotFieldsField;
        }

        public CT_Location AddNewLocation()
        {
            this.locationField = new CT_Location();
            return this.locationField;
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Location
    {
        public static CT_Location Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Location ctObj = new CT_Location();
            ctObj.@ref = XmlHelper.ReadString(node.Attribute("ref"));
            if (node.Attribute("firstHeaderRow") != null)
                ctObj.firstHeaderRow = XmlHelper.ReadUInt(node.Attribute("firstHeaderRow"));
            if (node.Attribute("firstDataRow") != null)
                ctObj.firstDataRow = XmlHelper.ReadUInt(node.Attribute("firstDataRow"));
            if (node.Attribute("firstDataCol") != null)
                ctObj.firstDataCol = XmlHelper.ReadUInt(node.Attribute("firstDataCol"));
            if (node.Attribute("rowPageCount") != null)
                ctObj.rowPageCount = XmlHelper.ReadUInt(node.Attribute("rowPageCount"));
            if (node.Attribute("colPageCount") != null)
                ctObj.colPageCount = XmlHelper.ReadUInt(node.Attribute("colPageCount"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "ref", this.@ref);
            XmlHelper.WriteAttribute(sw, "firstHeaderRow", this.firstHeaderRow);
            XmlHelper.WriteAttribute(sw, "firstDataRow", this.firstDataRow);
            XmlHelper.WriteAttribute(sw, "firstDataCol", this.firstDataCol);
            XmlHelper.WriteAttribute(sw, "rowPageCount", this.rowPageCount);
            XmlHelper.WriteAttribute(sw, "colPageCount", this.colPageCount);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private string refField;

        private uint firstHeaderRowField;

        private uint firstDataRowField;

        private uint firstDataColField;

        private uint rowPageCountField;

        private uint colPageCountField;

        public CT_Location()
        {
            this.rowPageCountField = ((uint)(0));
            this.colPageCountField = ((uint)(0));
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint firstHeaderRow
        {
            get
            {
                return this.firstHeaderRowField;
            }
            set
            {
                this.firstHeaderRowField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint firstDataRow
        {
            get
            {
                return this.firstDataRowField;
            }
            set
            {
                this.firstDataRowField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint firstDataCol
        {
            get
            {
                return this.firstDataColField;
            }
            set
            {
                this.firstDataColField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint rowPageCount
        {
            get
            {
                return this.rowPageCountField;
            }
            set
            {
                this.rowPageCountField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint colPageCount
        {
            get
            {
                return this.colPageCountField;
            }
            set
            {
                this.colPageCountField = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_PivotFields
    {
        public static CT_PivotFields Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PivotFields ctObj = new CT_PivotFields();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.pivotField = new List<CT_PivotField>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "pivotField")
                    ctObj.pivotField.Add(CT_PivotField.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.pivotField != null)
            {
                foreach (CT_PivotField x in this.pivotField)
                {
                    x.Write(sw, "pivotField");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_PivotField> pivotFieldField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_PivotFields()
        {
            this.pivotFieldField = new List<CT_PivotField>();
        }

        [System.Xml.Serialization.XmlElementAttribute("pivotField", Order = 0)]
        public List<CT_PivotField> pivotField
        {
            get
            {
                return this.pivotFieldField;
            }
            set
            {
                this.pivotFieldField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        public void SetPivotFieldArray(int columnIndex, CT_PivotField pivotField)
        {
            this.pivotFieldField[columnIndex] = pivotField;
        }

        public CT_PivotField AddNewPivotField()
        {
            if (this.pivotFieldField == null)
                this.pivotFieldField = new List<CT_PivotField>();
            CT_PivotField f = new CT_PivotField();
            this.pivotFieldField.Add(f);
            return f;
        }

        public uint SizeOfPivotFieldArray()
        {
            if (this.pivotFieldField == null)
                this.pivotFieldField = new List<CT_PivotField>();
            return (uint)this.pivotFieldField.Count;
        }

        public CT_PivotField GetPivotFieldArray(int columnIndex)
        {
            if (this.pivotFieldField == null)
                this.pivotFieldField = new List<CT_PivotField>();
            return this.pivotFieldField[columnIndex];
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_PivotField
    {
        public static CT_PivotField Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PivotField ctObj = new CT_PivotField();
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            if (node.Attribute("axis") != null)
                ctObj.axis = (ST_Axis)Enum.Parse(typeof(ST_Axis), node.Attribute("axis").Value);
            if (node.Attribute("dataField") != null)
                ctObj.dataField = XmlHelper.ReadBool(node.Attribute("dataField"));
            ctObj.subtotalCaption = XmlHelper.ReadString(node.Attribute("subtotalCaption"));
            if (node.Attribute("showDropDowns") != null)
                ctObj.showDropDowns = XmlHelper.ReadBool(node.Attribute("showDropDowns"));
            if (node.Attribute("hiddenLevel") != null)
                ctObj.hiddenLevel = XmlHelper.ReadBool(node.Attribute("hiddenLevel"));
            ctObj.uniqueMemberProperty = XmlHelper.ReadString(node.Attribute("uniqueMemberProperty"));
            if (node.Attribute("compact") != null)
                ctObj.compact = XmlHelper.ReadBool(node.Attribute("compact"));
            if (node.Attribute("allDrilled") != null)
                ctObj.allDrilled = XmlHelper.ReadBool(node.Attribute("allDrilled"));
            if (node.Attribute("numFmtId") != null)
                ctObj.numFmtId = XmlHelper.ReadUInt(node.Attribute("numFmtId"));
            if (node.Attribute("outline") != null)
                ctObj.outline = XmlHelper.ReadBool(node.Attribute("outline"));
            if (node.Attribute("subtotalTop") != null)
                ctObj.subtotalTop = XmlHelper.ReadBool(node.Attribute("subtotalTop"));
            if (node.Attribute("dragToRow") != null)
                ctObj.dragToRow = XmlHelper.ReadBool(node.Attribute("dragToRow"));
            if (node.Attribute("dragToCol") != null)
                ctObj.dragToCol = XmlHelper.ReadBool(node.Attribute("dragToCol"));
            if (node.Attribute("multipleItemSelectionAllowed") != null)
                ctObj.multipleItemSelectionAllowed = XmlHelper.ReadBool(node.Attribute("multipleItemSelectionAllowed"));
            if (node.Attribute("dragToPage") != null)
                ctObj.dragToPage = XmlHelper.ReadBool(node.Attribute("dragToPage"));
            if (node.Attribute("dragToData") != null)
                ctObj.dragToData = XmlHelper.ReadBool(node.Attribute("dragToData"));
            if (node.Attribute("dragOff") != null)
                ctObj.dragOff = XmlHelper.ReadBool(node.Attribute("dragOff"));
            if (node.Attribute("showAll") != null)
                ctObj.showAll = XmlHelper.ReadBool(node.Attribute("showAll"));
            if (node.Attribute("insertBlankRow") != null)
                ctObj.insertBlankRow = XmlHelper.ReadBool(node.Attribute("insertBlankRow"));
            if (node.Attribute("serverField") != null)
                ctObj.serverField = XmlHelper.ReadBool(node.Attribute("serverField"));
            if (node.Attribute("insertPageBreak") != null)
                ctObj.insertPageBreak = XmlHelper.ReadBool(node.Attribute("insertPageBreak"));
            if (node.Attribute("autoShow") != null)
                ctObj.autoShow = XmlHelper.ReadBool(node.Attribute("autoShow"));
            if (node.Attribute("topAutoShow") != null)
                ctObj.topAutoShow = XmlHelper.ReadBool(node.Attribute("topAutoShow"));
            if (node.Attribute("hideNewItems") != null)
                ctObj.hideNewItems = XmlHelper.ReadBool(node.Attribute("hideNewItems"));
            if (node.Attribute("measureFilter") != null)
                ctObj.measureFilter = XmlHelper.ReadBool(node.Attribute("measureFilter"));
            if (node.Attribute("includeNewItemsInFilter") != null)
                ctObj.includeNewItemsInFilter = XmlHelper.ReadBool(node.Attribute("includeNewItemsInFilter"));
            if (node.Attribute("itemPageCount") != null)
                ctObj.itemPageCount = XmlHelper.ReadUInt(node.Attribute("itemPageCount"));
            if (node.Attribute("sortType") != null)
                ctObj.sortType = (ST_FieldSortType)Enum.Parse(typeof(ST_FieldSortType), node.Attribute("sortType").Value);
            if (node.Attribute("dataSourceSort") != null)
                ctObj.dataSourceSort = XmlHelper.ReadBool(node.Attribute("dataSourceSort"));
            if (node.Attribute("nonAutoSortDefault") != null)
                ctObj.nonAutoSortDefault = XmlHelper.ReadBool(node.Attribute("nonAutoSortDefault"));
            if (node.Attribute("rankBy") != null)
                ctObj.rankBy = XmlHelper.ReadUInt(node.Attribute("rankBy"));
            if (node.Attribute("defaultSubtotal") != null)
                ctObj.defaultSubtotal = XmlHelper.ReadBool(node.Attribute("defaultSubtotal"));
            if (node.Attribute("sumSubtotal") != null)
                ctObj.sumSubtotal = XmlHelper.ReadBool(node.Attribute("sumSubtotal"));
            if (node.Attribute("countASubtotal") != null)
                ctObj.countASubtotal = XmlHelper.ReadBool(node.Attribute("countASubtotal"));
            if (node.Attribute("avgSubtotal") != null)
                ctObj.avgSubtotal = XmlHelper.ReadBool(node.Attribute("avgSubtotal"));
            if (node.Attribute("maxSubtotal") != null)
                ctObj.maxSubtotal = XmlHelper.ReadBool(node.Attribute("maxSubtotal"));
            if (node.Attribute("minSubtotal") != null)
                ctObj.minSubtotal = XmlHelper.ReadBool(node.Attribute("minSubtotal"));
            if (node.Attribute("productSubtotal") != null)
                ctObj.productSubtotal = XmlHelper.ReadBool(node.Attribute("productSubtotal"));
            if (node.Attribute("countSubtotal") != null)
                ctObj.countSubtotal = XmlHelper.ReadBool(node.Attribute("countSubtotal"));
            if (node.Attribute("stdDevSubtotal") != null)
                ctObj.stdDevSubtotal = XmlHelper.ReadBool(node.Attribute("stdDevSubtotal"));
            if (node.Attribute("stdDevPSubtotal") != null)
                ctObj.stdDevPSubtotal = XmlHelper.ReadBool(node.Attribute("stdDevPSubtotal"));
            if (node.Attribute("varSubtotal") != null)
                ctObj.varSubtotal = XmlHelper.ReadBool(node.Attribute("varSubtotal"));
            if (node.Attribute("varPSubtotal") != null)
                ctObj.varPSubtotal = XmlHelper.ReadBool(node.Attribute("varPSubtotal"));
            if (node.Attribute("showPropCell") != null)
                ctObj.showPropCell = XmlHelper.ReadBool(node.Attribute("showPropCell"));
            if (node.Attribute("showPropTip") != null)
                ctObj.showPropTip = XmlHelper.ReadBool(node.Attribute("showPropTip"));
            if (node.Attribute("showPropAsCaption") != null)
                ctObj.showPropAsCaption = XmlHelper.ReadBool(node.Attribute("showPropAsCaption"));
            if (node.Attribute("defaultAttributeDrillState") != null)
                ctObj.defaultAttributeDrillState = XmlHelper.ReadBool(node.Attribute("defaultAttributeDrillState"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "items")
                    ctObj.items = CT_Items.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "autoSortScope")
                    ctObj.autoSortScope = CT_AutoSortScope.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "axis", this.axis.ToString());
            XmlHelper.WriteAttribute(sw, "dataField", this.dataField);
            XmlHelper.WriteAttribute(sw, "subtotalCaption", this.subtotalCaption);
            XmlHelper.WriteAttribute(sw, "showDropDowns", this.showDropDowns);
            XmlHelper.WriteAttribute(sw, "hiddenLevel", this.hiddenLevel);
            XmlHelper.WriteAttribute(sw, "uniqueMemberProperty", this.uniqueMemberProperty);
            XmlHelper.WriteAttribute(sw, "compact", this.compact);
            XmlHelper.WriteAttribute(sw, "allDrilled", this.allDrilled);
            XmlHelper.WriteAttribute(sw, "numFmtId", this.numFmtId);
            XmlHelper.WriteAttribute(sw, "outline", this.outline);
            XmlHelper.WriteAttribute(sw, "subtotalTop", this.subtotalTop);
            XmlHelper.WriteAttribute(sw, "dragToRow", this.dragToRow);
            XmlHelper.WriteAttribute(sw, "dragToCol", this.dragToCol);
            XmlHelper.WriteAttribute(sw, "multipleItemSelectionAllowed", this.multipleItemSelectionAllowed);
            XmlHelper.WriteAttribute(sw, "dragToPage", this.dragToPage);
            XmlHelper.WriteAttribute(sw, "dragToData", this.dragToData);
            XmlHelper.WriteAttribute(sw, "dragOff", this.dragOff);
            XmlHelper.WriteAttribute(sw, "showAll", this.showAll);
            XmlHelper.WriteAttribute(sw, "insertBlankRow", this.insertBlankRow);
            XmlHelper.WriteAttribute(sw, "serverField", this.serverField);
            XmlHelper.WriteAttribute(sw, "insertPageBreak", this.insertPageBreak);
            XmlHelper.WriteAttribute(sw, "autoShow", this.autoShow);
            XmlHelper.WriteAttribute(sw, "topAutoShow", this.topAutoShow);
            XmlHelper.WriteAttribute(sw, "hideNewItems", this.hideNewItems);
            XmlHelper.WriteAttribute(sw, "measureFilter", this.measureFilter);
            XmlHelper.WriteAttribute(sw, "includeNewItemsInFilter", this.includeNewItemsInFilter);
            XmlHelper.WriteAttribute(sw, "itemPageCount", this.itemPageCount);
            XmlHelper.WriteAttribute(sw, "sortType", this.sortType.ToString());
            XmlHelper.WriteAttribute(sw, "dataSourceSort", this.dataSourceSort);
            XmlHelper.WriteAttribute(sw, "nonAutoSortDefault", this.nonAutoSortDefault);
            XmlHelper.WriteAttribute(sw, "rankBy", this.rankBy);
            XmlHelper.WriteAttribute(sw, "defaultSubtotal", this.defaultSubtotal);
            XmlHelper.WriteAttribute(sw, "sumSubtotal", this.sumSubtotal);
            XmlHelper.WriteAttribute(sw, "countASubtotal", this.countASubtotal);
            XmlHelper.WriteAttribute(sw, "avgSubtotal", this.avgSubtotal);
            XmlHelper.WriteAttribute(sw, "maxSubtotal", this.maxSubtotal);
            XmlHelper.WriteAttribute(sw, "minSubtotal", this.minSubtotal);
            XmlHelper.WriteAttribute(sw, "productSubtotal", this.productSubtotal);
            XmlHelper.WriteAttribute(sw, "countSubtotal", this.countSubtotal);
            XmlHelper.WriteAttribute(sw, "stdDevSubtotal", this.stdDevSubtotal);
            XmlHelper.WriteAttribute(sw, "stdDevPSubtotal", this.stdDevPSubtotal);
            XmlHelper.WriteAttribute(sw, "varSubtotal", this.varSubtotal);
            XmlHelper.WriteAttribute(sw, "varPSubtotal", this.varPSubtotal);
            XmlHelper.WriteAttribute(sw, "showPropCell", this.showPropCell);
            XmlHelper.WriteAttribute(sw, "showPropTip", this.showPropTip);
            XmlHelper.WriteAttribute(sw, "showPropAsCaption", this.showPropAsCaption);
            XmlHelper.WriteAttribute(sw, "defaultAttributeDrillState", this.defaultAttributeDrillState);
            sw.Write(">");
            if (this.items != null)
                this.items.Write(sw, "items");
            if (this.autoSortScope != null)
                this.autoSortScope.Write(sw, "autoSortScope");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_Items itemsField;

        private CT_AutoSortScope autoSortScopeField;

        private CT_ExtensionList extLstField;

        private string nameField;

        private ST_Axis axisField;

        private bool axisFieldSpecified;

        private bool dataFieldField;

        private string subtotalCaptionField;

        private bool showDropDownsField;

        private bool hiddenLevelField;

        private string uniqueMemberPropertyField;

        private bool compactField;

        private bool allDrilledField;

        private uint numFmtIdField;

        private bool numFmtIdFieldSpecified;

        private bool outlineField;

        private bool subtotalTopField;

        private bool dragToRowField;

        private bool dragToColField;

        private bool multipleItemSelectionAllowedField;

        private bool dragToPageField;

        private bool dragToDataField;

        private bool dragOffField;

        private bool showAllField;

        private bool insertBlankRowField;

        private bool serverFieldField;

        private bool insertPageBreakField;

        private bool autoShowField;

        private bool topAutoShowField;

        private bool hideNewItemsField;

        private bool measureFilterField;

        private bool includeNewItemsInFilterField;

        private uint itemPageCountField;

        private ST_FieldSortType sortTypeField;

        private bool dataSourceSortField;

        private bool dataSourceSortFieldSpecified;

        private bool nonAutoSortDefaultField;

        private uint rankByField;

        private bool rankByFieldSpecified;

        private bool defaultSubtotalField;

        private bool sumSubtotalField;

        private bool countASubtotalField;

        private bool avgSubtotalField;

        private bool maxSubtotalField;

        private bool minSubtotalField;

        private bool productSubtotalField;

        private bool countSubtotalField;

        private bool stdDevSubtotalField;

        private bool stdDevPSubtotalField;

        private bool varSubtotalField;

        private bool varPSubtotalField;

        private bool showPropCellField;

        private bool showPropTipField;

        private bool showPropAsCaptionField;

        private bool defaultAttributeDrillStateField;

        public CT_PivotField()
        {
            this.extLstField = new CT_ExtensionList();
            this.autoSortScopeField = new CT_AutoSortScope();
            this.itemsField = new CT_Items();
            this.dataFieldField = false;
            this.showDropDownsField = true;
            this.hiddenLevelField = false;
            this.compactField = true;
            this.allDrilledField = false;
            this.outlineField = true;
            this.subtotalTopField = true;
            this.dragToRowField = true;
            this.dragToColField = true;
            this.multipleItemSelectionAllowedField = false;
            this.dragToPageField = true;
            this.dragToDataField = true;
            this.dragOffField = true;
            this.showAllField = true;
            this.insertBlankRowField = false;
            this.serverFieldField = false;
            this.insertPageBreakField = false;
            this.autoShowField = false;
            this.topAutoShowField = true;
            this.hideNewItemsField = false;
            this.measureFilterField = false;
            this.includeNewItemsInFilterField = false;
            this.itemPageCountField = ((uint)(10));
            this.sortTypeField = ST_FieldSortType.manual;
            this.nonAutoSortDefaultField = false;
            this.defaultSubtotalField = true;
            this.sumSubtotalField = false;
            this.countASubtotalField = false;
            this.avgSubtotalField = false;
            this.maxSubtotalField = false;
            this.minSubtotalField = false;
            this.productSubtotalField = false;
            this.countSubtotalField = false;
            this.stdDevSubtotalField = false;
            this.stdDevPSubtotalField = false;
            this.varSubtotalField = false;
            this.varPSubtotalField = false;
            this.showPropCellField = false;
            this.showPropTipField = false;
            this.showPropAsCaptionField = false;
            this.defaultAttributeDrillStateField = false;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CT_Items items
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

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CT_AutoSortScope autoSortScope
        {
            get
            {
                return this.autoSortScopeField;
            }
            set
            {
                this.autoSortScopeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ST_Axis axis
        {
            get
            {
                return this.axisField;
            }
            set
            {
                this.axisField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool axisSpecified
        {
            get
            {
                return this.axisFieldSpecified;
            }
            set
            {
                this.axisFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool dataField
        {
            get
            {
                return this.dataFieldField;
            }
            set
            {
                this.dataFieldField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string subtotalCaption
        {
            get
            {
                return this.subtotalCaptionField;
            }
            set
            {
                this.subtotalCaptionField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool showDropDowns
        {
            get
            {
                return this.showDropDownsField;
            }
            set
            {
                this.showDropDownsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool hiddenLevel
        {
            get
            {
                return this.hiddenLevelField;
            }
            set
            {
                this.hiddenLevelField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uniqueMemberProperty
        {
            get
            {
                return this.uniqueMemberPropertyField;
            }
            set
            {
                this.uniqueMemberPropertyField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool compact
        {
            get
            {
                return this.compactField;
            }
            set
            {
                this.compactField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool allDrilled
        {
            get
            {
                return this.allDrilledField;
            }
            set
            {
                this.allDrilledField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool outline
        {
            get
            {
                return this.outlineField;
            }
            set
            {
                this.outlineField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool subtotalTop
        {
            get
            {
                return this.subtotalTopField;
            }
            set
            {
                this.subtotalTopField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool dragToRow
        {
            get
            {
                return this.dragToRowField;
            }
            set
            {
                this.dragToRowField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool dragToCol
        {
            get
            {
                return this.dragToColField;
            }
            set
            {
                this.dragToColField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool multipleItemSelectionAllowed
        {
            get
            {
                return this.multipleItemSelectionAllowedField;
            }
            set
            {
                this.multipleItemSelectionAllowedField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool dragToPage
        {
            get
            {
                return this.dragToPageField;
            }
            set
            {
                this.dragToPageField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool dragToData
        {
            get
            {
                return this.dragToDataField;
            }
            set
            {
                this.dragToDataField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool dragOff
        {
            get
            {
                return this.dragOffField;
            }
            set
            {
                this.dragOffField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool showAll
        {
            get
            {
                return this.showAllField;
            }
            set
            {
                this.showAllField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool insertBlankRow
        {
            get
            {
                return this.insertBlankRowField;
            }
            set
            {
                this.insertBlankRowField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool insertPageBreak
        {
            get
            {
                return this.insertPageBreakField;
            }
            set
            {
                this.insertPageBreakField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool autoShow
        {
            get
            {
                return this.autoShowField;
            }
            set
            {
                this.autoShowField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool topAutoShow
        {
            get
            {
                return this.topAutoShowField;
            }
            set
            {
                this.topAutoShowField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool hideNewItems
        {
            get
            {
                return this.hideNewItemsField;
            }
            set
            {
                this.hideNewItemsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool measureFilter
        {
            get
            {
                return this.measureFilterField;
            }
            set
            {
                this.measureFilterField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool includeNewItemsInFilter
        {
            get
            {
                return this.includeNewItemsInFilterField;
            }
            set
            {
                this.includeNewItemsInFilterField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "10")]
        public uint itemPageCount
        {
            get
            {
                return this.itemPageCountField;
            }
            set
            {
                this.itemPageCountField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ST_FieldSortType.manual)]
        public ST_FieldSortType sortType
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool dataSourceSort
        {
            get
            {
                return this.dataSourceSortField;
            }
            set
            {
                this.dataSourceSortField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dataSourceSortSpecified
        {
            get
            {
                return this.dataSourceSortFieldSpecified;
            }
            set
            {
                this.dataSourceSortFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool nonAutoSortDefault
        {
            get
            {
                return this.nonAutoSortDefaultField;
            }
            set
            {
                this.nonAutoSortDefaultField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint rankBy
        {
            get
            {
                return this.rankByField;
            }
            set
            {
                this.rankByField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rankBySpecified
        {
            get
            {
                return this.rankByFieldSpecified;
            }
            set
            {
                this.rankByFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool defaultSubtotal
        {
            get
            {
                return this.defaultSubtotalField;
            }
            set
            {
                this.defaultSubtotalField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool sumSubtotal
        {
            get
            {
                return this.sumSubtotalField;
            }
            set
            {
                this.sumSubtotalField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool countASubtotal
        {
            get
            {
                return this.countASubtotalField;
            }
            set
            {
                this.countASubtotalField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool avgSubtotal
        {
            get
            {
                return this.avgSubtotalField;
            }
            set
            {
                this.avgSubtotalField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool maxSubtotal
        {
            get
            {
                return this.maxSubtotalField;
            }
            set
            {
                this.maxSubtotalField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool minSubtotal
        {
            get
            {
                return this.minSubtotalField;
            }
            set
            {
                this.minSubtotalField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool productSubtotal
        {
            get
            {
                return this.productSubtotalField;
            }
            set
            {
                this.productSubtotalField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool countSubtotal
        {
            get
            {
                return this.countSubtotalField;
            }
            set
            {
                this.countSubtotalField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool stdDevSubtotal
        {
            get
            {
                return this.stdDevSubtotalField;
            }
            set
            {
                this.stdDevSubtotalField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool stdDevPSubtotal
        {
            get
            {
                return this.stdDevPSubtotalField;
            }
            set
            {
                this.stdDevPSubtotalField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool varSubtotal
        {
            get
            {
                return this.varSubtotalField;
            }
            set
            {
                this.varSubtotalField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool varPSubtotal
        {
            get
            {
                return this.varPSubtotalField;
            }
            set
            {
                this.varPSubtotalField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool showPropCell
        {
            get
            {
                return this.showPropCellField;
            }
            set
            {
                this.showPropCellField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool showPropTip
        {
            get
            {
                return this.showPropTipField;
            }
            set
            {
                this.showPropTipField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool showPropAsCaption
        {
            get
            {
                return this.showPropAsCaptionField;
            }
            set
            {
                this.showPropAsCaptionField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool defaultAttributeDrillState
        {
            get
            {
                return this.defaultAttributeDrillStateField;
            }
            set
            {
                this.defaultAttributeDrillStateField = value;
            }
        }

        public CT_Items AddNewItems()
        {
            this.itemsField = new CT_Items();
            return this.itemsField;
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Items
    {
        public static CT_Items Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Items ctObj = new CT_Items();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.item = new List<CT_Item>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "item")
                    ctObj.item.Add(CT_Item.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.item != null)
            {
                foreach (CT_Item x in this.item)
                {
                    x.Write(sw, "item");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_Item> itemField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_Items()
        {
            this.itemField = new List<CT_Item>();
        }

        [System.Xml.Serialization.XmlElementAttribute("item", Order = 0)]
        public List<CT_Item> item
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        public CT_Item AddNewItem()
        {
            if (this.itemField == null)
                this.itemField = new List<CT_Item>();
            CT_Item i = new CT_Item();
            this.itemField.Add(i);
            return i;
        }

        public uint SizeOfItemArray()
        {
            if (this.itemField == null)
                this.itemField = new List<CT_Item>();
            return (uint)this.itemField.Count;
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Item
    {
        public static CT_Item Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Item ctObj = new CT_Item();
            ctObj.n = XmlHelper.ReadString(node.Attribute("n"));
            if (node.Attribute("t") != null)
                ctObj.t = (ST_ItemType)Enum.Parse(typeof(ST_ItemType), node.Attribute("t").Value);
            if (node.Attribute("h") != null)
                ctObj.h = XmlHelper.ReadBool(node.Attribute("h"));
            if (node.Attribute("s") != null)
                ctObj.s = XmlHelper.ReadBool(node.Attribute("s"));
            if (node.Attribute("sd") != null)
                ctObj.sd = XmlHelper.ReadBool(node.Attribute("sd"));
            if (node.Attribute("f") != null)
                ctObj.f = XmlHelper.ReadBool(node.Attribute("f"));
            if (node.Attribute("m") != null)
                ctObj.m = XmlHelper.ReadBool(node.Attribute("m"));
            if (node.Attribute("c") != null)
                ctObj.c = XmlHelper.ReadBool(node.Attribute("c"));
            if (node.Attribute("x") != null)
                ctObj.x = XmlHelper.ReadUInt(node.Attribute("x"));
            if (node.Attribute("d") != null)
                ctObj.d = XmlHelper.ReadBool(node.Attribute("d"));
            if (node.Attribute("e") != null)
                ctObj.e = XmlHelper.ReadBool(node.Attribute("e"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "n", this.n);
            XmlHelper.WriteAttribute(sw, "t", this.t.ToString());
            XmlHelper.WriteAttribute(sw, "h", this.h);
            XmlHelper.WriteAttribute(sw, "s", this.s);
            XmlHelper.WriteAttribute(sw, "sd", this.sd);
            XmlHelper.WriteAttribute(sw, "f", this.f);
            XmlHelper.WriteAttribute(sw, "m", this.m);
            XmlHelper.WriteAttribute(sw, "c", this.c);
            XmlHelper.WriteAttribute(sw, "x", this.x);
            XmlHelper.WriteAttribute(sw, "d", this.d);
            XmlHelper.WriteAttribute(sw, "e", this.e);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private string nField;

        private ST_ItemType tField;

        private bool hField;

        private bool sField;

        private bool sdField;

        private bool fField;

        private bool mField;

        private bool cField;

        private uint xField;

        private bool xFieldSpecified;

        private bool dField;

        private bool eField;

        public CT_Item()
        {
            this.tField = ST_ItemType.data;
            this.hField = false;
            this.sField = false;
            this.sdField = true;
            this.fField = false;
            this.mField = false;
            this.cField = false;
            this.dField = false;
            this.eField = true;
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string n
        {
            get
            {
                return this.nField;
            }
            set
            {
                this.nField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ST_ItemType.data)]
        public ST_ItemType t
        {
            get
            {
                return this.tField;
            }
            set
            {
                this.tField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool h
        {
            get
            {
                return this.hField;
            }
            set
            {
                this.hField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool s
        {
            get
            {
                return this.sField;
            }
            set
            {
                this.sField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool sd
        {
            get
            {
                return this.sdField;
            }
            set
            {
                this.sdField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool m
        {
            get
            {
                return this.mField;
            }
            set
            {
                this.mField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool c
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint x
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xSpecified
        {
            get
            {
                return this.xFieldSpecified;
            }
            set
            {
                this.xFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool d
        {
            get
            {
                return this.dField;
            }
            set
            {
                this.dField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool e
        {
            get
            {
                return this.eField;
            }
            set
            {
                this.eField = value;
            }
        }
    }

    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
    public enum ST_ItemType
    {

        /// <remarks/>
        data,

        /// <remarks/>
        @default,

        /// <remarks/>
        sum,

        /// <remarks/>
        countA,

        /// <remarks/>
        avg,

        /// <remarks/>
        max,

        /// <remarks/>
        min,

        /// <remarks/>
        product,

        /// <remarks/>
        count,

        /// <remarks/>
        stdDev,

        /// <remarks/>
        stdDevP,

        /// <remarks/>
        var,

        /// <remarks/>
        varP,

        /// <remarks/>
        grand,

        /// <remarks/>
        blank,
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_AutoSortScope
    {
        public static CT_AutoSortScope Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_AutoSortScope ctObj = new CT_AutoSortScope();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "pivotArea")
                    ctObj.pivotArea = CT_PivotArea.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            sw.Write(">");
            if (this.pivotArea != null)
                this.pivotArea.Write(sw, "pivotArea");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_PivotArea pivotAreaField;

        public CT_AutoSortScope()
        {
            this.pivotAreaField = new CT_PivotArea();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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
    }

    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
    public enum ST_FieldSortType
    {

        /// <remarks/>
        manual,

        /// <remarks/>
        ascending,

        /// <remarks/>
        descending,
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_RowFields
    {
        public static CT_RowFields Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_RowFields ctObj = new CT_RowFields();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.field = new List<CT_Field>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "field")
                    ctObj.field.Add(CT_Field.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.field != null)
            {
                foreach (CT_Field x in this.field)
                {
                    x.Write(sw, "field");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_Field> fieldField;

        private uint countField;

        public CT_RowFields()
        {
            this.fieldField = new List<CT_Field>();
            this.countField = ((uint)(0));
        }

        [System.Xml.Serialization.XmlElementAttribute("field", Order = 0)]
        public List<CT_Field> field
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
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

        public CT_Field AddNewField()
        {
            CT_Field f = new CT_Field();
            this.fieldField.Add(f);
            return f;
        }

        public uint SizeOfFieldArray()
        {
            return (uint)this.fieldField.Count;
        }

        public List<CT_Field> GetFieldArray()
        {
            return this.fieldField;
        }

        public CT_Field GetFieldArray(int p)
        {
            return this.fieldField[p];
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Field
    {
        public static CT_Field Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Field ctObj = new CT_Field();
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class CT_rowItems
    {
        public static CT_rowItems Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_rowItems ctObj = new CT_rowItems();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.i = new List<CT_I>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "i")
                    ctObj.i.Add(CT_I.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.i != null)
            {
                foreach (CT_I x in this.i)
                {
                    x.Write(sw, "i");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_I> iField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_rowItems()
        {
            this.iField = new List<CT_I>();
        }

        [System.Xml.Serialization.XmlElementAttribute("i", Order = 0)]
        public List<CT_I> i
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class CT_I
    {
        public static CT_I Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_I ctObj = new CT_I();
            if (node.Attribute("t") != null)
                ctObj.t = (ST_ItemType)Enum.Parse(typeof(ST_ItemType), node.Attribute("t").Value);
            if (node.Attribute("r") != null)
                ctObj.r = XmlHelper.ReadUInt(node.Attribute("r"));
            if (node.Attribute("i") != null)
                ctObj.i = XmlHelper.ReadUInt(node.Attribute("i"));
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
            XmlHelper.WriteAttribute(sw, "t", this.t.ToString());
            XmlHelper.WriteAttribute(sw, "r", this.r);
            XmlHelper.WriteAttribute(sw, "i", this.i);
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

        private ST_ItemType tField;

        private uint rField;

        private uint iField;

        public CT_I()
        {
            this.xField = new List<CT_X>();
            this.tField = ST_ItemType.data;
            this.rField = ((uint)(0));
            this.iField = ((uint)(0));
        }

        [System.Xml.Serialization.XmlElementAttribute("x", Order = 0)]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ST_ItemType.data)]
        public ST_ItemType t
        {
            get
            {
                return this.tField;
            }
            set
            {
                this.tField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint i
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
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_ColFields
    {
        public static CT_ColFields Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_ColFields ctObj = new CT_ColFields();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.field = new List<CT_Field>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "field")
                    ctObj.field.Add(CT_Field.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.field != null)
            {
                foreach (CT_Field x in this.field)
                {
                    x.Write(sw, "field");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_Field> fieldField;

        private uint countField;

        public CT_ColFields()
        {
            this.fieldField = new List<CT_Field>();
            this.countField = ((uint)(0));
        }

        [System.Xml.Serialization.XmlElementAttribute("field", Order = 0)]
        public List<CT_Field> field
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
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

        public uint SizeOfFieldArray()
        {
            if (this.fieldField == null)
                this.fieldField = new List<CT_Field>();
            return (uint)this.fieldField.Count;
        }

        public CT_Field AddNewField()
        {
            if (this.fieldField == null)
                this.fieldField = new List<CT_Field>();
            CT_Field f = new CT_Field();
            this.fieldField.Add(f);
            return f;
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_colItems
    {
        public static CT_colItems Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_colItems ctObj = new CT_colItems();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.i = new List<CT_I>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "i")
                    ctObj.i.Add(CT_I.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.i != null)
            {
                foreach (CT_I x in this.i)
                {
                    x.Write(sw, "i");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_I> iField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_colItems()
        {
            this.iField = new List<CT_I>();
        }

        [System.Xml.Serialization.XmlElementAttribute("i", Order = 0)]
        public List<CT_I> i
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class CT_PageFields
    {
        public static CT_PageFields Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PageFields ctObj = new CT_PageFields();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.pageField = new List<CT_PageField>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "pageField")
                    ctObj.pageField.Add(CT_PageField.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.pageField != null)
            {
                foreach (CT_PageField x in this.pageField)
                {
                    x.Write(sw, "pageField");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_PageField> pageFieldField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_PageFields()
        {
            this.pageFieldField = new List<CT_PageField>();
        }

        [System.Xml.Serialization.XmlElementAttribute("pageField", Order = 0)]
        public List<CT_PageField> pageField
        {
            get
            {
                return this.pageFieldField;
            }
            set
            {
                this.pageFieldField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        public CT_PageField AddNewPageField()
        {
            if (this.pageFieldField == null)
                this.pageFieldField = new List<CT_PageField>();
            CT_PageField f = new CT_PageField();
            this.pageFieldField.Add(f);
            return f;
        }

        public uint SizeOfPageFieldArray()
        {
            if (this.pageFieldField == null)
                this.pageFieldField = new List<CT_PageField>();
            return (uint)this.pageFieldField.Count;
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_PageField
    {
        public static CT_PageField Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PageField ctObj = new CT_PageField();
            if (node.Attribute("fld") != null)
                ctObj.fld = XmlHelper.ReadInt(node.Attribute("fld"));
            if (node.Attribute("item") != null)
                ctObj.item = XmlHelper.ReadUInt(node.Attribute("item"));
            if (node.Attribute("hier") != null)
                ctObj.hier = XmlHelper.ReadInt(node.Attribute("hier"));
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            ctObj.cap = XmlHelper.ReadString(node.Attribute("cap"));
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
            XmlHelper.WriteAttribute(sw, "fld", this.fld);
            XmlHelper.WriteAttribute(sw, "item", this.item);
            XmlHelper.WriteAttribute(sw, "hier", this.hier);
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "cap", this.cap);
            sw.Write(">");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_ExtensionList extLstField;

        private int fldField;

        private uint itemField;

        private bool itemFieldSpecified;

        private int hierField;

        private bool hierFieldSpecified;

        private string nameField;

        private string capField;

        public CT_PageField()
        {
            this.extLstField = new CT_ExtensionList();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int fld
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemSpecified
        {
            get
            {
                return this.itemFieldSpecified;
            }
            set
            {
                this.itemFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int hier
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cap
        {
            get
            {
                return this.capField;
            }
            set
            {
                this.capField = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_DataFields
    {
        public static CT_DataFields Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_DataFields ctObj = new CT_DataFields();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.dataField = new List<CT_DataField>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "dataField")
                    ctObj.dataField.Add(CT_DataField.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.dataField != null)
            {
                foreach (CT_DataField x in this.dataField)
                {
                    x.Write(sw, "dataField");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_DataField> dataFieldField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_DataFields()
        {
            this.dataFieldField = new List<CT_DataField>();
        }

        [System.Xml.Serialization.XmlElementAttribute("dataField", Order = 0)]
        public List<CT_DataField> dataField
        {
            get
            {
                return this.dataFieldField;
            }
            set
            {
                this.dataFieldField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        public CT_DataField AddNewDataField()
        {
            if (this.dataFieldField == null)
                this.dataFieldField = new List<CT_DataField>();
            CT_DataField f = new CT_DataField();
            this.dataFieldField.Add(f);
            return f;
        }

        public uint SizeOfDataFieldArray()
        {
            return (uint)this.dataFieldField.Count;
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_DataField
    {
        public static CT_DataField Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_DataField ctObj = new CT_DataField();
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            if (node.Attribute("fld") != null)
                ctObj.fld = XmlHelper.ReadUInt(node.Attribute("fld"));
            if (node.Attribute("subtotal") != null)
                ctObj.subtotal = (ST_DataConsolidateFunction)Enum.Parse(typeof(ST_DataConsolidateFunction), node.Attribute("subtotal").Value);
            if (node.Attribute("showDataAs") != null)
                ctObj.showDataAs = (ST_ShowDataAs)Enum.Parse(typeof(ST_ShowDataAs), node.Attribute("showDataAs").Value);
            if (node.Attribute("baseField") != null)
                ctObj.baseField = XmlHelper.ReadInt(node.Attribute("baseField"));
            if (node.Attribute("baseItem") != null)
                ctObj.baseItem = XmlHelper.ReadUInt(node.Attribute("baseItem"));
            if (node.Attribute("numFmtId") != null)
                ctObj.numFmtId = XmlHelper.ReadUInt(node.Attribute("numFmtId"));
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
            XmlHelper.WriteAttribute(sw, "fld", this.fld);
            XmlHelper.WriteAttribute(sw, "subtotal", this.subtotal.ToString());
            XmlHelper.WriteAttribute(sw, "showDataAs", this.showDataAs.ToString());
            XmlHelper.WriteAttribute(sw, "baseField", this.baseField);
            XmlHelper.WriteAttribute(sw, "baseItem", this.baseItem);
            XmlHelper.WriteAttribute(sw, "numFmtId", this.numFmtId);
            sw.Write(">");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_ExtensionList extLstField;

        private string nameField;

        private uint fldField;

        private ST_DataConsolidateFunction subtotalField;

        private ST_ShowDataAs showDataAsField;

        private int baseFieldField;

        private uint baseItemField;

        private uint numFmtIdField;

        private bool numFmtIdFieldSpecified;

        public CT_DataField()
        {
            this.extLstField = new CT_ExtensionList();
            this.subtotalField = ST_DataConsolidateFunction.sum;
            this.showDataAsField = ST_ShowDataAs.normal;
            this.baseFieldField = -1;
            this.baseItemField = ((uint)(1048832));
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ST_DataConsolidateFunction.sum)]
        public ST_DataConsolidateFunction subtotal
        {
            get
            {
                return this.subtotalField;
            }
            set
            {
                this.subtotalField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ST_ShowDataAs.normal)]
        public ST_ShowDataAs showDataAs
        {
            get
            {
                return this.showDataAsField;
            }
            set
            {
                this.showDataAsField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public int baseField
        {
            get
            {
                return this.baseFieldField;
            }
            set
            {
                this.baseFieldField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "1048832")]
        public uint baseItem
        {
            get
            {
                return this.baseItemField;
            }
            set
            {
                this.baseItemField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
    public enum ST_ShowDataAs
    {

        /// <remarks/>
        normal,

        /// <remarks/>
        difference,

        /// <remarks/>
        percent,

        /// <remarks/>
        percentDiff,

        /// <remarks/>
        runTotal,

        /// <remarks/>
        percentOfRow,

        /// <remarks/>
        percentOfCol,

        /// <remarks/>
        percentOfTotal,

        /// <remarks/>
        index,
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Formats
    {
        public static CT_Formats Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Formats ctObj = new CT_Formats();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.format = new List<CT_Format>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "format")
                    ctObj.format.Add(CT_Format.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.format != null)
            {
                foreach (CT_Format x in this.format)
                {
                    x.Write(sw, "format");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_Format> formatField;

        private uint countField;

        public CT_Formats()
        {
            this.formatField = new List<CT_Format>();
            this.countField = ((uint)(0));
        }

        [System.Xml.Serialization.XmlElementAttribute("format", Order = 0)]
        public List<CT_Format> format
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
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
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Format
    {
        public static CT_Format Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Format ctObj = new CT_Format();
            if (node.Attribute("action") != null)
                ctObj.action = (ST_FormatAction)Enum.Parse(typeof(ST_FormatAction), node.Attribute("action").Value);
            if (node.Attribute("dxfId") != null)
                ctObj.dxfId = XmlHelper.ReadUInt(node.Attribute("dxfId"));
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
            XmlHelper.WriteAttribute(sw, "action", this.action.ToString());
            XmlHelper.WriteAttribute(sw, "dxfId", this.dxfId);
            sw.Write(">");
            if (this.pivotArea != null)
                this.pivotArea.Write(sw, "pivotArea");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_PivotArea pivotAreaField;

        private CT_ExtensionList extLstField;

        private ST_FormatAction actionField;

        private uint dxfIdField;

        private bool dxfIdFieldSpecified;

        public CT_Format()
        {
            this.extLstField = new CT_ExtensionList();
            this.pivotAreaField = new CT_PivotArea();
            this.actionField = ST_FormatAction.formatting;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ST_FormatAction.formatting)]
        public ST_FormatAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint dxfId
        {
            get
            {
                return this.dxfIdField;
            }
            set
            {
                this.dxfIdField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dxfIdSpecified
        {
            get
            {
                return this.dxfIdFieldSpecified;
            }
            set
            {
                this.dxfIdFieldSpecified = value;
            }
        }
    }

    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
    public enum ST_FormatAction
    {

        /// <remarks/>
        blank,

        /// <remarks/>
        formatting,

        /// <remarks/>
        drill,

        /// <remarks/>
        formula,
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_ConditionalFormats
    {
        public static CT_ConditionalFormats Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_ConditionalFormats ctObj = new CT_ConditionalFormats();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.conditionalFormat = new List<CT_ConditionalFormat>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "conditionalFormat")
                    ctObj.conditionalFormat.Add(CT_ConditionalFormat.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.conditionalFormat != null)
            {
                foreach (CT_ConditionalFormat x in this.conditionalFormat)
                {
                    x.Write(sw, "conditionalFormat");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_ConditionalFormat> conditionalFormatField;

        private uint countField;

        public CT_ConditionalFormats()
        {
            this.conditionalFormatField = new List<CT_ConditionalFormat>();
            this.countField = ((uint)(0));
        }

        [System.Xml.Serialization.XmlElementAttribute("conditionalFormat", Order = 0)]
        public List<CT_ConditionalFormat> conditionalFormat
        {
            get
            {
                return this.conditionalFormatField;
            }
            set
            {
                this.conditionalFormatField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
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
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_ConditionalFormat
    {
        public static CT_ConditionalFormat Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_ConditionalFormat ctObj = new CT_ConditionalFormat();
            if (node.Attribute("scope") != null)
                ctObj.scope = (ST_Scope)Enum.Parse(typeof(ST_Scope), node.Attribute("scope").Value);
            if (node.Attribute("type") != null)
                ctObj.type = (ST_Type)Enum.Parse(typeof(ST_Type), node.Attribute("type").Value);
            if (node.Attribute("priority") != null)
                ctObj.priority = XmlHelper.ReadUInt(node.Attribute("priority"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "pivotAreas")
                    ctObj.pivotAreas = CT_PivotAreas.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "scope", this.scope.ToString());
            XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
            XmlHelper.WriteAttribute(sw, "priority", this.priority);
            sw.Write(">");
            if (this.pivotAreas != null)
                this.pivotAreas.Write(sw, "pivotAreas");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_PivotAreas pivotAreasField;

        private CT_ExtensionList extLstField;

        private ST_Scope scopeField;

        private ST_Type typeField;

        private uint priorityField;

        public CT_ConditionalFormat()
        {
            this.extLstField = new CT_ExtensionList();
            this.pivotAreasField = new CT_PivotAreas();
            this.scopeField = ST_Scope.selection;
            this.typeField = ST_Type.none;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CT_PivotAreas pivotAreas
        {
            get
            {
                return this.pivotAreasField;
            }
            set
            {
                this.pivotAreasField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ST_Scope.selection)]
        public ST_Scope scope
        {
            get
            {
                return this.scopeField;
            }
            set
            {
                this.scopeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ST_Type.none)]
        public ST_Type type
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_PivotAreas
    {
        public static CT_PivotAreas Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PivotAreas ctObj = new CT_PivotAreas();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.pivotArea = new List<CT_PivotArea>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "pivotArea")
                    ctObj.pivotArea.Add(CT_PivotArea.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.pivotArea != null)
            {
                foreach (CT_PivotArea x in this.pivotArea)
                {
                    x.Write(sw, "pivotArea");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_PivotArea> pivotAreaField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_PivotAreas()
        {
            this.pivotAreaField = new List<CT_PivotArea>();
        }

        [System.Xml.Serialization.XmlElementAttribute("pivotArea", Order = 0)]
        public List<CT_PivotArea> pivotArea
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
    public enum ST_Scope
    {

        /// <remarks/>
        selection,

        /// <remarks/>
        data,

        /// <remarks/>
        field,
    }

    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
    public enum ST_Type
    {

        /// <remarks/>
        none,

        /// <remarks/>
        all,

        /// <remarks/>
        row,

        /// <remarks/>
        column,
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_ChartFormats
    {
        public static CT_ChartFormats Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_ChartFormats ctObj = new CT_ChartFormats();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.chartFormat = new List<CT_ChartFormat>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "chartFormat")
                    ctObj.chartFormat.Add(CT_ChartFormat.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.chartFormat != null)
            {
                foreach (CT_ChartFormat x in this.chartFormat)
                {
                    x.Write(sw, "chartFormat");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_ChartFormat> chartFormatField;

        private uint countField;

        public CT_ChartFormats()
        {
            this.chartFormatField = new List<CT_ChartFormat>();
            this.countField = ((uint)(0));
        }

        [System.Xml.Serialization.XmlElementAttribute("chartFormat", Order = 0)]
        public List<CT_ChartFormat> chartFormat
        {
            get
            {
                return this.chartFormatField;
            }
            set
            {
                this.chartFormatField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
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
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_ChartFormat
    {
        public static CT_ChartFormat Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_ChartFormat ctObj = new CT_ChartFormat();
            if (node.Attribute("chart") != null)
                ctObj.chart = XmlHelper.ReadUInt(node.Attribute("chart"));
            if (node.Attribute("format") != null)
                ctObj.format = XmlHelper.ReadUInt(node.Attribute("format"));
            if (node.Attribute("series") != null)
                ctObj.series = XmlHelper.ReadBool(node.Attribute("series"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "pivotArea")
                    ctObj.pivotArea = CT_PivotArea.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "chart", this.chart);
            XmlHelper.WriteAttribute(sw, "format", this.format);
            XmlHelper.WriteAttribute(sw, "series", this.series);
            sw.Write(">");
            if (this.pivotArea != null)
                this.pivotArea.Write(sw, "pivotArea");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_PivotArea pivotAreaField;

        private uint chartField;

        private uint formatField;

        private bool seriesField;

        public CT_ChartFormat()
        {
            this.pivotAreaField = new CT_PivotArea();
            this.seriesField = false;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint chart
        {
            get
            {
                return this.chartField;
            }
            set
            {
                this.chartField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint format
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool series
        {
            get
            {
                return this.seriesField;
            }
            set
            {
                this.seriesField = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_PivotHierarchies
    {
        public static CT_PivotHierarchies Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PivotHierarchies ctObj = new CT_PivotHierarchies();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.pivotHierarchy = new List<CT_PivotHierarchy>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "pivotHierarchy")
                    ctObj.pivotHierarchy.Add(CT_PivotHierarchy.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.pivotHierarchy != null)
            {
                foreach (CT_PivotHierarchy x in this.pivotHierarchy)
                {
                    x.Write(sw, "pivotHierarchy");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_PivotHierarchy> pivotHierarchyField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_PivotHierarchies()
        {
            this.pivotHierarchyField = new List<CT_PivotHierarchy>();
        }

        [System.Xml.Serialization.XmlElementAttribute("pivotHierarchy", Order = 0)]
        public List<CT_PivotHierarchy> pivotHierarchy
        {
            get
            {
                return this.pivotHierarchyField;
            }
            set
            {
                this.pivotHierarchyField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class CT_PivotHierarchy
    {
        public static CT_PivotHierarchy Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PivotHierarchy ctObj = new CT_PivotHierarchy();
            if (node.Attribute("outline") != null)
                ctObj.outline = XmlHelper.ReadBool(node.Attribute("outline"));
            if (node.Attribute("multipleItemSelectionAllowed") != null)
                ctObj.multipleItemSelectionAllowed = XmlHelper.ReadBool(node.Attribute("multipleItemSelectionAllowed"));
            if (node.Attribute("subtotalTop") != null)
                ctObj.subtotalTop = XmlHelper.ReadBool(node.Attribute("subtotalTop"));
            if (node.Attribute("showInFieldList") != null)
                ctObj.showInFieldList = XmlHelper.ReadBool(node.Attribute("showInFieldList"));
            if (node.Attribute("dragToRow") != null)
                ctObj.dragToRow = XmlHelper.ReadBool(node.Attribute("dragToRow"));
            if (node.Attribute("dragToCol") != null)
                ctObj.dragToCol = XmlHelper.ReadBool(node.Attribute("dragToCol"));
            if (node.Attribute("dragToPage") != null)
                ctObj.dragToPage = XmlHelper.ReadBool(node.Attribute("dragToPage"));
            if (node.Attribute("dragToData") != null)
                ctObj.dragToData = XmlHelper.ReadBool(node.Attribute("dragToData"));
            if (node.Attribute("dragOff") != null)
                ctObj.dragOff = XmlHelper.ReadBool(node.Attribute("dragOff"));
            if (node.Attribute("includeNewItemsInFilter") != null)
                ctObj.includeNewItemsInFilter = XmlHelper.ReadBool(node.Attribute("includeNewItemsInFilter"));
            ctObj.caption = XmlHelper.ReadString(node.Attribute("caption"));
            ctObj.members = new List<CT_Members>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "mps")
                    ctObj.mps = CT_MemberProperties.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "members")
                    ctObj.members.Add(CT_Members.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "outline", this.outline);
            XmlHelper.WriteAttribute(sw, "multipleItemSelectionAllowed", this.multipleItemSelectionAllowed);
            XmlHelper.WriteAttribute(sw, "subtotalTop", this.subtotalTop);
            XmlHelper.WriteAttribute(sw, "showInFieldList", this.showInFieldList);
            XmlHelper.WriteAttribute(sw, "dragToRow", this.dragToRow);
            XmlHelper.WriteAttribute(sw, "dragToCol", this.dragToCol);
            XmlHelper.WriteAttribute(sw, "dragToPage", this.dragToPage);
            XmlHelper.WriteAttribute(sw, "dragToData", this.dragToData);
            XmlHelper.WriteAttribute(sw, "dragOff", this.dragOff);
            XmlHelper.WriteAttribute(sw, "includeNewItemsInFilter", this.includeNewItemsInFilter);
            XmlHelper.WriteAttribute(sw, "caption", this.caption);
            sw.Write(">");
            if (this.mps != null)
                this.mps.Write(sw, "mps");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            if (this.members != null)
            {
                foreach (CT_Members x in this.members)
                {
                    x.Write(sw, "members");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_MemberProperties mpsField;

        private List<CT_Members> membersField;

        private CT_ExtensionList extLstField;

        private bool outlineField;

        private bool multipleItemSelectionAllowedField;

        private bool subtotalTopField;

        private bool showInFieldListField;

        private bool dragToRowField;

        private bool dragToColField;

        private bool dragToPageField;

        private bool dragToDataField;

        private bool dragOffField;

        private bool includeNewItemsInFilterField;

        private string captionField;

        public CT_PivotHierarchy()
        {
            this.extLstField = new CT_ExtensionList();
            this.membersField = new List<CT_Members>();
            this.mpsField = new CT_MemberProperties();
            this.outlineField = false;
            this.multipleItemSelectionAllowedField = false;
            this.subtotalTopField = false;
            this.showInFieldListField = true;
            this.dragToRowField = true;
            this.dragToColField = true;
            this.dragToPageField = true;
            this.dragToDataField = false;
            this.dragOffField = true;
            this.includeNewItemsInFilterField = false;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CT_MemberProperties mps
        {
            get
            {
                return this.mpsField;
            }
            set
            {
                this.mpsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("members", Order = 1)]
        public List<CT_Members> members
        {
            get
            {
                return this.membersField;
            }
            set
            {
                this.membersField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool outline
        {
            get
            {
                return this.outlineField;
            }
            set
            {
                this.outlineField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool multipleItemSelectionAllowed
        {
            get
            {
                return this.multipleItemSelectionAllowedField;
            }
            set
            {
                this.multipleItemSelectionAllowedField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool subtotalTop
        {
            get
            {
                return this.subtotalTopField;
            }
            set
            {
                this.subtotalTopField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool showInFieldList
        {
            get
            {
                return this.showInFieldListField;
            }
            set
            {
                this.showInFieldListField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool dragToRow
        {
            get
            {
                return this.dragToRowField;
            }
            set
            {
                this.dragToRowField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool dragToCol
        {
            get
            {
                return this.dragToColField;
            }
            set
            {
                this.dragToColField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool dragToPage
        {
            get
            {
                return this.dragToPageField;
            }
            set
            {
                this.dragToPageField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool dragToData
        {
            get
            {
                return this.dragToDataField;
            }
            set
            {
                this.dragToDataField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool dragOff
        {
            get
            {
                return this.dragOffField;
            }
            set
            {
                this.dragOffField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool includeNewItemsInFilter
        {
            get
            {
                return this.includeNewItemsInFilterField;
            }
            set
            {
                this.includeNewItemsInFilterField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class CT_MemberProperties
    {
        public static CT_MemberProperties Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_MemberProperties ctObj = new CT_MemberProperties();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.mp = new List<CT_MemberProperty>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "mp")
                    ctObj.mp.Add(CT_MemberProperty.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.mp != null)
            {
                foreach (CT_MemberProperty x in this.mp)
                {
                    x.Write(sw, "mp");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_MemberProperty> mpField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_MemberProperties()
        {
            this.mpField = new List<CT_MemberProperty>();
        }

        [System.Xml.Serialization.XmlElementAttribute("mp", Order = 0)]
        public List<CT_MemberProperty> mp
        {
            get
            {
                return this.mpField;
            }
            set
            {
                this.mpField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class CT_MemberProperty
    {
        public static CT_MemberProperty Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_MemberProperty ctObj = new CT_MemberProperty();
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            if (node.Attribute("showCell") != null)
                ctObj.showCell = XmlHelper.ReadBool(node.Attribute("showCell"));
            if (node.Attribute("showTip") != null)
                ctObj.showTip = XmlHelper.ReadBool(node.Attribute("showTip"));
            if (node.Attribute("showAsCaption") != null)
                ctObj.showAsCaption = XmlHelper.ReadBool(node.Attribute("showAsCaption"));
            if (node.Attribute("nameLen") != null)
                ctObj.nameLen = XmlHelper.ReadUInt(node.Attribute("nameLen"));
            if (node.Attribute("pPos") != null)
                ctObj.pPos = XmlHelper.ReadUInt(node.Attribute("pPos"));
            if (node.Attribute("pLen") != null)
                ctObj.pLen = XmlHelper.ReadUInt(node.Attribute("pLen"));
            if (node.Attribute("level") != null)
                ctObj.level = XmlHelper.ReadUInt(node.Attribute("level"));
            if (node.Attribute("field") != null)
                ctObj.field = XmlHelper.ReadUInt(node.Attribute("field"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "showCell", this.showCell);
            XmlHelper.WriteAttribute(sw, "showTip", this.showTip);
            XmlHelper.WriteAttribute(sw, "showAsCaption", this.showAsCaption);
            XmlHelper.WriteAttribute(sw, "nameLen", this.nameLen);
            XmlHelper.WriteAttribute(sw, "pPos", this.pPos);
            XmlHelper.WriteAttribute(sw, "pLen", this.pLen);
            XmlHelper.WriteAttribute(sw, "level", this.level);
            XmlHelper.WriteAttribute(sw, "field", this.field);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private string nameField;

        private bool showCellField;

        private bool showTipField;

        private bool showAsCaptionField;

        private uint nameLenField;

        private bool nameLenFieldSpecified;

        private uint pPosField;

        private bool pPosFieldSpecified;

        private uint pLenField;

        private bool pLenFieldSpecified;

        private uint levelField;

        private bool levelFieldSpecified;

        private uint fieldField;

        public CT_MemberProperty()
        {
            this.showCellField = false;
            this.showTipField = false;
            this.showAsCaptionField = false;
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool showCell
        {
            get
            {
                return this.showCellField;
            }
            set
            {
                this.showCellField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool showTip
        {
            get
            {
                return this.showTipField;
            }
            set
            {
                this.showTipField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool showAsCaption
        {
            get
            {
                return this.showAsCaptionField;
            }
            set
            {
                this.showAsCaptionField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint nameLen
        {
            get
            {
                return this.nameLenField;
            }
            set
            {
                this.nameLenField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nameLenSpecified
        {
            get
            {
                return this.nameLenFieldSpecified;
            }
            set
            {
                this.nameLenFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint pPos
        {
            get
            {
                return this.pPosField;
            }
            set
            {
                this.pPosField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pPosSpecified
        {
            get
            {
                return this.pPosFieldSpecified;
            }
            set
            {
                this.pPosFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint pLen
        {
            get
            {
                return this.pLenField;
            }
            set
            {
                this.pLenField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pLenSpecified
        {
            get
            {
                return this.pLenFieldSpecified;
            }
            set
            {
                this.pLenFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool levelSpecified
        {
            get
            {
                return this.levelFieldSpecified;
            }
            set
            {
                this.levelFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Members
    {
        public static CT_Members Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Members ctObj = new CT_Members();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            if (node.Attribute("level") != null)
                ctObj.level = XmlHelper.ReadUInt(node.Attribute("level"));
            ctObj.member = new List<CT_Member>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "member")
                    ctObj.member.Add(CT_Member.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            XmlHelper.WriteAttribute(sw, "level", this.level);
            sw.Write(">");
            if (this.member != null)
            {
                foreach (CT_Member x in this.member)
                {
                    x.Write(sw, "member");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_Member> memberField;

        private uint countField;

        private bool countFieldSpecified;

        private uint levelField;

        private bool levelFieldSpecified;

        public CT_Members()
        {
            this.memberField = new List<CT_Member>();
        }

        [System.Xml.Serialization.XmlElementAttribute("member", Order = 0)]
        public List<CT_Member> member
        {
            get
            {
                return this.memberField;
            }
            set
            {
                this.memberField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool levelSpecified
        {
            get
            {
                return this.levelFieldSpecified;
            }
            set
            {
                this.levelFieldSpecified = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_Member
    {
        public static CT_Member Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Member ctObj = new CT_Member();
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class CT_PivotTableStyle
    {
        public static CT_PivotTableStyle Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PivotTableStyle ctObj = new CT_PivotTableStyle();
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            if (node.Attribute("showRowHeaders") != null)
                ctObj.showRowHeaders = XmlHelper.ReadBool(node.Attribute("showRowHeaders"));
            if (node.Attribute("showColHeaders") != null)
                ctObj.showColHeaders = XmlHelper.ReadBool(node.Attribute("showColHeaders"));
            if (node.Attribute("showRowStripes") != null)
                ctObj.showRowStripes = XmlHelper.ReadBool(node.Attribute("showRowStripes"));
            if (node.Attribute("showColStripes") != null)
                ctObj.showColStripes = XmlHelper.ReadBool(node.Attribute("showColStripes"));
            if (node.Attribute("showLastColumn") != null)
                ctObj.showLastColumn = XmlHelper.ReadBool(node.Attribute("showLastColumn"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "showRowHeaders", this.showRowHeaders);
            XmlHelper.WriteAttribute(sw, "showColHeaders", this.showColHeaders);
            XmlHelper.WriteAttribute(sw, "showRowStripes", this.showRowStripes);
            XmlHelper.WriteAttribute(sw, "showColStripes", this.showColStripes);
            XmlHelper.WriteAttribute(sw, "showLastColumn", this.showLastColumn);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private string nameField;

        private bool showRowHeadersField;

        private bool showRowHeadersFieldSpecified;

        private bool showColHeadersField;

        private bool showColHeadersFieldSpecified;

        private bool showRowStripesField;

        private bool showRowStripesFieldSpecified;

        private bool showColStripesField;

        private bool showColStripesFieldSpecified;

        private bool showLastColumnField;

        private bool showLastColumnFieldSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool showRowHeaders
        {
            get
            {
                return this.showRowHeadersField;
            }
            set
            {
                this.showRowHeadersField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showRowHeadersSpecified
        {
            get
            {
                return this.showRowHeadersFieldSpecified;
            }
            set
            {
                this.showRowHeadersFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool showColHeaders
        {
            get
            {
                return this.showColHeadersField;
            }
            set
            {
                this.showColHeadersField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showColHeadersSpecified
        {
            get
            {
                return this.showColHeadersFieldSpecified;
            }
            set
            {
                this.showColHeadersFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool showRowStripes
        {
            get
            {
                return this.showRowStripesField;
            }
            set
            {
                this.showRowStripesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showRowStripesSpecified
        {
            get
            {
                return this.showRowStripesFieldSpecified;
            }
            set
            {
                this.showRowStripesFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool showColStripes
        {
            get
            {
                return this.showColStripesField;
            }
            set
            {
                this.showColStripesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showColStripesSpecified
        {
            get
            {
                return this.showColStripesFieldSpecified;
            }
            set
            {
                this.showColStripesFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool showLastColumn
        {
            get
            {
                return this.showLastColumnField;
            }
            set
            {
                this.showLastColumnField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showLastColumnSpecified
        {
            get
            {
                return this.showLastColumnFieldSpecified;
            }
            set
            {
                this.showLastColumnFieldSpecified = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_PivotFilters
    {
        public static CT_PivotFilters Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PivotFilters ctObj = new CT_PivotFilters();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.filter = new List<CT_PivotFilter>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "filter")
                    ctObj.filter.Add(CT_PivotFilter.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.filter != null)
            {
                foreach (CT_PivotFilter x in this.filter)
                {
                    x.Write(sw, "filter");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_PivotFilter> filterField;

        private uint countField;

        public CT_PivotFilters()
        {
            this.filterField = new List<CT_PivotFilter>();
            this.countField = ((uint)(0));
        }

        [System.Xml.Serialization.XmlElementAttribute("filter", Order = 0)]
        public List<CT_PivotFilter> filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
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
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_PivotFilter
    {
        public static CT_PivotFilter Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_PivotFilter ctObj = new CT_PivotFilter();
            if (node.Attribute("fld") != null)
                ctObj.fld = XmlHelper.ReadUInt(node.Attribute("fld"));
            if (node.Attribute("mpFld") != null)
                ctObj.mpFld = XmlHelper.ReadUInt(node.Attribute("mpFld"));
            if (node.Attribute("type") != null)
                ctObj.type = (ST_PivotFilterType)Enum.Parse(typeof(ST_PivotFilterType), node.Attribute("type").Value);
            if (node.Attribute("evalOrder") != null)
                ctObj.evalOrder = XmlHelper.ReadInt(node.Attribute("evalOrder"));
            if (node.Attribute("id") != null)
                ctObj.id = XmlHelper.ReadUInt(node.Attribute("id"));
            if (node.Attribute("iMeasureHier") != null)
                ctObj.iMeasureHier = XmlHelper.ReadUInt(node.Attribute("iMeasureHier"));
            if (node.Attribute("iMeasureFld") != null)
                ctObj.iMeasureFld = XmlHelper.ReadUInt(node.Attribute("iMeasureFld"));
            ctObj.name = XmlHelper.ReadString(node.Attribute("name"));
            ctObj.description = XmlHelper.ReadString(node.Attribute("description"));
            ctObj.stringValue1 = XmlHelper.ReadString(node.Attribute("stringValue1"));
            ctObj.stringValue2 = XmlHelper.ReadString(node.Attribute("stringValue2"));
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "autoFilter")
                    ctObj.autoFilter = CT_AutoFilter.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "extLst")
                    ctObj.extLst = CT_ExtensionList.Parse(childNode, namespaceManager);
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "fld", this.fld);
            XmlHelper.WriteAttribute(sw, "mpFld", this.mpFld);
            XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
            XmlHelper.WriteAttribute(sw, "evalOrder", this.evalOrder);
            XmlHelper.WriteAttribute(sw, "id", this.id);
            XmlHelper.WriteAttribute(sw, "iMeasureHier", this.iMeasureHier);
            XmlHelper.WriteAttribute(sw, "iMeasureFld", this.iMeasureFld);
            XmlHelper.WriteAttribute(sw, "name", this.name);
            XmlHelper.WriteAttribute(sw, "description", this.description);
            XmlHelper.WriteAttribute(sw, "stringValue1", this.stringValue1);
            XmlHelper.WriteAttribute(sw, "stringValue2", this.stringValue2);
            sw.Write(">");
            if (this.autoFilter != null)
                this.autoFilter.Write(sw, "autoFilter");
            if (this.extLst != null)
                this.extLst.Write(sw, "extLst");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private CT_AutoFilter autoFilterField;

        private CT_ExtensionList extLstField;

        private uint fldField;

        private uint mpFldField;

        private bool mpFldFieldSpecified;

        private ST_PivotFilterType typeField;

        private int evalOrderField;

        private uint idField;

        private uint iMeasureHierField;

        private bool iMeasureHierFieldSpecified;

        private uint iMeasureFldField;

        private bool iMeasureFldFieldSpecified;

        private string nameField;

        private string descriptionField;

        private string stringValue1Field;

        private string stringValue2Field;

        public CT_PivotFilter()
        {
            this.extLstField = new CT_ExtensionList();
            this.autoFilterField = new CT_AutoFilter();
            this.evalOrderField = 0;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint mpFld
        {
            get
            {
                return this.mpFldField;
            }
            set
            {
                this.mpFldField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool mpFldSpecified
        {
            get
            {
                return this.mpFldFieldSpecified;
            }
            set
            {
                this.mpFldFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ST_PivotFilterType type
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int evalOrder
        {
            get
            {
                return this.evalOrderField;
            }
            set
            {
                this.evalOrderField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint iMeasureHier
        {
            get
            {
                return this.iMeasureHierField;
            }
            set
            {
                this.iMeasureHierField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool iMeasureHierSpecified
        {
            get
            {
                return this.iMeasureHierFieldSpecified;
            }
            set
            {
                this.iMeasureHierFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint iMeasureFld
        {
            get
            {
                return this.iMeasureFldField;
            }
            set
            {
                this.iMeasureFldField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool iMeasureFldSpecified
        {
            get
            {
                return this.iMeasureFldFieldSpecified;
            }
            set
            {
                this.iMeasureFldFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string stringValue1
        {
            get
            {
                return this.stringValue1Field;
            }
            set
            {
                this.stringValue1Field = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string stringValue2
        {
            get
            {
                return this.stringValue2Field;
            }
            set
            {
                this.stringValue2Field = value;
            }
        }
    }

    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
    public enum ST_PivotFilterType
    {

        /// <remarks/>
        unknown,

        /// <remarks/>
        count,

        /// <remarks/>
        percent,

        /// <remarks/>
        sum,

        /// <remarks/>
        captionEqual,

        /// <remarks/>
        captionNotEqual,

        /// <remarks/>
        captionBeginsWith,

        /// <remarks/>
        captionNotBeginsWith,

        /// <remarks/>
        captionEndsWith,

        /// <remarks/>
        captionNotEndsWith,

        /// <remarks/>
        captionContains,

        /// <remarks/>
        captionNotContains,

        /// <remarks/>
        captionGreaterThan,

        /// <remarks/>
        captionGreaterThanOrEqual,

        /// <remarks/>
        captionLessThan,

        /// <remarks/>
        captionLessThanOrEqual,

        /// <remarks/>
        captionBetween,

        /// <remarks/>
        captionNotBetween,

        /// <remarks/>
        valueEqual,

        /// <remarks/>
        valueNotEqual,

        /// <remarks/>
        valueGreaterThan,

        /// <remarks/>
        valueGreaterThanOrEqual,

        /// <remarks/>
        valueLessThan,

        /// <remarks/>
        valueLessThanOrEqual,

        /// <remarks/>
        valueBetween,

        /// <remarks/>
        valueNotBetween,

        /// <remarks/>
        dateEqual,

        /// <remarks/>
        dateNotEqual,

        /// <remarks/>
        dateOlderThan,

        /// <remarks/>
        dateOlderThanOrEqual,

        /// <remarks/>
        dateNewerThan,

        /// <remarks/>
        dateNewerThanOrEqual,

        /// <remarks/>
        dateBetween,

        /// <remarks/>
        dateNotBetween,

        /// <remarks/>
        tomorrow,

        /// <remarks/>
        today,

        /// <remarks/>
        yesterday,

        /// <remarks/>
        nextWeek,

        /// <remarks/>
        thisWeek,

        /// <remarks/>
        lastWeek,

        /// <remarks/>
        nextMonth,

        /// <remarks/>
        thisMonth,

        /// <remarks/>
        lastMonth,

        /// <remarks/>
        nextQuarter,

        /// <remarks/>
        thisQuarter,

        /// <remarks/>
        lastQuarter,

        /// <remarks/>
        nextYear,

        /// <remarks/>
        thisYear,

        /// <remarks/>
        lastYear,

        /// <remarks/>
        yearToDate,

        /// <remarks/>
        Q1,

        /// <remarks/>
        Q2,

        /// <remarks/>
        Q3,

        /// <remarks/>
        Q4,

        /// <remarks/>
        M1,

        /// <remarks/>
        M2,

        /// <remarks/>
        M3,

        /// <remarks/>
        M4,

        /// <remarks/>
        M5,

        /// <remarks/>
        M6,

        /// <remarks/>
        M7,

        /// <remarks/>
        M8,

        /// <remarks/>
        M9,

        /// <remarks/>
        M10,

        /// <remarks/>
        M11,

        /// <remarks/>
        M12,
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_RowHierarchiesUsage
    {
        public static CT_RowHierarchiesUsage Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_RowHierarchiesUsage ctObj = new CT_RowHierarchiesUsage();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.rowHierarchyUsage = new List<CT_HierarchyUsage>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "rowHierarchyUsage")
                    ctObj.rowHierarchyUsage.Add(CT_HierarchyUsage.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.rowHierarchyUsage != null)
            {
                foreach (CT_HierarchyUsage x in this.rowHierarchyUsage)
                {
                    x.Write(sw, "rowHierarchyUsage");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_HierarchyUsage> rowHierarchyUsageField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_RowHierarchiesUsage()
        {
            this.rowHierarchyUsageField = new List<CT_HierarchyUsage>();
        }

        [System.Xml.Serialization.XmlElementAttribute("rowHierarchyUsage", Order = 0)]
        public List<CT_HierarchyUsage> rowHierarchyUsage
        {
            get
            {
                return this.rowHierarchyUsageField;
            }
            set
            {
                this.rowHierarchyUsageField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class CT_HierarchyUsage
    {
        public static CT_HierarchyUsage Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_HierarchyUsage ctObj = new CT_HierarchyUsage();
            if (node.Attribute("hierarchyUsage") != null)
                ctObj.hierarchyUsage = XmlHelper.ReadInt(node.Attribute("hierarchyUsage"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "hierarchyUsage", this.hierarchyUsage);
            sw.Write(">");
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private int hierarchyUsageField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int hierarchyUsage
        {
            get
            {
                return this.hierarchyUsageField;
            }
            set
            {
                this.hierarchyUsageField = value;
            }
        }
    }

    
    
    
    [XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
    public partial class CT_ColHierarchiesUsage
    {
        public static CT_ColHierarchiesUsage Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_ColHierarchiesUsage ctObj = new CT_ColHierarchiesUsage();
            if (node.Attribute("count") != null)
                ctObj.count = XmlHelper.ReadUInt(node.Attribute("count"));
            ctObj.colHierarchyUsage = new List<CT_HierarchyUsage>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "colHierarchyUsage")
                    ctObj.colHierarchyUsage.Add(CT_HierarchyUsage.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "count", this.count);
            sw.Write(">");
            if (this.colHierarchyUsage != null)
            {
                foreach (CT_HierarchyUsage x in this.colHierarchyUsage)
                {
                    x.Write(sw, "colHierarchyUsage");
                }
            }
            sw.Write(string.Format("</{0}>", nodeName));
        }

        private List<CT_HierarchyUsage> colHierarchyUsageField;

        private uint countField;

        private bool countFieldSpecified;

        public CT_ColHierarchiesUsage()
        {
            this.colHierarchyUsageField = new List<CT_HierarchyUsage>();
        }

        [System.Xml.Serialization.XmlElementAttribute("colHierarchyUsage", Order = 0)]
        public List<CT_HierarchyUsage> colHierarchyUsage
        {
            get
            {
                return this.colHierarchyUsageField;
            }
            set
            {
                this.colHierarchyUsageField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    
}
