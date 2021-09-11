using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            double curentCount = 0;
            string curentCommand = string.Empty;
           
            int countDays = 0;

            string command = Console.ReadLine();
            while (ownedMoney != neededMoney)
            {
                countDays++;
                double sum = double.Parse(Console.ReadLine());

                switch (command)
                {
                    case "save":
                        ownedMoney += sum; 
                        curentCommand = command; 
                        curentCount = 0; break;
                    case "spend":
                        if (ownedMoney == 0)
                        {
                            break;
                        }
                        ownedMoney -= sum;
                        if(ownedMoney < 0)
                        {
                            ownedMoney = 0;
                        }
                        curentCommand = command;
                        curentCount++;
                        if (curentCommand == "spend" && curentCount == 5)
                        {
                            Console.WriteLine($"You can't save the money.");
                            Console.WriteLine(countDays);
                            return;
                        }
                        break;
                }
                if (ownedMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {countDays} days.");
                   
                    return;
                }

                command = Console.ReadLine();
            }
        }
    }
}
