using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figures = Console.ReadLine();

            switch (figures)
            {
                case "square":
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{a * a:f3}");
                    break;
                case "rectangle":
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{b * c:f3}");
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{Math.PI * (r * r):f3}");
                    break;
                case "triangle":
                    double d = double.Parse(Console.ReadLine());
                    double hd = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{d*hd/2:f3}");
                    break;

            }
        }
    }
}
