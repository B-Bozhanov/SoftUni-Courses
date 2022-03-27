using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //"register {username} {licensePlateNumber}":
            //"{username} => {licensePlateNumber}"

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
                        Console.WriteLine($"{userName} registered {userId} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {userId}");
                    }
                }
                else if (action == "unregister")
                {
                    if (registered.ContainsKey(userName))
                    {
                        registered.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }
            }

            foreach (var item in registered)
            {
                Console.Write($"{item.Key} => {item.Value}");
                Console.WriteLine();
            }
        }
    }
}
