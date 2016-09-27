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
        int points;
        int maxLenght;
        int minLenght;
        int valueTimer;

        bool exit;
        bool flag;

        String path;
        String gameWord;
        String intermediateWord;

        static Timer timer;

        ReadDictionary words = new ReadDictionary();

        List<String> dictionary = new List<String>();

        Dictionary<string, int> ourWords = new Dictionary<string, int>();

        public Game(string dictionaryPath, int timer, int max, int min)
        {
            exit = true;

            points = 0;
            maxLenght = max;
            minLenght = min;
            valueTimer = timer;
            path = dictionaryPath;

            dictionary = words.Read(path);

            Play();
        }

        public void Play()
        {
            Console.WriteLine("Your RANDOM WORD: {0}", gameWord = RandomWord(dictionary.Count - 1));
            gameWord=gameWord.ToLower();

            timer = new Timer(valueTimer);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            InputWords();
        }

        public void InputWords()
        {
            String inputWord;
            do
            {
                Console.Write("-> ");
                inputWord = Console.ReadLine().ToLower();
                
                if (!inputWord.Equals(gameWord) && !ourWords.ContainsKey(inputWord) && inputWord != "" && dictionary.Contains(inputWord) && Validation(inputWord))
                {
                    ourWords.Add(key: inputWord, value: inputWord.Length);
                }
            } while (exit);
        }

        public bool Validation(String inputWord)
        {
            flag = true;
            intermediateWord = gameWord;

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

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            exit = false;

            timer.Stop();
            OutputPoints();
        }

        public override string ToString()
        {
            string s = "\nWord:\tPoints:\n----- \t-----";

            return s;
        }

        public void OutputPoints()
        {
            Console.WriteLine("\nWord:\tPoints:\n----- \t-----");

            foreach (var pair in ourWords)
            {
                Console.WriteLine("{0}\t{1}", pair.Key, pair.Value);
                points += pair.Value;
            }

            Console.WriteLine("\nYour score: {0} points", points);
            Console.WriteLine("\nPress 'Enter' to exit.");
        }

        public String RandomWord(int maxCount)
        {
            Random random = new Random();
            String rndWord;
            do
            {
                rndWord = dictionary[random.Next(maxCount)];
            } while (rndWord.Length > maxLenght || rndWord.Length < minLenght);
            return rndWord;
        }

    }
}
