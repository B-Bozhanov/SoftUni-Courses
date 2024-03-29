﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>
                (Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                );

            Console.WriteLine(orders.Max());
            while (true)
            {
                if (orders.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    return;
                }
                if (totalFood < orders.Peek())
                {
                    Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
                    return;
                }
                totalFood -= orders.Dequeue();
            }
        }
    }
}
