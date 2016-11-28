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

        Image btnSignUpLeave = Image.FromFile(@"D:\qnote\img\btn_signup_leave.png");
        Image btnSignUpEnter = Image.FromFile(@"D:\qnote\img\btn_signup_enter.png");
        Image btnOkLeave = Image.FromFile(@"D:\qnote\img\btn_ok_leave.png");
        Image btnOkEnter = Image.FromFile(@"D:\qnote\img\btn_ok_enter.png");

        public SignIn()
        {
            InitializeComponent();
            label23.ForeColor = Color.Maroon;

            pictureBox1.MouseEnter += PictureBox1_MouseEnter;
            pictureBox1.MouseLeave += PictureBox1_MouseLeave;

            pictureBox2.MouseEnter += PictureBox2_MouseEnter;
            pictureBox2.MouseLeave += PictureBox2_MouseLeave;
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = btnSignUpLeave;
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = btnSignUpEnter;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = btnOkLeave;
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = btnOkEnter;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String username = textBox2.Text;
            String password = textBox3.Text;
            if (username != String.Empty && password != String.Empty)
            {
                foreach (var w in Backend.ReadProfiles(Constants.PATH))
                {
                    if (w.username.Equals(username) && w.password.Equals(password))
                    {
                        Backend.writeToStatus(username, password, Constants.statusPATH);
                        this.Hide();
                        MainActivity main = new MainActivity(username, password);
                        main.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        label23.Text = Constants.errorSignIn;
                    }
                }
            }
            else
            {
                label23.Text = Constants.errorEmptyField;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label23.Text = String.Empty;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label23.Text = String.Empty;
        }
    }
}
