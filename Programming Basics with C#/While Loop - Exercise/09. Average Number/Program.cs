using System;

namespace _05._Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            int count = 0;
            while (count < n)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                count++;
            }
            double average = sum / count;
            Console.WriteLine($"{average:f2}");
        }
    }
}
