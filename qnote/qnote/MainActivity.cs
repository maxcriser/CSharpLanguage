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
        private String password;

        public MainActivity(String userName,String password)
        {
            InitializeComponent();
            this.userName = userName;
            this.password = password;
            label2.Text = userName;
            rewriteCurProfile(userName, password);
        }

        void rewriteCurProfile(String curUsername, String curPassword)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            startNotes(button1.Text, SignUp.ALL);
        }

        private void startNotes(String type, String pathNotes)
        {
            this.Hide();
            Notes main = new Notes(type, userName, password, pathNotes);
            main.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startNotes(button2.Text, SignUp.WORKLOADS);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            startNotes(button3.Text, SignUp.EVERYDAY_TASKS);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            startNotes(button4.Text, SignUp.BOOKS_TO_READ);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            startNotes(button5.Text, SignUp.MOVIES_FOR_VIEWING);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            startNotes(button6.Text, SignUp.SITE_VISITS);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn logOut = new SignIn();
            logOut.ShowDialog();
            this.Close();
        }
    }
}
