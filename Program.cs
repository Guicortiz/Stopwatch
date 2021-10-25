using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Start(6);
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("P - Pomodore");
            Console.WriteLine("C - Chronometer");
            Console.WriteLine("------------");
            Console.WriteLine("E - Exit");
        }
        static void Start(int time)
        {
            int currentTime = 0;
            while (currentTime < time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finished");
            Thread.Sleep(2500);
        }
    }
}
