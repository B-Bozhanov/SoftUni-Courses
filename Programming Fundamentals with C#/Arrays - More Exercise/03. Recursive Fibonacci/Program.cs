using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());        // 1 1 2 3

            int[] fibonacci = new int[] { 1, 1 };
            for (int i = 0; i < n; i++)
            {
                Array.Resize(ref fibonacci, fibonacci.Length + 1);
                fibonacci[i + 2] = fibonacci[i] + fibonacci[i + 1];
            }
            int result = 0;
            if (n == 1 || n == 2)
            {
                result = 1;
                Console.WriteLine(result);
            }
            else
            {
                result = fibonacci[n - 2] + fibonacci[n - 3];
                Console.WriteLine(result);
            }
        }
    }
}
