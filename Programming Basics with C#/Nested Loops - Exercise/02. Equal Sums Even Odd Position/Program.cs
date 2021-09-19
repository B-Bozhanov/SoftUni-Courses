using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {   
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
           
            for (int i = numOne; i <= numTwo; i++)
            {
                string cureentNum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;

                for (int j = 0; j < cureentNum.Length; j++)
                {
                    int currentDigit = int.Parse(cureentNum[j].ToString());
                    if (j % 2== 0)
                    {
                        oddSum += currentDigit;
                    }
                    else
                    {
                        evenSum += currentDigit; 
                    }
                }
                int finalSum = int.Parse(i.ToString());
                if (oddSum == evenSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
