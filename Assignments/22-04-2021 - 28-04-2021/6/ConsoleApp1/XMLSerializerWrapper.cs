using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class XMLSerializerWrapper
    {
        public XMLSerializerWrapper()
        {
        }

        public void Serialize<T>(T obj, string path)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            TextWriter writer = new StreamWriter(path);
            ser.Serialize(writer, obj);
            writer.Close();
        }

        public T Deserialize<T>(string path)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));

            if (!File.Exists(path))
            {
                throw new Exception($"Given file in path '{path}' does not exist");
            }

            TextReader reader = new StreamReader(path);
            var obj = (T)ser.Deserialize(reader);
            reader.Close();

            return obj;
        }

       
    }
}
