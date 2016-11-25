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
            String username = textBox2.Text;
            String password = textBox3.Text;
            if (username != String.Empty && password != String.Empty)
            {
                foreach (var w in Backend.ReadProfiles(SignUp.PATH))
                {
                    if (w.username.Equals(username) && w.password.Equals(password))
                    {
                        Backend.writeToStatus(username, password, SignUp.statusPATH);
                        this.Hide();
                        MainActivity main = new MainActivity(username, password);
                        main.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}
