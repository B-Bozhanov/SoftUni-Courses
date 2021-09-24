using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            double totalLiquid = bottles * 750;
            int count = 0;
           
            int dishes = 0;
            int pots = 0;


            string command = Console.ReadLine();
            while (command != "End")
            {
                int NumberOfVessels = int.Parse(command);

                count++;
                if (count == 3)
                {
                    totalLiquid -= NumberOfVessels * 15;
                    pots += NumberOfVessels;
                    count = 0;
                }
                else
                {
                    totalLiquid -= NumberOfVessels * 5;
                    dishes += NumberOfVessels;
                }
               
                if (totalLiquid < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(totalLiquid)} ml. more necessary!");
                    return;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
            Console.WriteLine($"Leftover detergent {totalLiquid} ml.");
        }
    }
}
