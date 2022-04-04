using System;
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
                (
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                );
            int maxOrder = orders.Max();
            Console.WriteLine(maxOrder);

            while (orders.Count != 0)
            {
                int currOrder = orders.Peek();
                if (totalFood < currOrder)
                {
                    Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
                    return;
                }

                totalFood -= orders.Dequeue();
            }
            Console.WriteLine("Orders complete");
        }
    }
}
