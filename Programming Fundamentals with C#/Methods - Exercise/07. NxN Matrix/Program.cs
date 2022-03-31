using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintNxNNumbres(n);
        }

        private static void PrintNxNNumbres(int n)
        {
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = n;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(string.Join(" ", numbers));
                Console.WriteLine();
            }
            //for (int j = 0; j < n; j++)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"{n} ");
            //    }
            //    Console.WriteLine();

            //}
        }
    }
}
