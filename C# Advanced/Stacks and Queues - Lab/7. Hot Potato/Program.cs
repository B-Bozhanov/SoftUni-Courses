using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> players = new Queue<string>(Console.ReadLine().Split(' '));
            int n = int.Parse(Console.ReadLine());
            // Alva James William
            // 20
            while (players.Count != 1)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i == n - 1)
                    {
                        string removedName = players.Dequeue();
                        Console.WriteLine($"Removed {removedName}");
                        break;
                    }
                    players.Enqueue(players.Dequeue());
                }
            }
            Console.WriteLine($"Last is {string.Join("", players)}");
        }
    }
}