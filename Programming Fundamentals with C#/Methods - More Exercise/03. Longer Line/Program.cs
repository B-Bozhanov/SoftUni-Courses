using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());


            int countX1y1 = 0;
            if (x1 < 0 )
            {
                countX1y1 += BelowZero(x1, countX1y1);
                if (y1 < 0)
                {
                    countX1y1 += BelowZero(x1, countX1y1);
                }
                else
                {
                    countX1y1 = BelowZero();
                }
            }
            double firstTwice = Math.Abs(y1) * Math.Abs(x1);
            double secondTwice = Math.Abs(y2) * Math.Abs(x2);

            if (x1 == 0)
            {
                firstTwice = y1;
            }
            else if (y1 == 0)
            {
                firstTwice = x1;
            }
            if (x2 == 0)
            {
                secondTwice = y2;
            }
            else if (y2 == 0)
            {
                secondTwice = x2;
            }

            Console.Write("(");
            if (firstTwice < secondTwice)
            {
                Console.Write($"{x1}, {y1}");
            }
            else if (firstTwice > secondTwice)
            {
                Console.Write($"{x2}, {y2}");
            }
            else
            {
                Console.Write($"{x1}, {y1}");
            }
            Console.WriteLine(")");
        }

        private static int BelowZero(int x1, int countX1y1)
        {
            for (int i = x1; i > 0; i--)
            {
                countX1y1++;
            }

            return countX1y1;
        }
    }
}
