using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int result = GetSmallestNum(firstNum, secondNum, thirdNum);
            Console.WriteLine(result);
        }

        static int GetSmallestNum(int a, int b, int c)
        {
            int minNum = 0;
            if (a <= b && a <= c)
            {
                minNum = a;
            }
            else if (b <= a && b <= c)
            {
                minNum = b;
            }
            else if (c <= a && c <= b)
            {
                minNum = c;
            }
            return minNum;
        }
    }
}
