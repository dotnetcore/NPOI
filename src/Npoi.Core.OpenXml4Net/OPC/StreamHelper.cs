using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Npoi.Core.OpenXml4Net.OPC
{
    public class StreamHelper
    {
        private StreamHelper()
        {
            // Do nothing
        }

        /**
         * Turning the DOM4j object in the specified output stream.
         *
         * @param xmlContent
         *            The XML document.
         * @param outStream
         *            The Stream in which the XML document will be written.
         * @return <b>true</b> if the xml is successfully written in the stream,
         *         else <b>false</b>.
         */

        public static void SaveXmlInStream(XDocument xmlContent,
                Stream outStream)
        {
            //XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlContent.NameTable);
            //nsmgr.AddNamespace("", "");
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            settings.OmitXmlDeclaration = false;
            XmlWriter writer = XmlWriter.Create(outStream, settings);
            xmlContent.WriteTo(writer);
            writer.Flush();
            //XmlWriter writer = new XmlTextWriter(outStream,Encoding.UTF8);

            // For debugging the migration from .NET to .NET Core
            //var outFile = @"D:\temp\excel\out.new.xml";
            //using (var fs = new FileStream(outFile, FileMode.Create))
            //      {
            //          XmlWriter fswriter = XmlWriter.Create(fs, settings);
            //          xmlContent.WriteTo(fswriter);
            //          fswriter.Flush();
            //      }
            //if (File.ReadAllText(outFile).Contains("dcterms:created"))
            //{
            //}
        }

        /**
         * Copy the input stream into the output stream.
         *
         * @param inStream
         *            The source stream.
         * @param outStream
         *            The destination stream.
         * @return <b>true</b> if the operation succeed, else return <b>false</b>.
         */

        public static void CopyStream(Stream inStream, Stream outStream)
        {
            byte[] buffer = new byte[1024];
            int bytesRead = 0;
            int totalRead = 0;
            while ((bytesRead = inStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                outStream.Write(buffer, 0, bytesRead);
                totalRead += bytesRead;
            }
        }
    }
}