using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Set2
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = @"d:\text.txt";

            TextReader mTextReader = new TextReader(fileName);

            String text = mTextReader.readerText();

            TextHandler mTextHandler = new TextHandler(text);

            Dictionary<String, int> ourMap = new Dictionary<String, int>();
            ourMap = mTextHandler.getSentencesCountWords(mTextHandler.splitSentence());

            Console.WriteLine("1. Вывести все предложения заданного текста в порядке возрастания количества слов в каждом из них:\n");

            foreach (var pair in ourMap)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }

            Console.WriteLine("\n2. Во всех вопросительных предложениях текста найти и напеча¬тать без повторений слова заданной длины:\n");



            Console.ReadLine();
        }
    }
}
