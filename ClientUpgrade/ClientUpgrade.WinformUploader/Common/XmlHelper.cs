using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClientUpgrade.WinformUploader.Common
{
    public static class XmlHelper
    {
        private static XmlSerializerFactory xmlSerializerFactory = new XmlSerializerFactory();
        public static T Deserialize<T>(Stream stream)
        {
            var serializer = xmlSerializerFactory.CreateSerializer(typeof(T));
            using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8))
            {
                return (T)serializer.Deserialize(streamReader);
            }
        }

        public static void Serialize<T>(Stream stream,T obj)
        {
            var serializer = xmlSerializerFactory.CreateSerializer(typeof(T));
            serializer.Serialize(stream, obj);
        }
    }
}
