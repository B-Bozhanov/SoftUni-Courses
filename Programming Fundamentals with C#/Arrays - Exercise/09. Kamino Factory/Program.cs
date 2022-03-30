using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] bestDNA = new int[n];
            string command = Console.ReadLine();

            int maxSequence = 0;
            int minIndex = int.MaxValue;
            int maxOnes = 0;
            int count = 0;
            int curentCount = 0;
            int SumOfDNA = 0;

            while (command != "Clone them!")
            {

                int[] sequences = new int[n];
                sequences = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int arrSequence = 0;
                int ones = 0;
                int curentIndex = 0;
                curentCount++;

                for (int i = 0; i < sequences.Length; i++)
                {
                    int curentSequence = 1;
                    if (sequences[i] == 1)
                    {
                        ones++;
                    }
                    for (int j = i + 1; j < sequences.Length; j++)
                    {
                        if (sequences[i] == sequences[j] && sequences[i] == 1)
                        {
                            curentSequence++;
                            if (arrSequence < curentSequence)
                            {
                                arrSequence = curentSequence;
                                curentIndex = i;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                }

                if (maxSequence < arrSequence)
                {
                    maxSequence = arrSequence;
                    count = curentCount;
                    bestDNA = sequences;
                    minIndex = curentIndex;
                    maxOnes = ones;
                }
                else if (maxSequence == arrSequence)
                {
                    if (curentIndex < minIndex)
                    {
                        maxSequence = arrSequence;
                        bestDNA = sequences;
                        count = curentCount;
                        minIndex = curentIndex;
                        maxOnes = ones;
                    }
                    else if (curentIndex == minIndex && maxOnes < ones)
                    {
                        maxSequence = arrSequence;
                        bestDNA = sequences;
                        count = curentCount;
                        minIndex = curentIndex;
                        maxOnes = ones;
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < bestDNA.Length; i++)
            {
                SumOfDNA += bestDNA[i];
            }
            Console.WriteLine($"Best DNA sample {count} with sum: {SumOfDNA}.");
            Console.WriteLine($"{string.Join(" ", bestDNA)}");
        }
    }
}
