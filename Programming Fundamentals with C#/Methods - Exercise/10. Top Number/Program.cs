using System;
using System.Collections.Generic;
using System.Linq;


namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
       
            PrintAllTopIntegers(n);
        }

        private static void PrintAllTopIntegers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string curentNum = i.ToString();
                int curentNumber = 0;
                bool IsOdd = false;
                int sum = 0;
                
                for (int j = 0; j < curentNum.Length; j++)
                {
                    curentNumber = int.Parse(curentNum[j].ToString());
                    sum += curentNum[j];
                    if (curentNum[j] % 2 != 0)
                    {
                        IsOdd = true;
                    }
                }
                if (sum % 8 == 0 && IsOdd)
                {
                    Console.WriteLine($"{i} ");
                }
            }

        }
    }
}
