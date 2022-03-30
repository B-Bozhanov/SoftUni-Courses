using System;
using System.Linq;

namespace The_Ignitition_Game__Make_Again
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encMessage = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Decode")
            {
                string[] cmdArgs = command
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "Move")
                {
                    int numOfLetters = int.Parse(cmdArgs[1]);

                    string movedLetters = encMessage.Substring(0, numOfLetters);
                    encMessage = encMessage.Substring(numOfLetters) + movedLetters;
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];
                    string originStr = encMessage.Substring(0, index);
                    string endStr = encMessage.Substring(index); // From current index to the end!
                    encMessage = originStr + value + endStr;
                }
                else if (action == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    encMessage = encMessage.Replace(substring, replacement);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {encMessage}");
        }
    }
}

        
