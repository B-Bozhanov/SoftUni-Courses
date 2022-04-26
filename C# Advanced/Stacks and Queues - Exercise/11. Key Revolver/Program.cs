using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var priceOfBulet = int.Parse(Console.ReadLine());
            var barels = int.Parse(Console.ReadLine());
            var bulets = new Stack<int>
                (
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray()
                );
            var locks = new Queue<int>
               (
               Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x))
               );
            var money = int.Parse(Console.ReadLine());
            var shootedBulets = 0;
            
            while (true)
            {
                if (bulets.Count == 0 && locks.Count > 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    break;
                }
                if (locks.Count == 0)
                {
                    var totalPriceOfShootedBulets = priceOfBulet * shootedBulets;
                    var moneyEarned = money - totalPriceOfShootedBulets;
                    Console.WriteLine($"{bulets.Count} bullets left. Earned ${moneyEarned}");
                    break;
                }

                var isToReload = true;

                for (int i = 0; i < barels; i++)
                {
                    if (bulets.Pop() <= locks.Peek()) // Remove bullet
                    {
                        locks.Dequeue();              // If the bullet value is equal or small from locks value, remove curren lock.
                        Console.WriteLine("Bang!");
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }
                    shootedBulets++;                 // bullet shooted increese

                    if (bulets.Count == 0)           // If there is no bullets, not need to Reload.
                    {
                        isToReload = false;
                    }

                    if (bulets.Count == 0 || locks.Count == 0)
                    {
                        if (i != barels - 1)         // Also if there no any locks and we have bullets in the barel yet, no need to reload.
                        {
                            isToReload = false;
                        }
                        break;
                    }
                }

                if (isToReload)
                {
                    Console.WriteLine("Reloading!");
                }
            }
        }
    }
}
