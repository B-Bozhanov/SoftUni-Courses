using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double delay = Math.Floor (distance / 15 ) * 12.5;
            double totalTime = timePerMeter * distance + delay;

            if (totalTime < worldRecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - worldRecord:f2} seconds slower.");
            }

        }
    }
}
