using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 1 1 2 3 3 2 2 2 1 => 2 2 2:

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            
            int maxSecuence =0;
            int element = 0;
            

            for (int i = 0; i < input.Length; i++)
            {
                int curentSequence = 1;
                int curentElement = 0;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        curentSequence++;
                        curentElement = input[i];
                    }
                    else
                    {
                        break;
                    }
                }
                if (maxSecuence < curentSequence)
                {
                    maxSecuence = curentSequence;
                    element = curentElement;
                }
            }

            for (int i = 0; i < maxSecuence; i++)
            {
                Console.Write(element + " ");
            }
        }
    }
}
