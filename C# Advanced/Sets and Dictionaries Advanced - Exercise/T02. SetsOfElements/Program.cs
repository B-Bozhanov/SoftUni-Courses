using System;
using System.Collections.Generic;
using System.Linq;

namespace T02._SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];

            HashSet<int> firstSeq = new HashSet<int>();
            HashSet<int> seccondSeq = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                firstSeq.Add(inputNum);
            }

            for (int i = 0; i < m; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                seccondSeq.Add(inputNum);
            }
            // May with List<int> ??? = firstSeq.Intersect(seccondSeq);
            foreach (var first in firstSeq)
            {
                foreach (var seccond in seccondSeq) // May with seccond.Contains(first)
                {
                    if (first == seccond)
                    {
                        Console.Write(first + " ");
                    }
                }
            }
        }
    }
}
