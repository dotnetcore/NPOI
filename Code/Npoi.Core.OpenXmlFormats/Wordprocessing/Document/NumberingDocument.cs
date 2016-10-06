using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Npoi.Core.OpenXmlFormats.Wordprocessing
{

    public class NumberingDocument
    {
        CT_Numbering numbering = null;
        public NumberingDocument()
        {
            numbering = new CT_Numbering();
        }
        public NumberingDocument(CT_Numbering numbering)
        {
            this.numbering = numbering;
        }
        public CT_Numbering Numbering
        {
            get
            {
                return this.numbering;
            }
        }
        public void Save(Stream stream)
        {
            using (StreamWriter sw = new StreamWriter(stream))
            {
                numbering.Write(sw);
            }
        }

        public static NumberingDocument Parse(XDocument doc, XmlNamespaceManager NameSpaceManager)
        {
            CT_Numbering obj = CT_Numbering.Parse(doc.Document.Root, NameSpaceManager);
            return new NumberingDocument(obj);
        }
    }
}
