using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)));
            int capacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int boxes = 0;

            if (clothes.Count == 1 && clothes.Peek() == 0 || capacity == 0)
            {
                //Console.WriteLine("Incorect input");
                return;
            }

            while (clothes.Count != 0)
            {
                int current = clothes.Pop();
                sum += current;

                if (sum >= capacity)
                {
                    if (sum > capacity)
                    {
                        clothes.Push(current);
                    }
                    boxes++;
                    sum = 0;
                }
                else if (clothes.Count == 0)
                {
                    boxes++;
                }
            }
            Console.WriteLine(boxes);
        }
    }
}
