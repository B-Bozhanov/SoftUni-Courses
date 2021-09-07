using System;

namespace _07._Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            NewMethod1(n);
            Console.WriteLine($" | ");
            for (int i = 1; i <= n; i++)
            {
                for (int k = i; k <= n - 1; k++)
                {
                    Console.Write($" ");
                }
                NewMethod(i);
                Console.Write($" | ");
                NewMethod(i);
                Console.WriteLine();
            }
        }

        private static void NewMethod1(int n)
        {
            for (int i = 0; i <= n - 1; i++)
            {
                Console.Write($" ");
            }
        }

        private static void NewMethod(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"*");
            }
        }
    }
}
