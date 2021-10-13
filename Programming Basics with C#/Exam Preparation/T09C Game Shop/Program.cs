using System;

namespace T09C_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hearthstone
            // Fornite
            // Overwatch
            // Others

            int numOfGames = int.Parse(Console.ReadLine());

            double Hearthstone = 0;
            double perFornite = 0;
            double perOverwatch = 0;
            double perOthers = 0;

            for (int n = 0; n < numOfGames; n++)
            {
                string nameOfGame = Console.ReadLine();
                switch (nameOfGame)
                {
                    case "Hearthstone":
                        if (nameOfGame == "Hearthstone")
                        {
                            Hearthstone += (100.00 / numOfGames) ;
                        }
                        else
                        {
                            Hearthstone = 0;
                        }
                        break;
                    case "Fornite":

                        if (nameOfGame == "Fornite")
                        {
                            perFornite += 100.00 / numOfGames ;
                        }
                        else
                        {
                            perFornite = 0;
                        }
                        break;
                    case "Overwatch":
                        if (nameOfGame == "Overwatch")
                        {
                            perOverwatch += 100.00 / numOfGames ;
                        }
                        else
                        {
                            perOverwatch = 0;
                        }
                        break;
                }
                perOthers = 100.00 - (Hearthstone + perFornite + perOverwatch);

            }
            Console.WriteLine($"Hearthstone - {Hearthstone:f2}%");
            Console.WriteLine($"Fornite - {perFornite:f2}%");
            Console.WriteLine($"Overwatch - {perOverwatch:f2}%");
            Console.WriteLine($"Others - {perOthers:f2}%");



        }
    }
}
