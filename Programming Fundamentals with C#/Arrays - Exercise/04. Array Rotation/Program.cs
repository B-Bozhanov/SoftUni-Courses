using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //51 47 32 61 21
            //2
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                int firstNum = input[0];
                for (int i = 0; i < input.Length - 1; i++)
                {
                    input[i] = input[i + 1];
                }
                input[input.Length - 1] = firstNum;
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
