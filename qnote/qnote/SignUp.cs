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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
            this.Close();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Hide();
                MainActivity main = new MainActivity(textBox2.Text);
                main.ShowDialog();
                this.Close();
            }
        }
    }
}
