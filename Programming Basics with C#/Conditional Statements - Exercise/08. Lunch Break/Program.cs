using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            double durationMovie = double.Parse(Console.ReadLine());
            double durationRelax = double.Parse(Console.ReadLine());

            double neededTimeForLunch = durationRelax / 8;
            double neededTimeForRest = durationRelax / 4;
            double totalTime = durationRelax - (neededTimeForLunch + neededTimeForRest);
            double neededTime = Math.Abs(durationMovie - totalTime);

            if (totalTime >= durationMovie)
            {
                Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(neededTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(neededTime)} more minutes.");
            }
        }
    }
}
