using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@#+)([A-Z][A-Za-z0-9]{4,}[A-Z])(@#+)";
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currProducts = Console.ReadLine();
                Match match = Regex.Match(currProducts, pattern);

                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                StringBuilder groupOutput = new StringBuilder(); // 00 by default.
                string currProduct = match.Groups[2].Value;
                bool isDigit = false;

                foreach (char product in currProduct)
                {
                    if (Char.IsDigit(product))
                    {
                        groupOutput.Append(product);
                        isDigit = true;
                    }
                }
                if (!isDigit)
                {
                    Console.WriteLine($"Product group: {"00"}");
                }
                else
                {
                    Console.WriteLine($"Product group: {string.Join("", groupOutput)}");
                }
            }
        }
    }
}
