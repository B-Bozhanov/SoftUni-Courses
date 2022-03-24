using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] inputArgs = input.Split();

                string item = inputArgs[0];
                double price = double.Parse(inputArgs[1]);
                int quantity = int.Parse(inputArgs[2]);

                if (!products.ContainsKey(item))
                {
                    products.Add(item, new double[2]);
                }
                products[item][0] = price;
                products[item][1] += quantity;

                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                double productPrice = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key} -> {productPrice:f2}");
            }
        }
    }
}
