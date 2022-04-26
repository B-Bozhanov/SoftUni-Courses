using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();
            Stack<string> stateOfText = new Stack<string>();

            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string cmdArgs = input[0];

                if (cmdArgs == "1")
                {
                    stateOfText.Push(text.ToString());
                    for (int j = 1; j < input.Length; j++)
                    {
                        text.Append(input[j]);
                    }
                }
                else if (cmdArgs == "2")
                {
                    int count = int.Parse(input[1]);
                    stateOfText.Push(text.ToString());
                    if (count >= 0 && count <= text.ToString().Length)
                    {
                        text.Remove(text.Length - count, count);
                    }
                }
                else if (cmdArgs == "3")
                {
                    int index = int.Parse(input[1]);
                    if (index >= 0 && index <= text.ToString().Length)
                    {
                        Console.WriteLine(text[index - 1]);
                    }
                }
                else if (cmdArgs == "4")
                {
                    if (stateOfText.Count > 0)
                    {
                        text.Clear();
                        text.Append(stateOfText.Pop());
                    }
                }
            }
        }
    }
}
