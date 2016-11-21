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
        String PATH = @"D:\qnote\profiles.txt";
        Dictionary<String, String> profiles;

        public SignIn()
        {
            InitializeComponent();
        }

        void readProfiles()
        {
            StreamReader stream = new StreamReader(PATH, Encoding.GetEncoding(1251));
            while (!stream.EndOfStream)
            {
                String line = stream.ReadLine().ToLower();
                String[] array = line.Split();
                profiles.Add(key: array[0], value: array[1]);
            }
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
            foreach (var w in profiles)
            {
                if (w.Key.Equals(textBox2.Text) && w.Value.Equals(textBox3.Text))
                {
                    this.Hide();
                    MainActivity main = new MainActivity(textBox2.Text);
                    main.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
