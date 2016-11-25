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
        public static char SEPARATOR = '|';
        public static string folderPATH = @"D:\qnote\";
        public static string PATH = @"D:\qnote\profiles.txt";
        public static string statusPATH = @"D:\qnote\status.txt";
        static List<User> profiles = new List<User>();
        List<User> statusProfile = new List<User>();

        public static string ALL = @"\all.txt";
        public static string WORKLOADS = @"\workloads.txt";
        public static string EVERYDAY_TASKS = @"\everyday_tasks.txt";
        public static string BOOKS_TO_READ = @"\books_to_read.txt";
        public static string MOVIES_FOR_VIEWING = @"\movies_for_viewing.txt";
        public static string SITE_VISITS = @"\site_visits.txt";
        public static Bitmap fav = new Bitmap(@"D:\qnote\img\fav.png");
        public static Bitmap unfav = new Bitmap(@"D:\qnote\img\unfav.png");
        public static Bitmap fav_line = new Bitmap(@"D:\qnote\img\fav_line.png");
        public static Bitmap unfav_line = new Bitmap(@"D:\qnote\img\unfav_line.png");
        public static Bitmap delete = new Bitmap(@"D:\qnote\img\delete.png");

        String[] notesList = {
            ALL,
            WORKLOADS,
            EVERYDAY_TASKS,
            BOOKS_TO_READ,
            MOVIES_FOR_VIEWING,
            SITE_VISITS
        };

        public SignUp()
        {
            InitializeComponent();
            profiles = Backend.ReadProfiles(PATH);
            checkStatus();
        }

        void checkStatus()
        {
            statusProfile = Backend.ReadProfiles(statusPATH);
            
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
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
            this.Close();
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
            String username = textBox2.Text;
            String password = textBox3.Text;
            String passwordConfirm = textBox4.Text;

            if (checkBox1.Checked && username != String.Empty && password != String.Empty && passwordConfirm != String.Empty)
            {
                if (password == passwordConfirm)
                {
                    if (checkForUsers(username))
                    {
                        Backend.writeToStatus(username, password, statusPATH);
                        Backend.createFolder(username, notesList);
                        Backend.writeProfileToFile(username, password, PATH);
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
