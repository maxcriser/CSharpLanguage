using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemSet02
{
    class Program
    {
        static void Main(string[] args)
        {
            Text ex1 = new Text(Examples.string1);
            Text ex2 = new Text(Examples.string2);
            Text ex3 = new Text(Examples.string3);
            Text ex4 = new Text(Examples.string4);
            Text ex5 = new Text(Examples.string5);

            Console.WriteLine("Вывести все предложения заданного текста в порядке возрастания количества слов в каждом из них.");
            Console.WriteLine("Examples.string1: " + Examples.string1);
            Console.WriteLine(ex1.SortedText());

            Console.WriteLine("\nВо всех вопросительных предложениях текста найти и напеча¬тать без повторений слова заданной длины");
            Console.WriteLine("Examples.string2: " + Examples.string2);
            Console.WriteLine("\nВведите длинну слова:");
            int lenghtWord = Int32.Parse(Console.ReadLine());
            HashSet<Word> hashWords = ex2.GetHashSetWordsLength(lenghtWord);
            foreach (var word in hashWords)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("\nИз текста удалить все слова заданной длины, начинающиеся на согласную букву.");
            Console.WriteLine("Examples.string3: " + Examples.string3);
            ex3.DeleteWordsWithLength(5);
            Console.WriteLine(ex3);

            Console.WriteLine("\nВ некотором предложении текста слова заданной длины заменить указанной подстрокой, длина которой может не совпадать с длиной слова.");
            Console.WriteLine("Введите слово для замены:");
            String replaceWord = Console.ReadLine();
            Console.WriteLine("Examples.string4: " + Examples.string4);
            ex4.ReplaceWord(0, 5, replaceWord);
            Console.WriteLine(ex4);

            Console.WriteLine("\nConcordance:");
            string text = TextReader.ReadFile(@"D:\text.txt");
            Text textObject = new Text(text);
            Console.WriteLine("ORIGINAL: " + textObject);
            Console.WriteLine("\n======Statistics======");
            Dictionary<string, Concordance> stats = textObject.GetStatistics();
            List<string> statsRecords = new List<string>();
            foreach (var word in stats)
            {
                statsRecords.Add(word.Key + "  -  " + word.Value);
            }
            statsRecords.Sort();
            char currentLetter = 'A';
            foreach (var record in statsRecords)
            {
                if (record[0].ToString().ToUpper()[0] != currentLetter)
                {
                    currentLetter = record[0].ToString().ToUpper()[0];
                    Console.WriteLine("\n===" + currentLetter + "===");
                }
                Console.WriteLine(record);
            }
            Console.ReadLine();
        }
    }
}
