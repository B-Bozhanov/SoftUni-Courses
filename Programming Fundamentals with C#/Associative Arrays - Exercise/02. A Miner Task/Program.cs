using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resurces = Console.ReadLine();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (resurces != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(resurces))
                {
                    dict.Add(resurces, 0);
                }
                dict[resurces] += quantity;

                resurces = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
