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
        private Image leaveALL = Image.FromFile(@"D:\qnote\img\btn_any_notes_leave.png");
        private Image leaveWORK = Image.FromFile(@"D:\qnote\img\btn_workloads_leave.png");
        private Image leaveEveryDay = Image.FromFile(@"D:\qnote\img\btn_every_day_leave.png");
        private Image leaveBooks = Image.FromFile(@"D:\qnote\img\btn_books_leave.png");
        private Image leaveMovies = Image.FromFile(@"D:\qnote\img\btn_movies_leave.png");
        private Image leaveTravels = Image.FromFile(@"D:\qnote\img\btn_travels_leave.png");
        private Image leaveLogOut = Image.FromFile(@"D:\qnote\img\btn_log_out_leave.png");

        private Image enterALL = Image.FromFile(@"D:\qnote\img\btn_any_notes_enter.png");
        private Image enterWORK = Image.FromFile(@"D:\qnote\img\btn_workloads_enter.png");
        private Image enterEveryDay = Image.FromFile(@"D:\qnote\img\btn_every_day_enter.png");
        private Image enterBooks = Image.FromFile(@"D:\qnote\img\btn_books_enter.png");
        private Image enterMovies = Image.FromFile(@"D:\qnote\img\btn_movies_enter.png");
        private Image enterTravels = Image.FromFile(@"D:\qnote\img\btn_travels_enter.png");
        private Image enterLogOut = Image.FromFile(@"D:\qnote\img\btn_log_out_enter.png");
        public static List<List<String>> notesWorkloads;

        public MainActivity(String userName, String password)
        {
            InitializeComponent();
            label1.Text = userName + ", it's time to create notes.";
            this.userName = userName;
            this.password = password;
            notesWorkloads = new List<List<String>>();

            pictureBox1.MouseEnter += button_Enter;
            pictureBox1.MouseLeave += button_Leave;

            pictureBox2.MouseEnter += button_Enter;
            pictureBox2.MouseLeave += button_Leave;

            pictureBox3.MouseEnter += button_Enter;
            pictureBox3.MouseLeave += button_Leave;

            pictureBox4.MouseEnter += button_Enter;
            pictureBox4.MouseLeave += button_Leave;
            
            pictureBox8.MouseEnter += button_Enter;
            pictureBox8.MouseLeave += button_Leave;

            pictureBox9.MouseEnter += button_Enter;
            pictureBox9.MouseLeave += button_Leave;

            pictureBox10.MouseEnter += button_Enter;
            pictureBox10.MouseLeave += button_Leave;
        }

        private void button_Leave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control == pictureBox1)
            {
                pictureBox1.Image = leaveALL;
            }
            else if (control == pictureBox2)
            {
                pictureBox2.Image = leaveWORK;
            }
            else if (control == pictureBox3)
            {
                pictureBox3.Image = leaveEveryDay;
            }
            else if (control == pictureBox4)
            {
                pictureBox4.Image = leaveBooks;
            }
            else if (control == pictureBox8)
            {
                pictureBox8.Image = leaveMovies;
            }
            else if (control == pictureBox9)
            {
                pictureBox9.Image = leaveTravels;
            }
            else if (control == pictureBox10)
            {
                pictureBox10.Image = leaveLogOut;
            }
        }

        private void button_Enter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control == pictureBox1)
            {
                pictureBox1.Image = enterALL;
            }
            else if (control == pictureBox2)
            {
                pictureBox2.Image = enterWORK;
            }
            else if (control == pictureBox3)
            {
                pictureBox3.Image = enterEveryDay;
            }
            else if (control == pictureBox4)
            {
                pictureBox4.Image = enterBooks;
            }
            else if (control == pictureBox8)
            {
                pictureBox8.Image = enterMovies;
            }
            else if (control == pictureBox9)
            {
                pictureBox9.Image = enterTravels;
            }
            else if (control == pictureBox10)
            {
                pictureBox10.Image = enterLogOut;
            }
        }

        void readNotesWorkloads()
        {
            //SignUp.WORKLOADS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void startNotes(String typeName, String typePath)
        {
            this.Hide();
            Notes main = new Notes(typePath, typeName, userName, password);
            main.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            startNotes(Constants.anyNotes, Constants.ALL);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            startNotes(Constants.workloads, Constants.WORKLOADS);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            startNotes(Constants.everydayTasks, Constants.EVERYDAY_TASKS);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            startNotes(Constants.booksToRead, Constants.BOOKS_TO_READ);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            startNotes(Constants.moviesForViewing, Constants.MOVIES_FOR_VIEWING);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            startNotes(Constants.travels, Constants.SITE_VISITS);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(Constants.statusPATH, false, Encoding.UTF8);
            writer.Close();
            this.Hide();
            SignIn inS = new SignIn();
            inS.ShowDialog();
            this.Close();
        }
    }
}
