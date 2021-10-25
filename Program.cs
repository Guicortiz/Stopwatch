using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("P - Pomodore");
            Console.WriteLine("C - Chronometer");
            Console.WriteLine("------------");
            Console.WriteLine("E - Exit");

            string option = Console.ReadLine().ToUpper();
            switch (option)
            {
                case "P":
                    Pomodore();
                    break;
                case "C":
                    break;
                case "E":
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }

        }
        static void Pomodore()
        {
            Console.WriteLine("Type minutes do you want be focused?");
            int minutes = int.Parse(Console.ReadLine());
            Start(minutes, false);
        }

        static void Start(int minutes, Boolean ascending)
        {
            if (ascending == true)
            {
                // notmake
            }
            else
            {
                int time = minutes * 60;
                int seconds = 0;
                while (time > 0)
                {
                    Console.Clear();
                    Console.WriteLine(TimeCurrent(minutes, seconds));
                    time--;
                    if (seconds == 0)
                    {
                        minutes--;
                        seconds = 60;
                    }
                    seconds--;


                    Thread.Sleep(1000);
                }
                Console.Clear();
                Console.WriteLine("Stopwatch finished");
                Thread.Sleep(2500);
            }

        }
        static string TimeCurrent(int minutes, int seconds)
        {
            if (minutes < 10 && seconds < 10)
                return $"0{minutes}:0{seconds}";
            else if (minutes < 10)
                return $"0{minutes}:{seconds}";
            else if (seconds < 10)
                return $"{minutes}:0{seconds}";
            else
                return $"{minutes}:{seconds}";
        }
    }
}
