using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> clients = new Queue<string>();

            while (input != "End")
            {
                if (input != "Paid")
                {
                    clients.Enqueue(input);

                }
                if (input == "Paid")
                {
                    foreach (var item in clients)
                    {
                        Console.WriteLine(item);
                    }
                    clients.Clear();
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{clients.Count} people remaining.") ;
        }
    }
}
