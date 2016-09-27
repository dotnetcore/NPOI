using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
    public class StylesDocument
    {
        CT_Styles styles = null;
        public StylesDocument()
        {
            styles = new CT_Styles();
        }
        public static StylesDocument Parse(XDocument doc, XmlNamespaceManager namespaceMgr)
        {
            CT_Styles obj = CT_Styles.Parse(doc.Document.Root, namespaceMgr);
            return new StylesDocument(obj);
        }
        public StylesDocument(CT_Styles styles)
        {
            this.styles = styles;
        }
        public CT_Styles Styles
        {
            get
            {
                return this.styles;
            }
        }
        public void Save(Stream stream)
        {
            using (StreamWriter sw = new StreamWriter(stream))
            {
                styles.Write(sw);
            }
        }
    }
}
