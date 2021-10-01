using System;

namespace _06._Favorite_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int counter = 0;
            int totalPoints = 0;
            string bestMovie = string.Empty;

            while (movie != "STOP")
            {
                counter++;
                int curentPoints = 0;
         
                for (int i = 0; i < movie.Length; i++)
                {
                    curentPoints += movie[i];
                    if (movie[i] >= 97 && movie[i] <= 122)
                    {
                        curentPoints -= 2 * movie.Length;
                    }
                    else if (movie[i] >= 65 && movie[i] <= 90)
                    {
                        curentPoints -= movie.Length;
                    }
                }
                if (curentPoints > totalPoints)
                {
                    totalPoints = curentPoints;
                    bestMovie = movie;
                }
                if (counter >= 7)
                {
                    Console.WriteLine($"The limit is reached.");
                    break;
                }
                movie = Console.ReadLine();
            }
            Console.WriteLine($"The best movie for you is {bestMovie} with {totalPoints} ASCII sum.");
        }
    }
}
