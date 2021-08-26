using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string entryUnit = Console.ReadLine();
            string exitUnit = Console.ReadLine();
            double finalUnit = 0;

            if (entryUnit == "mm" && exitUnit == "cm")
            {
                finalUnit = num / 10;
            }
            else if (entryUnit == "mm" && exitUnit == "m")
            {
                finalUnit = num / 1000;
            }
            else if (entryUnit == "cm" && exitUnit == "mm")
            {
                finalUnit = num * 10;
            }
            else if (entryUnit == "cm" && exitUnit == "m")
            {
                finalUnit = num / 100;
            }
            else if (entryUnit == "m" && exitUnit == "mm")
            {
                finalUnit = num * 1000;
            }
            else if (entryUnit == "m" && exitUnit == "cm")
            {
                finalUnit = num * 100;
            }
            Console.WriteLine($"{finalUnit:f3}");
        }
    }
}
