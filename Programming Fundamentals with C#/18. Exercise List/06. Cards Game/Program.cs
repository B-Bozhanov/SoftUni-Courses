using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        public static object Select { get; private set; }

        static void Main(string[] args)
        {
            // 10 20 30 40 50
            // 50 40 30 30 10

            List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count1 = firstPlayer.Count;
            int count2 = secondPlayer.Count;
            for (int i = 0; i < int.MaxValue; i++)
            {

                if (firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Add(secondPlayer[0]);
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else if (firstPlayer[0] < secondPlayer[0])
                {
                    secondPlayer.Add(firstPlayer[0]);
                    secondPlayer.Add(secondPlayer[0]);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }

                if (firstPlayer.Count == 0)
                {
                    int sum = 0;
                    for (int j = 0; j < secondPlayer.Count; j++)
                    {
                        sum += secondPlayer[j];
                    }
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (secondPlayer.Count == 0)
                {
                    int sum = 0;
                    for (int j = 0; j < firstPlayer.Count; j++)
                    {
                        sum += firstPlayer[j];
                    }
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}
