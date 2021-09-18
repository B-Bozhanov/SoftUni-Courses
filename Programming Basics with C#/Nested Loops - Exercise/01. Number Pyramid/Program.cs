using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int current = 1;
            int figure = num * current;
           
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{current} " );
                    current++;
                    if (current > num)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
