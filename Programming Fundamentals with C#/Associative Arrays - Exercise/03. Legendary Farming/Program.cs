using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>
            {
                {"shards", 0},
                {"motes", 0},
                {"fragments", 0}
            };
            Dictionary<string, int> junks = new Dictionary<string, int>();
            string legendaryItem = string.Empty;
            bool isObtained = false;
            int points = 250;

            while (true)
            {
                string currItem = string.Empty;
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 1; i < input.Length; i += 2)
                {
                    currItem = input[i];
                    if (items.ContainsKey(currItem))
                    {
                        items[currItem] += int.Parse(input[i - 1]);
                        if (items[currItem] >= points)
                        {
                            switch (currItem)
                            {
                                case "fragments":
                                    legendaryItem = "Valanyr"; break;
                                case "shards":
                                    legendaryItem = "Shadowmourne"; break;
                                case "motes":
                                    legendaryItem = "Dragonwrath"; break;
                            }

                            items[currItem] = items[currItem] - points;
                            isObtained = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junks.ContainsKey(input[i]))
                        {
                            junks.Add(input[i], 0);
                        }
                        junks[input[i]] += int.Parse(input[i - 1]);
                    }
                }

                if (isObtained)
                {
                    break;
                }
            }

            Console.WriteLine($"{legendaryItem} obtained!");

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var junk in junks)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}