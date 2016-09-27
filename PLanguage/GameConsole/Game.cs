using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Collections;

namespace GameConsole
{
    class Game
    {

        static List<String> dictionary = new List<String>();

        static ReadDictionary words = new ReadDictionary();

        static string dictionaryPath= "D:/dictionary.txt";

        Dictionary<string, int> ourWords = new Dictionary<string, int>();

        int points;
        int maxLenght;
        int minLenght;

        public String gameWord;
        String intermediateWord;

        public Game(int max, int min)
        {
            points = 0;
            maxLenght = max;
            minLenght = min;

            dictionary = words.Read(dictionaryPath);

            gameWord = RandomWord();      
        }

        public void Test(String inputWord)
        {
            if (!inputWord.Equals(gameWord) && !ourWords.ContainsKey(inputWord) && inputWord != "" && dictionary.Contains(inputWord) && Validation(inputWord))
            {
                    ourWords.Add(key: inputWord, value: inputWord.Length);
            }
        }

        //public void Play()
        //{
        //    InputWords();
        //}

        //public void InputWords()
        //{
        //    String inputWord;
        //    do
        //    {
        //        Console.Write("-> ");
        //        inputWord = Console.ReadLine().ToLower();

        //        if (!inputWord.Equals(gameWord) && !ourWords.ContainsKey(inputWord) && inputWord != "" && dictionary.Contains(inputWord) && Validation(inputWord))
        //        {
        //            ourWords.Add(key: inputWord, value: inputWord.Length);
        //        }
        //    } while (exit);
        //}

        public bool Validation(String inputWord)
        {
            bool flag = true;
            string intermediateWord = gameWord;

            for (int i = 0; i < inputWord.Length; i++)
            {
                if (!intermediateWord.Contains(inputWord[i])) {
                    flag = false;
                    break;
                }
                else {
                    intermediateWord = intermediateWord.Remove(intermediateWord.IndexOf(inputWord[i]), 1);
                }
            }
            return flag;
        }

        public override string ToString()
        {
            string s = "\nWord:\tPoints:\n----- \t-----";

            return s;
        }

        //public void OutputPoints()
        //{
        //    Console.WriteLine("\nWord:\tPoints:\n----- \t-----");

        //    foreach (var pair in ourWords)
        //    {
        //        Console.WriteLine("{0}\t{1}", pair.Key, pair.Value);
        //        points += pair.Value;
        //    }

        //    Console.WriteLine("\nYour score: {0} points", points);
        //    Console.WriteLine("\nPress 'Enter' to exit.");
        //}

        public String RandomWord()
        {
            Random random = new Random();
            String rndWord;
            do
            {
                rndWord = dictionary[random.Next(dictionary.Count-1)];
            } while (rndWord.Length > maxLenght || rndWord.Length < minLenght);
            return rndWord;
        }

    }
}
