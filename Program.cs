﻿using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Start();
        }

        static void Start()
        {
            int time = 10;
            int currentTime = 0;
            while (currentTime <= time)
            {
                Console.WriteLine(currentTime);
                currentTime++;
            }
        }
    }
}
