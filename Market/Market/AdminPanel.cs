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
        private List<Disc> listDiscs;

        public AdminPanel()
        {
            InitializeComponent();
            listDiscs = new List<Disc>();
            //XMLEditor.CreateXml(Constants.ownerPATH + discs
            LoadDiscs();
            notifyGridDiscs(listDiscs);

        }

        private void LoadDiscs()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Constants.ownerPATH + discs);

            foreach (XmlNode item in xdoc.DocumentElement)
            {
                string name = item.Attributes["name"].Value;
                string state = item.Attributes["state"].Value;
                listDiscs.Add(new Disc(name, state));
            }
        }

        void notifyGridDiscs(List<Disc> list)
        {
            gridDiscs.Rows.Clear();
            foreach(Disc w in list)
            {
                gridDiscs.Rows.Add(w.name, w.state, "delete");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(String.Empty))
            {
                listDiscs.Add(new Disc(textBox1.Text, Constants.instock));

                writeToXmlDiscs();
                
                notifyGridDiscs(listDiscs);
            }
        }

        void writeToXmlDiscs()
        {
            XmlTextWriter writer = new XmlTextWriter(Constants.ownerPATH + discs, Encoding.UTF8);
            writer.WriteStartDocument();

            writer.WriteStartElement("Discs");
            for (int i = 0; i < listDiscs.Count; i++)
            {
                writer.WriteStartElement("disc");
                writer.WriteAttributeString("name", listDiscs[i].name);
                writer.WriteAttributeString("state", listDiscs[i].state);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridDiscs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(2))
            {
                listDiscs.RemoveAt(e.RowIndex);
                notifyGridDiscs(listDiscs);
                writeToXmlDiscs();
            }
        }
    }
}
