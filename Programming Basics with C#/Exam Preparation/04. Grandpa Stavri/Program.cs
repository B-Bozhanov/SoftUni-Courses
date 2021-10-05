using System;

namespace _04._Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalLiters = 0;
            double totalDegreece = 0;
           
            for (int i = 1; i <= n; i++)
            {
                double liters = double.Parse(Console.ReadLine());
                double degreece = double.Parse(Console.ReadLine());
                totalLiters += liters;
                totalDegreece += liters * degreece;
            }
            double averageDegreece = totalDegreece / totalLiters;
            Console.WriteLine($"Liter: {totalLiters:f2}");
            Console.WriteLine($"Degrees: {averageDegreece:f2}");
            if (averageDegreece < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (averageDegreece <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (averageDegreece > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
