using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournament = int.Parse(Console.ReadLine());
            double startingPoints = double.Parse(Console.ReadLine());
            double finalPoints = startingPoints;
            double counter = 0;


            for (int i = 0; i < tournament; i++)
            {
                string result = Console.ReadLine();

                switch (result)
                {
                    case "W":
                        finalPoints += 2000;
                        counter++; break;
                    case "F":
                        finalPoints += 1200;break;
                    case "SF":
                        finalPoints += 720; break;
                }
            }
            double averagePoints = Math.Floor((finalPoints - startingPoints) / tournament);
            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{counter/tournament*100:f2}%");
        }
    }
}
