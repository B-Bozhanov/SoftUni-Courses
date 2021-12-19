using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                int index = int.Parse(commandArgs[1]);
                int endIndex = int.Parse(commandArgs[2]);
                int partitions = int.Parse(commandArgs[2]);

                if (action == "merge")
                {
                    if (index < 0 && endIndex >= 0 && endIndex < names.Count)
                    {
                        index = 0;
                        MergeIndexes(names, index, endIndex);
                    }
                    else if (endIndex >= names.Count && index >= 0 && index < names.Count)
                    {
                        endIndex = names.Count - 1;
                        MergeIndexes(names, index, endIndex);
                    }
                    else if (index >= 0 && index < names.Count && endIndex >= 0 && endIndex < names.Count)
                    {
                        MergeIndexes(names, index, endIndex);
                    }
                    else if (index < 0 && endIndex >= names.Count)
                    {
                        index = 0;
                        endIndex = names.Count - 1;
                        MergeIndexes(names, index, endIndex);
                    }
                }
                else if (action == "divide")
                {
                    string curentString = names[index];
                    List<string> curentList = new List<string>();
                    int parts = curentString.Length / partitions;

                    for (int i = 0; i < partitions; i++)
                    {
                        int lastElements = curentString.Length - (parts * i);

                        if (i == partitions - 1)
                        {
                            curentList.Insert(i, curentString.Substring(parts * i, lastElements));
                        }
                        else
                        {
                            curentList.Insert(i, curentString.Substring(parts * i, parts));
                        }

                    }
                    if (parts > 0 && parts <= 100)
                    {
                        names.RemoveAt(index);
                        names.InsertRange(index, curentList);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", names));
        }

        static void MergeIndexes(List<string> names, int index, int endIndex)
        {
            string mergedElements = string.Empty;
            int counter = 0;
            for (int i = index; i <= endIndex; i++)
            {
                mergedElements += names[i];
                counter++;
            }
            names.RemoveRange(index, counter);
            names.Insert(index, mergedElements);
        }
    }
}
