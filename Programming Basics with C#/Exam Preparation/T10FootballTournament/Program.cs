using System;

namespace T10FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int matches = int.Parse(Console.ReadLine());
            double wins = 0;
            int equals = 0;
            int looses = 0;
            int points = 0;

            if (matches < 1)
            {
                Console.WriteLine($"{team} hasn't played any games during this season.");
                return;
            }
            for (int n = 0; n < matches; n++)
            {
                char exitFromMatch = Console.ReadLine()[0];
                switch (exitFromMatch)
                {
                    case 'W':
                        wins += 1;
                        points += 3;
                        break;

                    case 'D':
                        points += 1;
                        equals += 1;
                        break;
                    case 'L':
                        looses += 1;
                        break;
                }
            }

            Console.WriteLine($"{team} has won {points} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {wins}");
            Console.WriteLine($"## D: {equals}");
            Console.WriteLine($"## L: {looses}");
            Console.WriteLine($"Win rate: {((wins / matches) * 100):f2}%");
        }
    }
}
