using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(input);

            int lastElement = queue.LastOrDefault();

            while (queue.Any(x => x % 2 != 0))
            {
                int currNum = queue.Dequeue();

                if (currNum % 2 == 0)
                {
                    queue.Enqueue(currNum);
                }
                if (queue.All(x => x % 2 == 0))
                {
                    if (lastElement % 2 == 0)
                    {
                        queue.Enqueue(queue.Dequeue());
                    }
                }
            }
            Console.WriteLine(String.Join(", ", queue));
        }
    }
}
// 1 2 3 4 5 6
// 1 2 3 4 5 5
// 11 13 18 95 2 112 81 46