using System;
using System.Linq;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                if (action == "TakeOdd")
                {
                    string currPass = string.Empty;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            currPass += input[i];
                        }
                    }
                    input = currPass;
                    Console.WriteLine(input);
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(commandArgs[1]);
                    int length = int.Parse(commandArgs[2]);
                    string currPass = string.Empty;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i == index)
                        {
                            i += length;
                            if (i >= input.Length)
                            {
                                break;
                            }
                        }
                        currPass += input[i];
                    }
                    input = currPass;
                    Console.WriteLine(input);
                }
                else if (action == "Substitute")
                {
                    string substring = commandArgs[1];
                    string substitute = commandArgs[2];
                    string currPass = string.Empty;
                    if (input.Contains(substring))
                    {
                        currPass = input.Replace(substring, substitute);
                        input = currPass;
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {input}");
        }
    }
}
