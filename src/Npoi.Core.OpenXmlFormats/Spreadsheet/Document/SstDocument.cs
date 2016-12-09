using Npoi.Core.OpenXml4Net.Util;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Npoi.Core.OpenXmlFormats.Spreadsheet
{
    public class SstDocument
    {
        private CT_Sst sst = null;

        public SstDocument()
        {
        }

        public SstDocument(CT_Sst sst)
        {
            this.sst = sst;
        }

        public void AddNewSst()
        {
            this.sst = new CT_Sst();
        }

        public CT_Sst GetSst()
        {
            return this.sst;
        }

        public static SstDocument Parse(XDocument xml, XmlNamespaceManager namespaceManager)
        {
            try
            {
                SstDocument sstDoc = new SstDocument();
                sstDoc.AddNewSst();
                CT_Sst sst = sstDoc.GetSst();
                sst.count = XmlHelper.ReadInt(xml.Document.Root.Attribute("count"));
                sst.uniqueCount = XmlHelper.ReadInt(xml.Document.Root.Attribute("uniqueCount"));

                var nl = xml.XPathSelectElements("//d:sst/d:si", namespaceManager);
                if (nl != null)
                {
                    foreach (XElement node in nl)
                    {
                        CT_Rst rst = CT_Rst.Parse(node, namespaceManager);
                        sstDoc.sst.si.Add(rst);
                    }
                }
                return sstDoc;
            }
            catch (XmlException e)
            {
                throw new IOException(e.Message);
            }
        }

        public void Save(Stream stream)
        {
            StreamWriter sw = new StreamWriter(stream, Encoding.UTF8);
            sw.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\" ?><sst xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\" count=\"{0}\" uniqueCount=\"{1}\">", this.GetSst().count, this.GetSst().uniqueCount);
            foreach (CT_Rst ssi in this.GetSst().si)
            {
                ssi.Write(sw, "si");
            }
            sw.Write("</sst>");
            sw.Flush();
        }
    }
}