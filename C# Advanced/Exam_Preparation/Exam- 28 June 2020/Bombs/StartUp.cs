using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Bomb> bombs = new List<Bomb>
            {
                new Bomb("Datura Bombs", 40),
                new Bomb("Cherry Bombs", 60),
                new Bomb("Smoke Decoy Bombs", 120)
            };

            Queue<int> bombEffect = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());
            Stack<int> bombCasing = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());

            while (true)
            {
                if (bombs.All(x => x.Count >= 3))
                {
                    Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                    break;
                }
                else if (!bombEffect.Any() || !bombCasing.Any())
                {
                    Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
                    break;
                }

                var currentEffect = bombEffect.Peek();
                var currentCasing = bombCasing.Peek();

                while (!bombs.Any(x => x.Value == currentEffect + currentCasing))
                {
                    currentCasing -= 5;
                }

                Bomb currentBomb = bombs.FirstOrDefault(x => x.Value == currentEffect + currentCasing);
                currentBomb.Count++;
                bombEffect.Dequeue();
                bombCasing.Pop();
            }

            if (bombEffect.Any())
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffect)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            if (bombCasing.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            foreach (Bomb item in bombs.OrderBy(x => x.Name))
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Bomb
    {
        public Bomb(string name, int value)
        {
            this.Name = name;
            this.Value = value;
            this.Count = 0;
        }

        public string Name { get; }
        public int Value { get;}
        public int Count { get; set; }

        public override string ToString()
        {
            return $"{this.Name}: {this.Count}";
        }
    }
}
