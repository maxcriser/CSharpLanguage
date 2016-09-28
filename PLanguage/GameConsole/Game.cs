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

        static string dictionaryPath= "D:/dictionary.txt";
        
        Dictionary<string, int> ourWords = new Dictionary<string, int>();

        int points;
        int maxLenght;
        int minLenght;

        public String gameWord;

        public Game(int max, int min)
        {
            points = 0;
            maxLenght = max;
            minLenght = min;

            dictionary = ReadDictionary.Read(dictionaryPath); //

            gameWord = RandomWord();      
        }

        public void Test(String inputWord)
        {
            if (!inputWord.Equals(gameWord) && !ourWords.ContainsKey(inputWord) && inputWord != "" && dictionary.Contains(inputWord) && Validation(inputWord))
            {
                    ourWords.Add(key: inputWord, value: inputWord.Length);
            }
        }

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
            string solution = "\nWord:\tPoints:\n----- \t-----";
            foreach (var pair in ourWords)
            {
                solution +="\n" + pair.Key + "\t" + pair.Value;
                points += pair.Value;
            }
            solution += "\nYour score: " + points + " points" + "\nPress 'Enter' to exit.";
            return solution;
        }

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
