using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];
            int[] result = new int[n];


            for (int i = 0; i < names.Length; i++)
            {
                int curentSum = 0;

                names[i] = Console.ReadLine();
                for (int j = 0; j < names[i].Length; j++)
                {
                    int letter = names[i][j];

                    if (letter == 'a' || letter == 'o' || letter == 'e'
                        || letter == 'i' || letter == 'u'
                        || letter == 'A' || letter == 'O' || letter == 'E'
                        || letter == 'I' || letter == 'U')
                    {
                        curentSum += letter * names[i].Length;
                    }
                    else
                    {
                        curentSum += letter / names[i].Length;
                    }
                }
                result[i] = curentSum;
            }
            for (int i = 0; i < result.Length; i++)
            {
                int minNum = int.MaxValue;
                int curentIndexJ = 0;
                for (int j = i; j < result.Length; j++)
                {
                    if (minNum > result[j])
                    {
                        minNum = result[j];
                        curentIndexJ = j;
                    }
                }
                result[curentIndexJ] = result[i];
                result[i] = minNum;
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
