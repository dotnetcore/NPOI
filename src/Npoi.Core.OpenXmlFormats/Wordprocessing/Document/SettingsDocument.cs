using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Npoi.Core.OpenXmlFormats.Wordprocessing
{
    public class SettingsDocument
    {
        private CT_Settings settings = null;

        public SettingsDocument()
        {
            settings = new CT_Settings();
        }

        public static SettingsDocument Parse(XDocument doc, XmlNamespaceManager NameSpaceManager)
        {
            CT_Settings obj = CT_Settings.Parse(doc.Document.Root, NameSpaceManager);
            return new SettingsDocument(obj);
        }

        public void Save(Stream stream)
        {
            using (StreamWriter sw = new StreamWriter(stream))
            {
                settings.Write(sw);
            }
        }

        public SettingsDocument(CT_Settings settings)
        {
            this.settings = settings;
        }

        public CT_Settings Settings
        {
            get
            {
                return this.settings;
            }
        }
    }
}