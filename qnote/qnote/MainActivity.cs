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
    public partial class MainActivity : Form
    {
        private String userName;

        public MainActivity(String userName)
        {
            InitializeComponent();
            this.userName = userName;
            label2.Text = userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startNotes(button1.Text);
        }

        private void startNotes(String type)
        {
            this.Hide();
            Notes main = new Notes(type, userName);
            main.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startNotes(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            startNotes(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            startNotes(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            startNotes(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            startNotes(button6.Text);
        }
    }
}
