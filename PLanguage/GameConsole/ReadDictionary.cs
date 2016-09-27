using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace GameConsole
{
    public class ReadDictionary
    {
        public List<String> Read(String path)
        {
            List<String> dictionary = new List<String>();
            StreamReader stream = new StreamReader(path, Encoding.GetEncoding(1251));
            while (!stream.EndOfStream)
            {
                dictionary.Add(stream.ReadLine().ToLower());
            }
            stream.Close();
            return dictionary;
        }
    }
}
