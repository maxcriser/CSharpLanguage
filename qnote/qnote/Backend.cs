using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace qnote
{
    class Backend
    {
        public static List<User> profiles;
        public static List<Note> notes;

        public static void writeToFile(List<Note> list, String username, String typePath)
        {
            String curPath = @"D:\qnote\users\" + @username + typePath;
            System.IO.StreamWriter writer = new System.IO.StreamWriter(curPath, false, Encoding.UTF8);
            foreach (Note w in list)
            {
                String textFavourite = Constants.unfavText;
                String textDone = Constants.notText;
                if (w.favourite)
                {
                    textFavourite = Constants.favText;
                }
                if (w.done)
                {
                    textDone = Constants.doneText;
                }
                writer.WriteLine(w.text + Constants.SEPARATOR + textFavourite + Constants.SEPARATOR + textDone);
            }
            writer.Close();
        }

        public static void writeProfileToFile(String username, String password, String PATH)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(PATH, true, Encoding.UTF8);
            writer.WriteLine(username);
            writer.WriteLine(password);
            writer.Close();
        }

        public static void writeToStatus(String username, String password, String statusPATH)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(statusPATH, false, Encoding.UTF8);
            writer.WriteLine(username);
            writer.WriteLine(password);
            writer.Close();
        }

        public static void createFolder(String username, String[] notesList)
        {
            String path = @"D:\qnote\users\";
            String pathFolder = path + @username;
            Directory.CreateDirectory(pathFolder);
            for (int i = 0; i < notesList.Length; i++)
            {
                String pathFile = pathFolder + notesList[i];
                System.IO.StreamWriter writer = new System.IO.StreamWriter(pathFile, true, Encoding.UTF8);
                writer.Close();
            }
        }

        public static List<User> ReadProfiles(String PATH)
        {
            profiles = new List<User>();
            profiles.Clear();
            StreamReader stream = new StreamReader(PATH, Encoding.GetEncoding(1251));
            while (!stream.EndOfStream)
            {
                String lineUsername = stream.ReadLine();
                String linePassword = stream.ReadLine();
                User newUser = new User(lineUsername, linePassword);
                profiles.Add(newUser);
            };
            stream.Close();
            return profiles;
        }

        public static List<Note> notesFilling(String path, String username)
        {
            notes = new List<Note>();
            String curPath = @"D:\qnote\users\" + @username + path;
            StreamReader stream = new StreamReader(curPath, Encoding.GetEncoding(1251));
            while (!stream.EndOfStream)
            {
                String line = stream.ReadLine();
                if (line != String.Empty)
                {
                    String[] sep = line.Split(Constants.SEPARATOR);
                    List<String> w = new List<String>();
                    Boolean favourite = false;
                    Boolean done = false;
                    if (sep[1].Equals(Constants.favText))
                        favourite = true;
                    if (sep[2].Equals(Constants.doneText))
                        done = true;
                    Note newNote = new Note(sep[0], favourite, done);
                    notes.Add(newNote);
                }
            }
            stream.Close();
            return notes;
        }
    }
}
