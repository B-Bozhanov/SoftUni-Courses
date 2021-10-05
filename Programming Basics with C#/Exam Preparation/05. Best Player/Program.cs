using System;

namespace _05._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();
            string bestPlayer = string.Empty;
            int totalGoals = 0;

            while (player != "END")
            {
                int goals = int.Parse(Console.ReadLine());
                if (goals > totalGoals)
                {
                    totalGoals = goals;
                    bestPlayer = player;
                }
                if (goals >= 10)
                {
                    Console.WriteLine($"{bestPlayer} is the best player!");
                    Console.WriteLine($"He has scored {totalGoals} goals and made a hat-trick !!!");
                    return;
                }

                player = Console.ReadLine();
            }
            if (totalGoals >= 3)
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {totalGoals} goals and made a hat-trick !!!");
            }
            else 
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {totalGoals} goals.");
            }
            
        }
    }
}
