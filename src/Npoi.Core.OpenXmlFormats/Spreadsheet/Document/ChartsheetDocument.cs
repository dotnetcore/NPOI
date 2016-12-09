using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Npoi.Core.OpenXmlFormats.Spreadsheet
{
    public class ChartsheetDocument
    {
        private CT_Chartsheet sheet = null;

        public ChartsheetDocument()
        {
        }

        public ChartsheetDocument(CT_Chartsheet sheet)
        {
            this.sheet = sheet;
        }

        public static ChartsheetDocument Parse(XDocument xmldoc, XmlNamespaceManager nsmgr)
        {
            CT_Chartsheet obj = CT_Chartsheet.Parse(xmldoc.Document.Root, nsmgr);
            return new ChartsheetDocument(obj);
        }

        public CT_Chartsheet GetChartsheet()
        {
            return sheet;
        }

        public void SetChartsheet(CT_Chartsheet sheet)
        {
            this.sheet = sheet;
        }

        public void Save(Stream stream)
        {
            this.sheet.Write(stream);
        }
    }
}