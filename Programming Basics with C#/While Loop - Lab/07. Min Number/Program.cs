using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int currentNumber = int.MaxValue;

            while (command != "Stop")
            {
                int number = int.Parse(command);
                if (currentNumber > number)
                {
                    currentNumber = number;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(currentNumber);
        }
    }
}
