using System;

namespace _07._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int juryNum = int.Parse(Console.ReadLine());
            double currentPoints = academyPoints;
            for (int i = 0; i < juryNum; i++)
            {
                string juryName = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());
                currentPoints += (juryName.Length * points) / 2;
                if (currentPoints >= 1250.50)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {currentPoints:f1}!");
                    return;
                }
            }          
            Console.WriteLine($"Sorry, {actorName} you need {1250.50 - currentPoints:f1} more!");

        }
    }
}
