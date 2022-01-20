using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            //1 23 29 18 43 21 20
            while (command != "End")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];


                if (action == "Add")
                {
                    int num = int.Parse(commandArgs[1]);
                    numbers.Add(num);
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }
                    numbers.Insert(index, number);
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
                else
                {
                    int number = int.Parse(commandArgs[2]);
                   
                    if (commandArgs[1] == "left")
                    {
                        for (int j = 0; j < number; j++)
                        {
                            int firstElement = numbers[0];
                            for (int i = 0; i < numbers.Count - 1; i++)
                            {
                                numbers[i] = numbers[i + 1];
                            }
                            numbers[numbers.Count - 1] = firstElement;

                        }
                    }
                    else if (commandArgs[1] == "right")
                    {
                        for (int i = 0; i < number; i++)
                        {
                            int lastElement = numbers[numbers.Count - 1];
                            for (int j = numbers.Count - 1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }
                            numbers[0] = lastElement;

                        }
                    }
                }


                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
