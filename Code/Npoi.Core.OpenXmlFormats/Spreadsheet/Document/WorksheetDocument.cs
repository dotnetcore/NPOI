using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Npoi.Core.OpenXmlFormats.Spreadsheet
{
    public class WorksheetDocument
    {
        CT_Worksheet sheet = null;

        public WorksheetDocument()
        {
        }
        public WorksheetDocument(CT_Worksheet sheet)
        {
            this.sheet = sheet;
        }
        public static WorksheetDocument Parse(XDocument xmldoc, XmlNamespaceManager namespaceMgr)
        {
            CT_Worksheet obj = CT_Worksheet.Parse(xmldoc.Document.Root, namespaceMgr);
            return new WorksheetDocument(obj);
        }
        public CT_Worksheet GetWorksheet()
        {
            return sheet;
        }
        public void SetChartsheet(CT_Worksheet sheet)
        {
            this.sheet = sheet;
        }
        public void Save(Stream stream)
        {
            this.sheet.Write(stream);
        }
    }
}
