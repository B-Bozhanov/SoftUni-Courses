using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5 0 4 2 3 5
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j] + arr[j + 1];
                }
                Array.Resize(ref arr, arr.Length - 1);

            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
