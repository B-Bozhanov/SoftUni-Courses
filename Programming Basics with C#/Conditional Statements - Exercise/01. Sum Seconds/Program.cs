﻿using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirtTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirtTime;

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            Console.WriteLine($"{minutes}:{seconds:d2}");

            
        }
    }
}