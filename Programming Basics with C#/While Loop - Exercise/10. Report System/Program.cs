using System;

namespace _02._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            double savedSum = 0;
            string command = Console.ReadLine();
            int count = 0;
            double cashSum = 0;
            int cashCount = 0;
            double cardSum = 0;
            int cardCount = 0;

            while (command != "End")
            {
                double currentSum = double.Parse(command);
                if (count % 2 == 0)
                {
                    if (currentSum > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        savedSum += currentSum;
                        cashSum += currentSum;
                        cashCount++;
                    }

                }
                else 
                {
                    if (currentSum < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        savedSum += currentSum;
                        cardSum += currentSum;
                        cardCount++;
                    }                 
                }
                count++;

                if (savedSum >= sum)
                {
                    Console.WriteLine($"Average CS: {cashSum / cashCount:f2}");
                    Console.WriteLine($"Average CC: {cardSum / cardCount:f2}");
                    return;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("Failed to collect required money for charity.");
        }
    }
}
