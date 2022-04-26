using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var wardrop = new Dictionary<string, Dictionary<string, int>>();
            //var n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    var input = Console.ReadLine()
            //        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            //    var color = input[0];
            //    var clothes = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();

            //    if (!wardrop.ContainsKey(color))
            //    {
            //        wardrop.Add(color, new Dictionary<string, int>());
            //    }
            //    foreach (var item in clothes)
            //    {
            //        if (!wardrop[color].ContainsKey(item))
            //        {
            //            wardrop[color].Add(item, 0);
            //        }
            //        wardrop[color][item]++;
            //    }
            //}

            //var finalCmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //var searchedColor = finalCmd[0];
            //var clotheType = finalCmd[1];

            //foreach (var ClothesColor in wardrop)
            //{
            //    Console.WriteLine($"{ClothesColor.Key} clothes:");

            //    foreach (var item in ClothesColor.Value)
            //    {
            //        if (searchedColor == ClothesColor.Key && clotheType == item.Key)
            //        {
            //            Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"* {item.Key} - {item.Value}");
            //        }
            //    }
            //}
        }
    }
    public class Wardrobe
    {
        public string Color { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }

        public Wardrobe(string color, string type)
        {

        }
    }
}
