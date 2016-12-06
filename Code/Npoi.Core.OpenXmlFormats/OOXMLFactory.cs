using System;
using System.IO;
using System.Xml.Serialization;

namespace Npoi.Core.OpenXmlFormats
{
    public class OOXMLFactory<T>
    {
        private XmlSerializer serializerObj = null;

        public OOXMLFactory()
        {
            serializerObj = new XmlSerializer(typeof(T));
        }

        public T Parse(Stream stream)
        {
            T obj = (T)serializerObj.Deserialize(stream);
            stream.Dispose();
            return obj;
        }

        public T Create()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}