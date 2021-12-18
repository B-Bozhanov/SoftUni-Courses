using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem is solving without Regex
            string command = Console.ReadLine();

            List<string> sequence = new List<string>();       // Collect elements from string command, after spliting.
            char[] symbol = new char[] { '#', '|' };          // Create array with needed symbols for Split.
            SplitString(command, sequence, symbol);           // Create Method to Split the string  by the given symbols.
            int calories = 0;
            List<string> result = new List<string>();         // Collect only valid elements.

            for (int i = 0; i < sequence.Count; i++)
            {
                string current = sequence[i];
                bool IsCorectName = CheckItemName(current);    // Check item name is valid (from ASCII table)
                if (IsCorectName)
                {
                    if (i + 2 < sequence.Count)                // Check is still in the aray.
                    {
                        current = sequence[i + 1];
                        bool IsCorectDate = CheckDate(current);   
                        if (IsCorectDate)
                        {
                            current = sequence[i + 2];
                            bool IsCorectCalories = CheckCalories(current);
                            if (IsCorectCalories)
                            {
                                result.Add(sequence[i]);
                                result.Add(sequence[i + 1]);
                                result.Add(sequence[i + 2]);
                                calories += int.Parse(current);
                                i += 2;
                            }
                        }
                    }
                }
            }
            int days = calories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");

            for (int i = 0; i < result.Count; i += 3)
            {
                Console.WriteLine($"Item: {result[i]}, Best before: {result[i + 1]}, Nutrition: {result[i + 2]}");
            }
        }
        static bool CheckCalories(string current)
        {
            bool IsTrue = true;
            for (int j = 0; j < current.Length; j++)
            {
                if (current[j] < 48 || current[j] > 57)
                {
                    IsTrue = false;
                }
            }
            return IsTrue;
        }
        static bool CheckDate(string current)
        {
            bool IsTrue = true;

            for (int j = 0; j < current.Length; j++)
            {
                if (current[j] < 47 || current[j] > 57)
                {
                    IsTrue = false;
                }
            }
            if (current.Length != 8)
            {
                IsTrue = false;
            }
            return IsTrue;
        }
        static bool CheckItemName(string current)
        {
            bool IsTrue = true;
            for (int j = 0; j < current.Length; j++)
            {
                if (current[j] != 32 && current[j] < 65 || current[j] > 90 && current[j] < 97 || current[j] > 122)
                {
                    IsTrue = false;
                }
            }
            return IsTrue;
        }
        private static void SplitString(string command, List<string> elements, char[] symbol)
        {
            char currSymbol = ' ';
            List<char> currList = new List<char>();      // Save other chars except currSymbol:
            for (int i = 0; i < command.Length; i++)
            {
                for (int x = 0; x < symbol.Length; x++) 
                {
                    if (command[i] == symbol[x])           
                    {
                        currSymbol = symbol[x];             // Give value on currSymbol:
                        break;
                    }
                }
                for (int x = 0; x < symbol.Length; x++)   //Add other chars except currSymbol to Char List:
                {
                    if (symbol[x] != currSymbol)
                    {
                        currList.Add(symbol[x]);
                    }
                }

                string currentElement = string.Empty;
                if (command[i] == currSymbol)
                {
                    bool Istrue = CheckIsTrue(command, i, currSymbol, currList);   // Method check is the symbol still in the aray, and whether will meet another symbol
                    if (Istrue)                                                    // except it self.
                    {
                        int j = i + 1;
                        while (command[j] != currSymbol)
                        {
                            currentElement += command[j];
                            j++;
                            i = j - 1;
                        }
                        elements.Add(currentElement);
                    }
                }
            }
        }

        private static bool CheckIsTrue(string command, int num, char symbol, List<char> charList)
        {
            bool Istrue = true;
            int i = num + 1;

            if (i >= command.Length)
            {
                Istrue = false;
                return Istrue;
            }
            while (command[i] != symbol)
            {
                for (int x = 0; x < charList.Count; x++)
                {
                    if (command[i] == charList[x])
                    {
                        Istrue = false;
                        return Istrue;
                    }
                }
                i++;
                if (i >= command.Length)
                {
                    Istrue = false;
                    break;
                }
            }
            if (i == num + 1)
            {
                Istrue = false;
            }
            return Istrue;
        }
    }
}
