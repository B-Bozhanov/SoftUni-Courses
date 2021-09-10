using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int currentNumber = int.MinValue;

            while (command != "Stop")
            {
                int number = int.Parse(command);
                if (currentNumber < number)
                {
                    currentNumber = number;
                }
                
                command = Console.ReadLine();
            }
            Console.WriteLine(currentNumber);
        }
    }
}
