using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Market
{
    class Backend
    {
        public static void writeToXmlDiscs(List<Disc> list)
        {
            XmlTextWriter writer = new XmlTextWriter(Constants.ownerPATH + @"discs.xml", Encoding.UTF8);
            writer.WriteStartDocument();

            writer.WriteStartElement("Discs");
            for (int i = 0; i < list.Count; i++)
            {
                writer.WriteStartElement("disc");
                writer.WriteAttributeString("name", list[i].name);
                writer.WriteAttributeString("state", list[i].state);
                writer.WriteAttributeString("who", list[i].who);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        public static List<Disc> LoadDiscs()
        {
            List<Disc> newList = new List<Disc>();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Constants.ownerPATH + @"discs.xml");

            foreach (XmlNode item in xdoc.DocumentElement)
            {
                string name = item.Attributes["name"].Value;
                string state = item.Attributes["state"].Value;
                string who = item.Attributes["who"].Value;
                newList.Add(new Disc(name, state, who));
            }
            return newList;
        }
    }
}
