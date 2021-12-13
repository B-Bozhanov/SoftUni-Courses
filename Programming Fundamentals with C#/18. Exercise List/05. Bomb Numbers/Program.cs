using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            List<int> bombNumbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            int bomb = bombNumbers[0];
            int power = bombNumbers[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int end = i + power;
                    int start = i - power;
                    if (start < 0)
                    {
                        start = 0;
                    }
                    if (end >= numbers.Count)
                    {
                        end = numbers.Count - 1;
                    }
                    for (int j = start; j <= end; j++)
                    {
                        numbers.RemoveAt(start);
                    }

                    i = 0;
                }
            }
            int sumOfNumbers = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sumOfNumbers += numbers[i];
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
