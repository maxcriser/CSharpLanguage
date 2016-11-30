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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        Boolean checkUsers(String username2)
        {
            foreach (User w in Signin.profiles)
            {
                if (username2.Equals(w.username))
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty && checkUsers(textBox1.Text))
            {
                User d = new User(textBox1.Text, textBox2.Text);

                Signin.profiles.Add(d);

                XmlTextWriter writer = new XmlTextWriter(Constants.ownerPATH + @"users.xml", Encoding.UTF8);
                writer.WriteStartDocument();

                writer.WriteStartElement("Users");
                for (int i = 0; i < Signin.profiles.Count; i++)
                {
                    writer.WriteStartElement("user");
                    writer.WriteAttributeString("username", Signin.profiles[i].username);
                    writer.WriteAttributeString("password", Signin.profiles[i].password);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

                this.Hide();
                Shop shop = new Shop(textBox1.Text, textBox2.Text);
                shop.ShowDialog();
                this.Close();
            }

            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin signin = new Signin(Constants.customer);
            signin.ShowDialog();
            this.Close();
        }
    }
}