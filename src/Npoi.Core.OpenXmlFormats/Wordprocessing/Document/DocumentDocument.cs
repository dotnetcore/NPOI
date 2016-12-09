using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Npoi.Core.OpenXmlFormats.Wordprocessing
{
    public class DocumentDocument
    {
        private CT_Document document = null;

        public DocumentDocument()
        {
        }

        public static DocumentDocument Parse(XDocument doc, XmlNamespaceManager namespaceMgr)
        {
            CT_Document obj = CT_Document.Parse(doc.Document.Root, namespaceMgr);
            return new DocumentDocument(obj);
        }

        public DocumentDocument(CT_Document document)
        {
            this.document = document;
        }

        public CT_Document Document
        {
            get
            {
                return this.document;
            }
        }

        public void Save(Stream stream)
        {
            using (StreamWriter sw = new StreamWriter(stream))
            {
                document.Write(sw);
            }
        }
    }
}