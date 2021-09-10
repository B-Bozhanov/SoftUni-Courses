using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            double widh = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double apartmentVolume = widh * length * height;
            int boxesVolume = 0;   

            string command = Console.ReadLine();

            while (command != "Done")
            {
                int boxes = int.Parse(command);
                boxesVolume += boxes;
                if (boxesVolume >= apartmentVolume)
                {
                    Console.WriteLine($"No more free space! You need {boxesVolume - apartmentVolume} Cubic meters more.");
                    return;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"{apartmentVolume - boxesVolume} Cubic meters left.");
        }
    }
}
