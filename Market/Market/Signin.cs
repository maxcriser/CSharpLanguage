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
    public partial class Signin : Form
    {
        String client;
        

        public Signin(String client)
        {
            InitializeComponent();
            this.client = client;
            String login;
            String password;
            if (client.Equals(Constants.owner))
            {
                label1.Text = "Login (admin):";
                label2.Text = "Password (admin):";
                button1.Hide();
            }
            else
            {
                label1.Text = "Login:";
                label2.Text = "Password:";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                this.Hide();
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.ShowDialog();
                this.Close();
            }
        }
    }
}
