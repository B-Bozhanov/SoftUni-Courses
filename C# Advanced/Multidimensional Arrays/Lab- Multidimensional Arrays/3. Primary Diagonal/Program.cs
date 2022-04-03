using System;
using System.Linq;

namespace Bricks_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] numbers = new int[n, n];
            int sum = 0;

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                int[] inputNum = Console.ReadLine()
                    .Split()
                    .Select(x => int.Parse(x))
                    .ToArray();
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = inputNum[col];
                    if (col == row)
                    {
                        sum += inputNum[col];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
