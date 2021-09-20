using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int primeSum = 0;
            int noPrimeSum = 0;
            while (command != "stop")
            {
                int flag = 0;
                int numbers = int.Parse(command);
                if (numbers < 0)
                {
                    Console.WriteLine("Number is negative.");
                    command = Console.ReadLine();
                    continue;
                }
                int primeNume = numbers / 2;

                for (int i = 2; i <= primeNume; i++)
                {
                    if (numbers % i == 0)
                    {
                        noPrimeSum += numbers;
                        flag = 1;
                        break;
                    }

                }
                if (flag == 0)
                {
                    primeSum += numbers;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {noPrimeSum}");

            //int n, i, m = 0, flag = 0;
            //Console.Write("Enter the Number to check Prime: ");
            //n = int.Parse(Console.ReadLine());
            //m = n / 2;
            //for (i = 2; i <= m; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.Write("Number is not Prime.");
            //        flag = 1;
            //        break;
            //    }
            //}
            //if (flag == 0)
            //    Console.Write("Number is Prime.");
        }
    }
}
