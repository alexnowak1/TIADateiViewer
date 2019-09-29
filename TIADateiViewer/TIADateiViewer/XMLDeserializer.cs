using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace TIADateiViewer
{
    public class XMLDeserializer
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public T Deserialize<T>(string input) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        public void TestDeserialize(string Path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(tiaselectiontool));
            tiaselectiontool res = new tiaselectiontool();
            res = (tiaselectiontool)serializer.Deserialize(new XmlTextReader(Path));
        }
    }
}
