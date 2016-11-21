using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qnote
{
    public partial class Notes : Form
    {
        private String type;
        private String username;

        public Notes(String type, String username)
        {
            InitializeComponent();
            this.type = type;
            this.username = username;
            label1.Text = type;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainActivity main = new MainActivity(username);
            main.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
