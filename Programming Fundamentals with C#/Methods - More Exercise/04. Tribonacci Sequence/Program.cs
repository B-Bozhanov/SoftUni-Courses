using System;
using System.Linq;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            PrintTribonachi(num);
        }
        // 1 1 2 4 7 13 24 44
        private static void PrintTribonachi(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                int[] curent = new int[num[i]];
                for (int j = 0; j < num[i]; j++)
                {
                    if (j < 2)
                    {
                        curent[j] = 1;
                    }
                    else if (j == 2)
                    {
                        curent[j] = j;
                        
                    }
                    else
                    {
                        curent[j] = curent[j - 1] + curent[j - 2] + curent[j - 3];
                    }
                }
                Console.WriteLine(string.Join(" ", curent));
            }
        }
    }
}
