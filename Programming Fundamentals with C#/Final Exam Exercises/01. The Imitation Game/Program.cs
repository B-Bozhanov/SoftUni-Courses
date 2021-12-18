using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Decode")
            {
                string[] commandArgs = command.Split('|');
                string action = commandArgs[0];

                if (action == "Move")
                {
                    int n = int.Parse(commandArgs[1]);                                        // Get the number of chars that have to move.
                    string otherElements = message.Substring(n, message.Length - n);          // Get elements that will stay in the message.
                    string movvedElements = message.Substring(0, n);                          // Get elements that have to move.

                    message = otherElements + movvedElements;                                 // Concatenate them and update the message.
                }
                else if (action == "Insert")
                {
                    List<char> messageElements = message.ToList();                            // Convert the message to char List
                    List<char> charList = commandArgs[2].ToList();                            // Convert input string from the command to char List.
                    int index = int.Parse(commandArgs[1]);

                    messageElements.InsertRange(index, charList);                            // Insert received collection to current message elements
                    message = string.Join("", messageElements);                              // Convert from Char List to string.
                }
                else if (action == "ChangeAll")
                {
                    List<char> messageElements = message.ToList();
                    List<char> currentSymbol = commandArgs[1].ToList();                       // Same logic
                    List<char> replaceSymbol = commandArgs[2].ToList();            

                    for (int i = 0; i < currentSymbol.Count; i++)
                    {
                        for (int j = 0; j < messageElements.Count; j++)
                        {
                            if (messageElements[j] == currentSymbol[i])
                            {
                                messageElements[j] = replaceSymbol[i];                        // Replace characers
                            }
                        }
                    }
                    message = string.Join("", messageElements);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
