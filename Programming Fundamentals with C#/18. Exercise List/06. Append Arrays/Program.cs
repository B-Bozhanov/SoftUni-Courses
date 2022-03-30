using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1   2  3    ||2 3 4|2

            string command = Console.ReadLine();
            //List<string> elements = new List<string>();
            string[] currentElement = command.Split("|",StringSplitOptions.RemoveEmptyEntries);
           
            for (int i = currentElement.Length -1; i >= 0  ; i--)
            {
                List<string> list = currentElement[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
