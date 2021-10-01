using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTournament = int.Parse(Console.ReadLine());
            double money = 0;
            int totalWins = 0;
            int totalLoses = 0;

            for (int i = 1; i <= daysOfTournament; i++)
            {
                double curentMoney = 0;
                int curentWins = 0;
                int curentLooses = 0;


                string game = Console.ReadLine();
                while (game != "Finish")
                {
                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        curentMoney += 20;
                        curentWins++;
                    }
                    else
                    {
                        curentLooses++;
                    }

                    game = Console.ReadLine();
                }
                if (curentWins > curentLooses)
                {

                    curentMoney *= 1.10;
                    money += curentMoney;
                    totalWins++;
                }
                else
                {
                    totalLoses++;
                    money += curentMoney;
                }

            }
            if (totalWins > totalLoses)
            {
                money *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {money:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {money:f2}");
            }
        }
    }
}
