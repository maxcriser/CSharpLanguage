using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Set2
{
    class TextReader
    {
        String DATA_PATH;
        String text;

        public TextReader(String path)
        {
            DATA_PATH = path;
            text = "";
        }

        public String readerText()
        {
            StreamReader readFile = new StreamReader(DATA_PATH, Encoding.GetEncoding(1251));
            String input = null;
            
            while ((input = readFile.ReadLine()) != null)
            {
                text+=input;
                text += "\n";
            }
            readFile.Close();

            return text;
        }
    }
}
