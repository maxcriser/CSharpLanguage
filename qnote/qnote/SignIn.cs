using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace qnote
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != String.Empty && textBox3.Text != String.Empty)
            {
                foreach (var w in SignUp.profiles)
                {
                    if (w.Key.Equals(textBox2.Text) && w.Value.Equals(textBox3.Text))
                    {
                        writeToStatus(textBox2.Text, textBox3.Text);
                        this.Hide();
                        MainActivity main = new MainActivity(textBox2.Text, textBox3.Text);
                        main.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        void writeToStatus(String username, String password)
        {
            //TODO maybe ex
            System.IO.StreamWriter writer = new System.IO.StreamWriter(SignUp.statusPATH, false);
            writer.WriteLine(username);
            writer.WriteLine(password);
            writer.Close();
        }
    }
}
