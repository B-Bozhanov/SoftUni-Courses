using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santa_s_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> houses = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int position = 0;

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string action = commands[0];

                if (action == "Forward")
                {
                    int steps = int.Parse(commands[1]);
                    int currPosition = steps + position;
                    if (currPosition >= 0 && currPosition < houses.Count)
                    {
                    }
                        houses.RemoveAt(currPosition);
                        position = currPosition;
                }
                else if (action == "Back")
                {
                    int steps = int.Parse(commands[1]);
                    int currPosition = position - steps;
                    
                    if (currPosition >= 0 && currPosition < houses.Count)
                    {
                        houses.RemoveAt(currPosition);
                        position = currPosition;
                    }
                }
                else if (action == "Gift")
                {
                    int index = int.Parse(commands[1]);
                    int value = int.Parse(commands[2]);

                    if (index >= 0 && index < houses.Count)
                    {
                        houses.Insert(index, value);
                        position = index;
                    }
                }
                else if (action == "Swap")
                {
                    int value1 = int.Parse(commands[1]);
                    int value2 = int.Parse(commands[2]);
                    if (houses.Contains(value1) && houses.Contains(value2))
                    {
                        int index1 = houses.FindIndex(x => x.Equals(value1));
                        int index2 = houses.FindIndex(x => x.Equals(value2));
                        houses[index1] = value2;
                        houses[index2] = value1;
                    }
                }
            }
            Console.WriteLine($"Position: {position}");
            Console.WriteLine(string.Join(", ", houses));
        }
    }
}
