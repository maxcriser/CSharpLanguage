using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class Shop : Form
    {
        String username;
        String password;
        List<Disc> listDiscs = new List<Disc>();

        public Shop(String username, String password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            listDiscs = Backend.LoadDiscs();
            notifyGridTake(listDiscs);
            notiFyGridMy(listDiscs);
            HideRowsGridMy();
        }

        void notiFyGridMy(List<Disc> list)
        {
            gridDiscsMy.Rows.Clear();
            foreach(Disc item in list)
            {
                String s = item.who;
                String[] d = { "shop.by", "None" };
                if (s != "shop.by")
                {
                    String[] d = item.who.Split(new char[] { '[' }, StringSplitOptions.RemoveEmptyEntries);
                    String date = d[1];
                }
                gridDiscsMy.Rows.Add(item.name, date[0], date, "RETURN");
            }
        }

        void HideRowsGridMy()
        {
            for (int i = 0; i < gridDiscsMy.RowCount; i++)
            {
                if(!gridDiscsMy[1, i].Value.Equals(username))
                {
                    gridDiscsMy.Rows[i].Visible = false;
                }
            }
        }

        void notifyGridTake(List<Disc> list)
        {
            gridDiscsTake.Rows.Clear();
            foreach(Disc item in list)
            {
                gridDiscsTake.Rows.Add(item.name, item.state, item.who, "TAKE");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gridDiscsTake_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(3))
            {
                if(gridDiscsTake[1, e.RowIndex].Value.Equals(Constants.instock))
                {
                    listDiscs[e.RowIndex].who = username + "[" + DateTime.Now.AddDays(10).ToString("dd MMMM yyyy") + "]";
                    listDiscs[e.RowIndex].state = Constants.notavailable;
                    notifyGridTake(listDiscs);
                    Backend.writeToXmlDiscs(listDiscs);
                }
            }
        }
    }
}
