using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._World_Tou
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> destination = input.ToList();

            string command = Console.ReadLine();
            string currenState = string.Join("", destination);
            // Add Stop:{index}:{string}
            while (command != "Travel")
            {
                string[] commandArgs = command.Split(":");
                string action = commandArgs[0];

                if (action == "Add Stop")
                {
                    int index = int.Parse(commandArgs[1]);
                    List<char> addedString = commandArgs[2].ToList();

                    if (index >= 0 && index < destination.Count)
                    {
                        destination.InsertRange(index, addedString);
                        currenState = string.Join("", destination);
                        Console.WriteLine(currenState);
                    }
                    else
                    {
                        Console.WriteLine(currenState);
                    }
                }
                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    int count = 0;
                    if (startIndex >= 0 && startIndex < destination.Count
                        && endIndex >= 0 && endIndex < destination.Count)
                    {      
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            count++;
                        }
                        destination.RemoveRange(startIndex, count);
                        currenState = string.Join("", destination);
                        Console.WriteLine(currenState);
                    }
                    else
                    {
                        Console.WriteLine(currenState);
                    }
                }
                else if (action == "Switch")
                {
                    string oldDestination = commandArgs[1];
                    string newDestination = commandArgs[2];

                    if (currenState.Contains(oldDestination))               
                    {
                        currenState = currenState.Replace(oldDestination, newDestination); 
                        Console.WriteLine(currenState);
                    }
                    else
                    {
                        Console.WriteLine(currenState);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {currenState}");
        }
    }
}
