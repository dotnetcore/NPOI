using Npoi.Core.OpenXmlFormats.Dml.Chart;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Npoi.Core.OpenXmlFormats.Dml
{
    public class ChartSpaceDocument
    {
        private CT_ChartSpace chartSpace = null;

        public ChartSpaceDocument()
        {
            chartSpace = new CT_ChartSpace();
        }

        public ChartSpaceDocument(CT_ChartSpace chartspace)
        {
            this.chartSpace = chartspace;
        }

        public static ChartSpaceDocument Parse(XDocument xmldoc, XmlNamespaceManager namespaceMgr)
        {
            CT_ChartSpace obj = CT_ChartSpace.Parse(xmldoc.Document.Root, namespaceMgr);
            return new ChartSpaceDocument(obj);
        }

        public CT_ChartSpace GetChartSpace()
        {
            return chartSpace;
        }

        public void SetChartSpace(CT_ChartSpace chartspace)
        {
            this.chartSpace = chartspace;
        }

        public void Save(Stream stream)
        {
            chartSpace.Write(stream);
        }
    }
}