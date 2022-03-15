using System;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputnums = Console.ReadLine().Split(", ");
            int rows = int.Parse(inputnums[0]);
            int cols = int.Parse(inputnums[1]);
            int[,] numbers = new int[rows, cols];

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                string[] nums = Console.ReadLine().Split();
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = int.Parse(nums[col]);
                }
            }

            for (int col = 0; col < numbers.GetLength(1); col++)
            {
                int currentSum = 0;
                for (int row = 0; row < numbers.GetLength(0); row++)
                {
                    currentSum += numbers[row, col];
                }
                Console.WriteLine(currentSum);
            }
        }
    }
}
