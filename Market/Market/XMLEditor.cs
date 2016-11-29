using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Market
{
    class XMLEditor
    {
        public static void CreateXml(String path)
        {
            XmlTextWriter textWritter = new XmlTextWriter(path, Encoding.UTF8);
            textWritter.WriteStartDocument();
            textWritter.WriteStartElement("head");
            textWritter.WriteEndElement();
            textWritter.Close();
        }
    }
}
