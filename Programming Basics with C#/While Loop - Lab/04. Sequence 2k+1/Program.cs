using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 1;

            while (number >= counter)
            {
                Console.WriteLine(counter);
                counter = counter * 2 + 1;
            }
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(i);
            //    i *= 2 ;
            //}
        }
    }
}
