using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 2 3 4 5 6 7 8
            //  4 3 -1 2 5 0 1 9 8 6 7 -2
            // 0 1 2 3 4 5
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] result = new int[numbers.Length / 2];

            for (int i = 0; i < numbers.Length / 4; i++)
            {
                result[(result.Length / 2 -1) - i] = numbers[i] + numbers[(numbers.Length / 2 -1) - i];
                result[result.Length / 2 + i] = numbers[(numbers.Length - 1) - i] + numbers[(numbers.Length / 2 + i)];
            }
            Console.WriteLine($"{string.Join(" ", result)}");
        }
    }
}
