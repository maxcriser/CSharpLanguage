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

    public partial class Notes : Form
    {
        private String typeName;
        private String username;
        private String password;
        private String typePath;
        private List<List<String>> notes;

        public Notes(String typePath, String typeName, String username, String password)
        {
            InitializeComponent();
            this.typePath = typePath;
            this.typeName = typeName;
            this.username = username;
            this.password = password;
            label1.Text = typeName;
            notesFilling(typePath);
            gridFilling(notes);
        }

        void gridFilling(List<List<String>> list)
        {
            grid.Rows.Clear();
            Bitmap icFav;
            Bitmap icFavLine;
            foreach(List<String> s in list)
            {
                if (s[1].Equals("fav"))
                {
                    icFav = SignUp.fav;
                    icFavLine = SignUp.fav_line;
                }
                else
                {
                    icFav = SignUp.unfav;
                    icFavLine = SignUp.unfav_line;
                }
                grid.Rows.Add(icFavLine, s[0], SignUp.delete, icFav);
            }
        }

        void notesFilling(String path)
        {
            notes = new List<List<String>>();

            String curPath = @"D:\qnote\users\" + @username + path;
            StreamReader stream = new StreamReader(curPath, Encoding.GetEncoding(1251));
            while (!stream.EndOfStream)
            {
                String line = stream.ReadLine();
                if (line != String.Empty)
                {
                    String[] sep = line.Split(SignUp.SEPARATOR);
                    List<String> w = new List<String>();
                    w.Add(sep[0]);
                    w.Add(sep[1]);
                    w.Add(sep[2]);
                    notes.Add(w);
                }
            }
            stream.Close();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainActivity main = new MainActivity(username, password);
            main.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(1))
            {
                notes[e.RowIndex][2] = "done";
            }
            if (e.ColumnIndex.Equals(3))
            {
                if (notes[e.RowIndex][1].Equals("fav"))
                {
                    notes[e.RowIndex][1] = "unfav";
                }
                else
                {
                    notes[e.RowIndex][1] = "fav";
                }
            }
            if(e.ColumnIndex.Equals(2))
            {
                notes.RemoveAt(e.RowIndex);
            }
            notifyAll();
        }


        private void Notes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainActivity main = new MainActivity(username, password);
            main.ShowDialog();
            this.Close();
        }

        void writeToFile()
        {
            String curPath = @"D:\qnote\users\" + @username + typePath;
            System.IO.StreamWriter writer = new System.IO.StreamWriter(curPath, false, Encoding.UTF8);
            foreach(List<String> w in notes)
            {
                writer.WriteLine(w[0] + SignUp.SEPARATOR + w[1] + SignUp.SEPARATOR + w[2]);
            }
            writer.Close();
        }

        void notifyAll()
        {
            writeToFile();
            notesFilling(typePath);
            gridFilling(notes);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                List<String> newNote = new List<String>();
                newNote.Add(textBox1.Text);
                newNote.Add("unfav");
                newNote.Add("not");
                notes.Add(newNote);
                notifyAll();
                textBox1.Clear();
            }
        }
    }
}
