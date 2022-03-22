using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string dataType = Console.ReadLine();
            int num = 2;
            double dNum = 1.5;
            string symbol = "$";

            switch (command)
            {
                case "int":
                    PrintIntMultiplying(dataType, num); break;
                case "real":
                    PrintDoubleMultiplying(dataType, dNum); break;
                case "string":
                    PrintString(dataType, symbol); break;
            }
        }

        private static void PrintString(string command, string symbol)
        {
            Console.Write(symbol);
            Console.Write(command);
            Console.WriteLine(symbol);
        }

        private static void PrintDoubleMultiplying(string dataType, double doubleNum)
        {
            double num = double.Parse(dataType);
            double result = num * doubleNum;
            Console.WriteLine($"{result:f2}");
        }

        private static void PrintIntMultiplying(string dataType, int number)
        {
            int num = int.Parse(dataType);
            int result = num * number;
            Console.WriteLine(result);
        }
    }
}
