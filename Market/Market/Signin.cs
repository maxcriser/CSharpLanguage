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
    public partial class Signin : Form
    {
        String client;
        public static List<User> profiles = new List<User>();

        public Signin(String client)
        {
            InitializeComponent();
            this.client = client;
            if (client.Equals(Constants.owner))
            {
                label1.Text = "Login (admin):";
                label2.Text = "Password (admin):";
                button1.Hide();
                ReadUsers(Constants.ownerPATH + @"admin.xml");         
            }
            else
            {
                label1.Text = "Login:";
                label2.Text = "Password:";
                ReadUsers(Constants.ownerPATH + @"users.xml");
            }
        }

        void ReadUsers(String PATH)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(PATH);

            foreach (XmlNode item in xdoc.DocumentElement)
            {
                string username = item.Attributes["username"].Value;
                string password = item.Attributes["password"].Value;
                profiles.Add(new User(username, password));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (User u in profiles)
            {
                if (u.username.Equals(textBox1.Text) && u.password.Equals(textBox2.Text))
                {
                    if (client.Equals(Constants.owner))
                    {
                        this.Hide();
                        AdminPanel adminPanel = new AdminPanel();
                        adminPanel.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                        Shop shop = new Shop(textBox1.Text, textBox2.Text);
                        shop.ShowDialog();
                        this.Close();
                    }
                }
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.ShowDialog();
            this.Close();
        }
    }
}
