using System;

namespace Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            int[,] numbers = new int[rows, cols];
            int totalSum = 0;

            for (int row = 0; row < rows; row++)
            {
                string[] nums = new string[cols];
                nums = Console.ReadLine().Split(", ");
                int currentRowsSum = 0;
                for (int col = 0; col < cols; col++)
                {
                    numbers[row, col] = int.Parse(nums[col]);
                    currentRowsSum += int.Parse(nums[col]);
                }
                totalSum += currentRowsSum;
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(totalSum);
        }
    }
}
