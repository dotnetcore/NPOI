using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Npoi.Core.OpenXmlFormats.Wordprocessing
{
    public class EndnotesDocument
    {
        private CT_Endnotes endnotes = null;

        public EndnotesDocument()
        {
        }

        public static EndnotesDocument Parse(XDocument doc, XmlNamespaceManager namespaceMgr)
        {
            CT_Endnotes obj = CT_Endnotes.Parse(doc.Document.Root, namespaceMgr);
            return new EndnotesDocument(obj);
        }

        public EndnotesDocument(CT_Endnotes endnotes)
        {
            this.endnotes = endnotes;
        }

        public CT_Endnotes Endnotes
        {
            get
            {
                return this.endnotes;
            }
        }

        public void Save(Stream stream)
        {
            using (StreamWriter sw = new StreamWriter(stream))
            {
                this.endnotes.Write(sw);
            }
        }
    }
}