using Npoi.Core.OpenXmlFormats.Dml;
using System.IO;
using System.Xml.Linq;

namespace Npoi.Core.OpenXmlFormats.Spreadsheet
{
    public class ThemeDocument
    {
        private CT_OfficeStyleSheet stylesheet = null;

        public ThemeDocument()
        {
        }

        public ThemeDocument(CT_OfficeStyleSheet stylesheet)
        {
            this.stylesheet = stylesheet;
        }

        public CT_OfficeStyleSheet GetTheme()
        {
            return stylesheet;
        }

        public void Save(Stream stream)
        {
            using (StreamWriter sw = new StreamWriter(stream))
            {
                this.stylesheet.Write(sw);
            }
        }

        public static ThemeDocument Parse(XDocument xmldoc, System.Xml.XmlNamespaceManager namespaceManager)
        {
            CT_OfficeStyleSheet obj = CT_OfficeStyleSheet.Parse(xmldoc.Document.Root, namespaceManager);
            return new ThemeDocument(obj);
        }
    }
}