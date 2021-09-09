using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {  
            double totalMoney = 0;
            string command = Console.ReadLine();

            while (command != "NoMoreMoney")
            {
                double currentMoney = double.Parse(command);
               
                if (currentMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }              
                    totalMoney += currentMoney;
                    Console.WriteLine($"Increase: {currentMoney:f2}");
                
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total: {totalMoney:f2}");
        }
    }
}
