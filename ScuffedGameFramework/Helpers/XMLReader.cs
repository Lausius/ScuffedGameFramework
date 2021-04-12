using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScuffedGameFramework.Helpers
{
    public class XMLReader
    {
        public class XmlLog
        {
            public Area MaxX { get; set; }
            public Area MaxY { get; set; }
            public XmlLog()
            {

            }
        }

        public static T ReadWorldConfiguration<T>()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T),
                new XmlRootAttribute("WorldConfiguration"));
            StreamReader reader = new StreamReader("WorldConfiguration.xml");
            var x = (T)xmlSerializer.Deserialize(reader);
            reader.Close();

            return x;
        }
    }
}
