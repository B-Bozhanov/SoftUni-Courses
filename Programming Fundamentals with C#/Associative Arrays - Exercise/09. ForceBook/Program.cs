using System;
using System.Collections.Generic;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Darker | DCay
            // Ivan Ivanov -> Lighter

            // {forceSide} | {forceUser}
            // { forceUser} -> { forceSide}
            Dictionary<string, List<string>> lightSide = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> darkSide = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                string[] inputArgs = input.Split();
                string side = string.Empty;
                string user = string.Empty;

                if (inputArgs[1] == "|")
                {
                     side = inputArgs[0];
                     user = inputArgs[2];

                    if (!darkSide.ContainsKey(side))
                    {
                        darkSide.Add(side, new List<string>());
                    }
                    if (!darkSide[side].Contains(user))
                    {
                        darkSide[side].Add(user);
                    }

                }
                else if (inputArgs[1] == "->")
                {
                     side = inputArgs[2];
                     user = inputArgs[0];
                }
                input = Console.ReadLine();
            }
        }
    }
}
