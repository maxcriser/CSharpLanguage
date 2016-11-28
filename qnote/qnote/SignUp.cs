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
    public partial class SignUp : Form
    {
        private string wantToSignText = "Want to sign up fill out this form!";
        private string errorUsername = "This username is already registered.";
        private string errorPassword = "Passwords do not match, please\ntry again.";
        private string errorAccept = "You must accept the conditions of\nregistration.";
        static List<User> profiles = new List<User>();
        List<User> statusProfile = new List<User>();

        String[] notesList = {
            Constants.ALL,
            Constants.WORKLOADS,
            Constants.EVERYDAY_TASKS,
            Constants.BOOKS_TO_READ,
            Constants.MOVIES_FOR_VIEWING,
            Constants.SITE_VISITS
        };

        public SignUp()
        {
            InitializeComponent();
            this.textBox2.HidePromptOnLeave = true;
            profiles = Backend.ReadProfiles(Constants.PATH);
            checkStatus();
            pictureBox2.MouseEnter += PictureBox2_MouseEnter;
            pictureBox1.MouseEnter += PictureBox1_MouseEnter;

            pictureBox2.MouseLeave += PictureBox2_MouseLeave;
            pictureBox1.MouseLeave += PictureBox1_MouseLeave;

            textBox2.TextChanged += TextBox2_TextChanged;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = wantToSignText;
            label2.ForeColor = Color.White;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\qnote\img\btn_ok_leave.png");
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"D:\qnote\img\btn_signin_leave.png");
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\qnote\img\btn_ok_enter.png");
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"D:\qnote\img\btn_signin_enter.png");
        }

        void checkStatus()
        {
            statusProfile = Backend.ReadProfiles(Constants.statusPATH);
            
            if (statusProfile.Count!=0)
            {
                this.Hide();
                MainActivity main = new MainActivity(statusProfile[0].username, statusProfile[0].password);
                main.ShowDialog();
                this.Close();
            }
        }

        private void signin_Click(object sender, EventArgs e)
        {
            
        }

        private Boolean checkForUsers(String username)
        {
            foreach(User w in profiles)
            {
                if (w.username.Equals(username))
                {
                    return false;
                }
            }
            return true;
        }

        private void signup_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String username = textBox2.Text;
            String password = textBox3.Text;
            String passwordConfirm = textBox4.Text;

            if (username != String.Empty && password != String.Empty && passwordConfirm != String.Empty)
            {
                if (checkBox1.Checked)
                {
                    if (password == passwordConfirm)
                    {
                        if (checkForUsers(username))
                        {
                            Backend.writeToStatus(username, password, Constants.statusPATH);
                            Backend.createFolder(username, notesList);
                            Backend.writeProfileToFile(username, password, Constants.PATH);
                            this.Hide();
                            MainActivity main = new MainActivity(username, password);
                            main.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            label2.Text = errorUsername;
                            label2.ForeColor = Color.Maroon;
                        }
                    }
                    else
                    {
                        label2.Text = errorPassword;
                        label2.ForeColor = Color.Maroon;
                    }
                }
                else
                {
                    label2.Text = errorAccept;
                    label2.ForeColor = Color.Maroon;
                }
            }
            else
            {
                label2.Text = Constants.errorEmptyField;
                label2.ForeColor = Color.Maroon;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
            this.Close();
        }

        private void textBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label2.Text = wantToSignText;
            label2.ForeColor = Color.White;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label2.Text = wantToSignText;
            label2.ForeColor = Color.White;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = wantToSignText;
            label2.ForeColor = Color.White;
        }
    }
}
