using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePatern = @"[^0-9\+\-\*\/\.]";
            string splitInputPatern = @"[^,\s]+"; 
            string damagePatern = @"([\-\+][0-9]+\.[0-9]+)|([0-9]+\.[0-9]+)|([\-\+][0-9]+)|([0-9]+)"; 
            string mathPatern = @"[\*\/]";

            string input = Console.ReadLine();
            MatchCollection splitInput = Regex.Matches(input, splitInputPatern);
            List<string> demonNames = new List<string>();
            Dictionary<string, double[]> result = new Dictionary<string, double[]>();

            foreach (Match item in splitInput)
            {
                demonNames.Add(item.Value);
            }

            for (int i = 0; i < demonNames.Count; i++)
            {
                string currName = demonNames[i];
                int demonHealth = 0;
                double demonDamage = 0;
                string test = string.Empty;

                MatchCollection health = Regex.Matches(currName, namePatern);
                MatchCollection damage = Regex.Matches(currName, damagePatern);
                MatchCollection math = Regex.Matches(currName, mathPatern);

                foreach (Match item in health)
                {
                    test += item.Value;
                }
                for (int j = 0; j < test.Length; j++)
                {
                    demonHealth += test[j];
                }

                foreach (Match item in damage)
                {
                    demonDamage += double.Parse(item.Value);
                }
                foreach (Match item in math)
                {
                    if (item.Value == "*")
                    {    
                        demonDamage *= 2;
                    }
                    else if (item.Value == "/")
                    {
                        demonDamage /= 2;
                    }
                }

                if (!result.ContainsKey(currName))
                {
                    result.Add(currName, new double[2]);
                }
                result[currName][0] = demonHealth;    // first index in double array in Dictionary
                result[currName][1] = demonDamage;    // second index in double array in Dictionary
            }

            foreach (var item in result.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} health, {item.Value[1]:f2} damage");
            }
        }
    }
}
