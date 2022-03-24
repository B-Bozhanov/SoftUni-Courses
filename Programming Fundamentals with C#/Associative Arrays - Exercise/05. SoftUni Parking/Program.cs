using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registered = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input =Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = input[0];
                string userName = input[1];

                if (action == "register")
                {
                    string userId = input[2];
                    if (!registered.ContainsKey(userName))
                    {
                        registered.Add(userName, userId);
                    }
                }
                else if (action == "unregister")
                {

                }
            }
        }
    }
}
