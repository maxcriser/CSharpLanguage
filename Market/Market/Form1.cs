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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startForm1(Constants.owner);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startForm1(Constants.customer);
        }

        void startForm1(String type)
        {
            this.Hide();
            Signin signin = new Signin(type);
            signin.ShowDialog();
            this.Close();
        }
    }
}
