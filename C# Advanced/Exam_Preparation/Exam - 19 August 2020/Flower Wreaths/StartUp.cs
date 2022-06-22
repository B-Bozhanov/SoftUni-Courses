using System;
using System.Collections.Generic;
using System.Linq;

namespace Flower_Wreaths
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(
                Console.ReadLine()
                .Split(", ")
                .Select(int.Parse).ToArray());

            Queue<int> roses = new Queue<int>(
                Console.ReadLine()
                .Split(", ")
                .Select(int.Parse).ToArray());

            int wreaths = 0;
            int storedFlowers = 0;

            while (lilies.Any() && roses.Any())
            {
                var currentLilies = lilies.Peek();
                var currentRoses = roses.Peek();

                while (currentLilies + currentRoses > 15)
                {
                    currentLilies -= 2;
                }

                if (currentLilies + currentRoses < 15)
                {
                    storedFlowers += currentLilies + currentRoses;
                    lilies.Pop();
                    roses.Dequeue();
                    continue;
                }
                wreaths++;
                lilies.Pop();
                roses.Dequeue();
            }

            while (storedFlowers >= 15)
            {
                wreaths++;
                storedFlowers -= 15;
            }

            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
