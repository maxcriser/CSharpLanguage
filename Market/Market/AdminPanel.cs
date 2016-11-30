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
            listDiscs = Backend.LoadDiscs();
            notifyGridDiscs(listDiscs);
        }

        void notifyGridDiscs(List<Disc> list)
        {
            gridDiscs.Rows.Clear();
            foreach(Disc w in list)
            {
                gridDiscs.Rows.Add(w.name, w.state, w.who, "remove");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(String.Empty))
            {
                listDiscs.Add(new Disc(textBox1.Text, Constants.instock, "shop.com"));
                Backend.writeToXmlDiscs(listDiscs);
                notifyGridDiscs(listDiscs);
                textBox1.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridDiscs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(3))
            {
                listDiscs.RemoveAt(e.RowIndex);
                notifyGridDiscs(listDiscs);
                Backend.writeToXmlDiscs(listDiscs);
            }
        }
    }
}
