using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace qnote
{
    
    class Constants
    {
        public static string errorEmptyField = "Please fill in all fields.";
        public static string errorSignIn = "Please check your username or\npassword and try again.";
        public static char SEPARATOR = '|';
        public static string folderPATH = @"D:\qnote\";
        public static string PATH = @"D:\qnote\profiles.txt";
        public static string statusPATH = @"D:\qnote\status.txt";
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
        public static string travels = "Travels";
        public static string workloads = "Workloads";
        public static string booksToRead = "Books to read";
        public static string moviesForViewing = "Movies for viewing";
        public static string anyNotes = "Any notes";
        public static string everydayTasks = "Everyday tasks";
        public static String favText = "fav";
        public static String unfavText = "unfav";
        public static String doneText = "done";
        public static String notText = "not";
    }
}
