using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
          
            List<int> pokemons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> curentElements = pokemons;
            int SumOfRemovedElement = 0;
            int removedElement = int.MinValue;
            
            while (curentElements.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {                  
                    removedElement = pokemons[0];
                    curentElements[0] = curentElements[^1];
                    ReWriteListGreaterOrLess(curentElements, removedElement);
                }
                else if (index >= pokemons.Count)
                {
                    removedElement = pokemons[^1];
                    curentElements[^1] = curentElements[0];
                    ReWriteListGreaterOrLess(curentElements, removedElement);
                }
                else
                {
                    removedElement = pokemons[index];
                    curentElements.RemoveAt(index);
                    ReWriteListGreaterOrLess(curentElements, removedElement);   
                }
                SumOfRemovedElement += removedElement;
            }
            Console.WriteLine(SumOfRemovedElement);
        }
        private static void ReWriteListGreaterOrLess(List<int> curentElements, int removedElement)
        {
            for (int i = 0; i < curentElements.Count; i++)
            {
                if (curentElements[i] <= removedElement)
                {
                    curentElements[i] += removedElement;
                }
                else
                {
                    curentElements[i] -= removedElement;
                }
            }
        }
    }
}
