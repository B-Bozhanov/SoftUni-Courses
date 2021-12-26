using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@[#]+([A-Z][A-Za-z0-9]{4,}[A-Z])@[#]+";
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                
                MatchCollection match = Regex.Matches(input, pattern);
                string current = string.Empty;
                string numbers = string.Empty;
                int Flag = 0;
                foreach (Match item in match)
                {
                    current = item.Groups[1].Value;
                }

                for (int j = 0; j < current.Length; j++)
                {
                    if (current[j] >= 48 && current[j] <= 57)
                    {
                        numbers += (char)current[j];
                        Flag = 1;
                    }
                }

                if (match.Count == 0)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                if (Flag == 0)
                {
                    Console.WriteLine($"Product group: 00");
                }
                else
                {
                    Console.WriteLine($"Product group: {numbers}");
                }
            }
        }
    }
}
