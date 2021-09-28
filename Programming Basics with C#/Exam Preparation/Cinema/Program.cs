using System;

namespace _04._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            double cinemaIncome = 0;

            string movie = Console.ReadLine();
            while (movie != "Movie time!")
            {
                int peoples = int.Parse(movie);
                
                if (capacity < peoples)
                {
                    Console.WriteLine($"The cinema is full.");
                    Console.WriteLine($"Cinema income - {cinemaIncome} lv.");
                    return;
                }
                capacity -= peoples;
                if (peoples % 3 ==0 )
                {
                    cinemaIncome += (peoples * 5) - 5;
                }
                else
                {
                    cinemaIncome += peoples * 5;
                }
                
                movie = Console.ReadLine();
            }
            Console.WriteLine($"There are {capacity} seats left in the cinema.");
            Console.WriteLine($"Cinema income - {cinemaIncome} lv.");
        }
    }
}
