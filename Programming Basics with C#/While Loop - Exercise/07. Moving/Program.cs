using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double neededvolume = width * length * height;
            double volume = 0;

            string command = Console.ReadLine();
            while (command != "Done")
            {
                double package = double.Parse(command);
                volume += package;
                if (neededvolume <= volume)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(neededvolume - volume)} Cubic meters more.");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{neededvolume - volume} Cubic meters left.");
        }
    }
}
