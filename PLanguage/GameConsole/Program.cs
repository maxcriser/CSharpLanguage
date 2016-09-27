using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using System.Collections;

namespace GameConsole
{
    public static class Program
    {
        public static void Settings(out int max, out int min)
        {
            do {
                Console.Write("Minimum lenght: ");
                min = int.Parse(Console.ReadLine());
            } while (min < 3 || min > 20);
            do {
                Console.Write("Maximum lenght: ");
                max = int.Parse(Console.ReadLine());
            } while (max < min || max > 20);
        }

        static void Main(string[] args)
        {
            int max;
            int min;
            int timerValue = 30000;

            string dictionaryPath = "D:/dictionary.txt";

            Settings(out max, out min);

            Game play = new Game(dictionaryPath, timerValue, max, min); // once character
        }
    }
}
