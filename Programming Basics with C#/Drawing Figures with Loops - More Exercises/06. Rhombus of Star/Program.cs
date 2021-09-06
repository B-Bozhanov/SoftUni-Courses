using System;

namespace _06._Rhombus_of_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            // 5
            // * == " " n-1
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n -1; j++)
                {
                    Console.Write($" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write($" ");
                }

                for (int j = i; j >= 1; j--)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }
            
        }
    }
}

