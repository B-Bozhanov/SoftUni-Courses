using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
             //int minMoney = int.Parse(Console.ReadLine());
            double totalSavedMoney = 0;
       
            while (destination != "End")
            {
                double minMoney = double.Parse(Console.ReadLine());

                while (minMoney >= totalSavedMoney)
                {
                    double money = double.Parse(Console.ReadLine());
                    totalSavedMoney += money;
                    if (totalSavedMoney >= minMoney)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }         
                totalSavedMoney = 0;
                destination = Console.ReadLine();
            }

            //while (destination != "End")
            //{
            //    double minMoney = double.Parse(Console.ReadLine());

            //    for (int i = 0; i <= minMoney; i++)
            //    {
            //        double savedMoney = double.Parse(Console.ReadLine());
            //        totalSavedMoney += savedMoney;
            //        if (totalSavedMoney >= minMoney)
            //        {
            //            Console.WriteLine($"Going to {destination}!");
            //            break;
            //        }

            //    }
            //    totalSavedMoney = 0;
            //    destination = Console.ReadLine();
            //}
        }
    }
}
