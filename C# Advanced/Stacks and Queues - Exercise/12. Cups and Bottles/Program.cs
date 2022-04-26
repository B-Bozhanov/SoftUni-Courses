using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cups = new Queue<int>
                (
                 Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => int.Parse(x))
                );
           var bottles = new Stack<int>
                (
                 Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => int.Parse(x))
                );
            var wastedWater = 0;
            var currentCup = cups.Peek(); 

            while (true)
            {
                if (cups.Count == 0)
                {
                    Console.WriteLine($"Bottles: {String.Join(' ', bottles)}");
                    Console.Write($"Wasted litters of water: {wastedWater}");
                    break;
                }
                if (bottles.Count == 0)
                {
                    Console.WriteLine($"Cups: {String.Join(' ', cups)}");
                    Console.Write($"Wasted litters of water: {wastedWater}");
                    break;
                }

                if (bottles.Peek() >= currentCup)
                {
                    wastedWater += bottles.Pop() - currentCup;
                    cups.Dequeue();
                    if (cups.Count == 0)
                    {
                        continue;
                    }
                    currentCup = cups.Peek();
                }
                else
                {
                    currentCup -= bottles.Pop();
                }
            }
        }
    }
}
