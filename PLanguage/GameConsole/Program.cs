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
    public class Program
    {
        static int max;
        static int min;

        static int timerValue = 10000;

        static bool exit = true;

        static string gameWord;
        static string inputWord;

        static Timer timer = new Timer(timerValue);

        static Game play;

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
            Settings(out max, out min);

            play = new Game(max,min);

            gameWord = play.gameWord;

            Console.WriteLine("Your random word: " + gameWord);
            
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            while (exit)
            {
                Console.Write("-> ");
                inputWord=Console.ReadLine();
                play.Test(inputWord);
            };
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            exit = false;
            timer.Stop();
            Console.WriteLine(play.ToString());
        }
    }
}
