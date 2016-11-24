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
        public static List<String> curProfile;
        public static char SEPARATOR = '|';
        public static string ALL = @"\all.txt";
        public static string WORKLOADS = @"\workloads.txt";
        public static string EVERYDAY_TASKS = @"\everyday_tasks.txt";
        public static string BOOKS_TO_READ = @"\books_to_read.txt";
        public static string MOVIES_FOR_VIEWING = @"\movies_for_viewing.txt";
        public static string SITE_VISITS = @"\site_visits.txt";
        public static string path = @"D:\qnote\users\";
        public static string pathCurProfile = @"D:\qnote\status.txt";
        public static Color toolbarColor = Color.FromArgb(255, 19, 89, 149);
        public static Color frameLineColor = Color.FromArgb(255, 75, 147, 206);
        public static Color backColor = Color.FromArgb(255, 241, 241, 241);
        public static Color eventColor = Color.FromArgb(255, 204, 227, 245);
        public static Color whiteColor = Color.FromArgb(255, 249, 249, 249);
        public static Color favColor = Color.FromArgb(255, 16, 110, 190);
        public static Color secTextColor = Color.FromArgb(255, 80, 80, 80);
        public static Color selectPage = Color.FromArgb(255, 5, 80, 146);
        public static Color backBackgroundPage = Color.FromArgb(255, 0, 91, 158);
        public static Color backgroundDoneRow = Color.FromArgb(255, 179, 238, 147);
        public static Color backgroundSelectRow = Color.FromArgb(255, 179, 214, 242);

        String[] notesList = {
            WORKLOADS,
            EVERYDAY_TASKS,
            BOOKS_TO_READ,
            MOVIES_FOR_VIEWING,
            SITE_VISITS
        };

        String PATH = @"D:\qnote\profiles.txt";
        public static Dictionary<String, String> profiles;

        public SignUp()
        {
            InitializeComponent();
            profiles = new Dictionary<String, String>();
            readProfiles();
            curProfile = new List<String>();
            readCurProfile();
            checkStartProfile();
        }

        void readCurProfile()
        {
            StreamReader stream = new StreamReader(pathCurProfile, Encoding.GetEncoding(1251));
            while (!stream.EndOfStream)
            {
                String line = stream.ReadLine();
                if (line != String.Empty)
                    curProfile.Add(line);
            }
            stream.Close();
        }

        void checkStartProfile()
        {
            if (curProfile.Count != 0)
            {
                this.Hide();
                MainActivity main = new MainActivity(curProfile[0], curProfile[1]);
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

        private void signup_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && textBox2.Text != String.Empty && textBox3.Text != String.Empty && textBox4.Text != String.Empty)
            {
                if (textBox3.Text == textBox4.Text)
                {
                    if (!profiles.ContainsKey(textBox2.Text))
                    {
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
            System.IO.StreamWriter writer = new System.IO.StreamWriter(PATH, true, Encoding.UTF8);
            writer.WriteLine(username + " " + password);
            writer.Close();
        }

        void createFolder(String username)
        {
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
