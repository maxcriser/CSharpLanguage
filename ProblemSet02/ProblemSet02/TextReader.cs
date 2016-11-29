using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet02
{
    class TextReader
    {
        public static string ReadFile(string PATH)
        {
            System.IO.StreamReader stream = new System.IO.StreamReader(PATH);
            String text = String.Empty;
            String line = String.Empty;
            while ((line = stream.ReadLine()) != null)
            {
                text += line + "\n";
            }
            stream.Close();
            return text;
        }
    }
}
