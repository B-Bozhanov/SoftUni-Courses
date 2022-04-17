using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => int.Parse(x))
                 .ToArray();

            Stack<int> finalResult = new Stack<int>();

            foreach (var item in numbers)
            {
                finalResult.Push(item);
            }

            string commands = Console.ReadLine().ToLower();
            while (commands != "end")
            {
                string[] cmdArgs = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "add")
                {
                    int num1 = int.Parse(cmdArgs[1]);
                    int num2 = int.Parse(cmdArgs[2]);

                    finalResult.Push(num1);
                    finalResult.Push(num2);
                }
                else if (action == "remove")
                {
                    int num1 = int.Parse(cmdArgs[1]);
                    if (num1 <= finalResult.Count)
                    {
                        for (int i = 0; i < num1; i++)
                        {
                            finalResult.Pop();
                        }
                    }
                }
                commands = Console.ReadLine().ToLower();
            }

            int sum = 0;
            foreach (var item in finalResult)
            {
                sum += item;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
