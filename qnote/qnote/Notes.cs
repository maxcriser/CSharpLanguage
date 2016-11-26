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
        private List<Note> notes;
        private List<Note> searchNotes;
        private SortFavourite sortFavourite;
        private SortDone sortDone;
        private Color colorFrameBlue = Color.FromArgb(255, 60, 140, 205);
        private Color colorBackPurple = Color.FromArgb(255, 87, 29, 70);

        private Image sendEnter = Image.FromFile(@"D:\qnote\img\send_enter.png");
        private Image sendLeave = Image.FromFile(@"D:\qnote\img\send_leave.png");


        public Notes(String typePath, String typeName, String username, String password)
        {
            InitializeComponent();
            searchNotes = new List<Note>();
            sortFavourite = new SortFavourite();
            sortDone = new SortDone();

            grid.CellMouseEnter += Grid_CellMouseEnter;
            grid.CellMouseLeave += Grid_CellMouseLeave;

            pictureBox1.MouseEnter += Button_MouseEnter;
            pictureBox2.MouseEnter += Button_MouseEnter;
            label2.MouseEnter += Button_MouseEnter;
            label3.MouseEnter += Button_MouseEnter;
            label4.MouseEnter += Button_MouseEnter;
            label5.MouseEnter += Button_MouseEnter;
            label6.MouseEnter += Button_MouseEnter;
            label7.MouseEnter += Button_MouseEnter;
            label8.MouseEnter += Button_MouseEnter;
            label9.MouseEnter += Button_MouseEnter;
            label10.MouseEnter += Button_MouseEnter;

            pictureBox1.MouseLeave += Button_MouseLeave;
            pictureBox2.MouseLeave += Button_MouseLeave;
            label2.MouseLeave += Button_MouseLeave;
            label3.MouseLeave += Button_MouseLeave;
            label4.MouseLeave += Button_MouseLeave;
            label5.MouseLeave += Button_MouseLeave;
            label6.MouseLeave += Button_MouseLeave;
            label7.MouseLeave += Button_MouseLeave;
            label8.MouseLeave += Button_MouseLeave;
            label9.MouseLeave += Button_MouseLeave;
            label10.MouseLeave += Button_MouseLeave;

            textBox2.Hide();
            Initialize(typePath, typeName, username, password);
        }

        void Initialize(String typePath, String typeName, String username, String password)
        {
            this.typePath = typePath;
            this.typeName = typeName;
            this.username = username;
            this.password = password;

            notes = Backend.notesFilling(typePath, username);
            notes.Sort(sortFavourite);
            notes.Sort(sortDone);
            gridFilling(notes);
        }

        private void Grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }

        private void Grid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MediumPurple;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null && !control.Equals(pictureBox2))
                control.BackColor = Color.Transparent;
            if (control.Equals(pictureBox2))
            {
                if (control != null)
                {
                    pictureBox2.Image = sendLeave;
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;

            if (control != null && !control.Equals(pictureBox2))
            {
                control.BackColor = colorBackPurple;
            }
            if (control.Equals(pictureBox2))
            {
                if (control != null)
                {
                    pictureBox2.Image = sendEnter;
                }
            }
        }

        void gridFilling(List<Note> list)
        {
            grid.Rows.Clear();
            if (notes.Count != 0)
            {
                label11.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                pictureBox5.Show();
                pictureBox6.Hide();
                label1.Hide();
                grid.Show();
                Bitmap icFav;
                Bitmap icFavLine;
                foreach (Note s in list)
                {
                    if (s.favourite)
                    {
                        icFav = SignUp.fav;
                        icFavLine = SignUp.fav_line;
                    }
                    else
                    {
                        icFav = SignUp.unfav;
                        icFavLine = SignUp.unfav_line;
                    }
                    grid.Rows.Add(icFavLine, s.text, SignUp.delete, icFav);
                    if (s.done)
                    {
                        grid[1, grid.RowCount - 1].Style.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Strikeout);
                    }
                    else
                    {
                        grid[1, grid.RowCount - 1].Style.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                    }
                }

            }
            else
            {
                label11.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Show();
                label1.Show();
                grid.Hide();
            }
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
            textBox2.Clear();
            if (e.ColumnIndex.Equals(1))
            {
                if (notes[e.RowIndex].done)
                {
                    notes[e.RowIndex].done = false;
                }
                else
                {
                    notes[e.RowIndex].done = true;
                }
            }
            if (e.ColumnIndex.Equals(3))
            {
                if (notes[e.RowIndex].favourite)
                {
                    notes[e.RowIndex].favourite = false;
                }
                else
                {
                    notes[e.RowIndex].favourite = true;
                }
            }
            if (e.ColumnIndex.Equals(2))
            {
                notes.RemoveAt(e.RowIndex);
            }
            notifyAll(notes, true);
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

        void writeToFile(List<Note> list)
        {
            String curPath = @"D:\qnote\users\" + @username + typePath;
            System.IO.StreamWriter writer = new System.IO.StreamWriter(curPath, false, Encoding.UTF8);
            foreach (Note w in list)
            {
                String textFavourite = "unfav";
                String textDone = "not";
                if (w.favourite)
                {
                    textFavourite = "fav";
                }
                if (w.done)
                {
                    textDone = "done";
                }
                writer.WriteLine(w.text + SignUp.SEPARATOR + textFavourite + SignUp.SEPARATOR + textDone);
            }
            writer.Close();
        }

        void notifyAll(List<Note> list, Boolean writeFlag)
        {
            if (writeFlag)
            {
                writeToFile(list);
            }
            list.Sort(sortFavourite);
            list.Sort(sortDone);
            gridFilling(list);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            String newText = textBox1.Text;
            if (newText != String.Empty)
            {
                Note newNote = new Note(newText, false, false);
                notes.Insert(0, newNote);
                notifyAll(notes, true);
                textBox1.Clear();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            notifyAll(Backend.notesFilling(typePath, username), true);
            MessageBox.Show(DateTime.Now + " время");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox2.Show();
            textBox2.Clear();
            pictureBox3.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox2.Hide();
            pictureBox3.Show();
            notifyAll(Backend.notesFilling(typePath, username), true);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //TODO перевод англоязычной клавиатуры (тупые пользователи)
            String textChanged = textBox2.Text;
            textChanged = textChanged.ToLower();
            if (textChanged != String.Empty)
            {
                for (int i = 0; i < grid.RowCount; i++)
                {
                    String title = grid[1, i].Value.ToString();
                    title = title.ToLower();
                    if (!title.Contains(textBox2.Text))
                    {
                        grid.Rows[i].Visible = false;
                    }
                }
            }
            else
            {
                notifyAll(Backend.notesFilling(typePath, username), true);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Initialize(SignUp.EVERYDAY_TASKS, "EVERYDAY_TASKS", username, password);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            notes.Clear();
            notifyAll(Backend.notesFilling(typePath, username), true);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Initialize(SignUp.ALL, "ALL", username, password);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Initialize(SignUp.WORKLOADS, "WORK", username, password);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Initialize(SignUp.BOOKS_TO_READ, "BOOKS", username, password);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Initialize(SignUp.MOVIES_FOR_VIEWING, "MOVIES", username, password);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Initialize(SignUp.SITE_VISITS, "SITE", username, password);
        }
    }
}
