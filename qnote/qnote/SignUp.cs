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
        public static Dictionary<String, String> profiles;
        public static List<String> statusProfile;

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
            statusProfile = new List<String>();
            checkStatus();
            profiles = new Dictionary<String, String>();
            readProfiles();
        }

        void checkStatus()
        {
            StreamReader stream = new StreamReader(statusPATH, Encoding.GetEncoding(1251));
            while (!stream.EndOfStream)
            {
                String line = stream.ReadLine();
                if (line != String.Empty)
                {
                    statusProfile.Add(line);
                }
            }
            stream.Close();

            if (statusProfile.Count!=0)
            {
                this.Hide();
                MainActivity main = new MainActivity(statusProfile[0], statusProfile[1]);
                main.ShowDialog();
                this.Close();
            }
        }

        void readProfiles()
        {
            StreamReader stream = new StreamReader(PATH, Encoding.GetEncoding(1251));
            while (!stream.EndOfStream)
            {
                String line = stream.ReadLine();
                String[] array = line.Split();
                profiles.Add(key: array[0], value: array[1]);
            }
            stream.Close();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
            this.Close();
        }

        void writeToStatus(String username, String password)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(statusPATH, false);
            writer.WriteLine(username);
            writer.WriteLine(password);
            writer.Close();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && textBox2.Text != String.Empty && textBox3.Text != String.Empty && textBox4.Text != String.Empty)
            {
                if (textBox3.Text == textBox4.Text)
                {
                    if (!profiles.ContainsKey(textBox2.Text))
                    {
                        writeToStatus(textBox2.Text, textBox3.Text);
                        createFolder(textBox2.Text);
                        writeProfileToFile(textBox2.Text, textBox3.Text);
                        this.Hide();
                        MainActivity main = new MainActivity(textBox2.Text, textBox3.Text);
                        main.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        void writeProfileToFile(String username, String password)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(PATH, true);
            writer.WriteLine(username + " " + password);
            writer.Close();
        }

        void createFolder(String username)
        {
            String path = @"D:\qnote\users\";
            String pathFolder = path + @username;
            Directory.CreateDirectory(pathFolder);
            for (int i = 0; i < notesList.Length; i++)
            {
                String pathFile = pathFolder + notesList[i];
                System.IO.StreamWriter writer = new System.IO.StreamWriter(pathFile, true);
                //writer.WriteLine(username);
                writer.Close();
            }
        }
    }
}
