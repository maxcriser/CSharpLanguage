using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Market
{
    public partial class AdminPanel : Form
    {
        private string discs = @"discs.xml";
        private List<Disc> listDiscs = new List<Disc>();

        public AdminPanel()
        {
            InitializeComponent();
            XMLEditor.CreateXml(Constants.ownerPATH + discs);
            XmlToListDisc();
            LoadDiscs();
            GridFilling(listDiscs);

        }

        private void LoadDiscs()
        {
            XmlReader xml = XmlReader.Create(Constants.ownerPATH + discs);
            //xml.MoveToFirstAttribute();
            //if (xml.HasAttributes)
            //{
            //    while (xml.MoveToNextAttribute())
            //    {
                    listDiscs.Add(new Disc(xml.Name, xml.Value));
            //    }
            //}

        }

        void GridFilling(List<Disc> list)
        {
            foreach(var w in list)
            {
                gridDiscs.Rows.Add(w.name, w.state);
            }
        }

        void XmlToListDisc()
        {
            for(int i = 0; i<10; i++)
            {
                Disc d = new Disc("disc_" + i, Constants.instock);
                listDiscs.Add(d);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(String.Empty))
            {
                XmlDocument document = new XmlDocument();
                document.Load(Constants.ownerPATH + discs);

                XmlNode element = document.CreateElement("disc");
                document.DocumentElement.AppendChild(element);
                XmlAttribute attribute = document.CreateAttribute("name");
                attribute.Value = textBox1.Text;
                element.Attributes.Append(attribute);

                XmlNode state = document.CreateElement("state");
                state.InnerText = Constants.instock;
                element.AppendChild(state);

                document.Save(Constants.ownerPATH + discs);

                textBox1.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
