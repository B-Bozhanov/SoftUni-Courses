using System;

namespace _04._Movie_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetOfActors = double.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "ACTION")
            {
                if (command.Length > 15)
                {
                    budgetOfActors -= budgetOfActors * 0.20;
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    double salary = double.Parse(Console.ReadLine());
                    budgetOfActors -= salary;
                }
                if (budgetOfActors <= 0)
                {
                    Console.WriteLine($"We need {Math.Abs(budgetOfActors):f2} leva for our actors.");
                    return;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"We are left with {budgetOfActors:f2} leva.");
        }
    }
}
