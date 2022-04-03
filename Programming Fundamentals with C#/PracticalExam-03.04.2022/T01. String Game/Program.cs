using System;

namespace T01._String_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string commands = Console.ReadLine();

            while (commands != "Done")
            {
                string[] cmdArgs = commands
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (action == "Change")
                {
                    string oldChar = cmdArgs[1];
                    string newChar = cmdArgs[2];
                    text = text.Replace(oldChar, newChar);
                    Console.WriteLine(text);
                }
                else if (action == "Includes")
                {
                    string substring = cmdArgs[1];
                    Console.WriteLine(text.Contains(substring));
                }
                else if (action == "End")
                {
                    string endString = cmdArgs[1];
                    Console.WriteLine(text.EndsWith(endString));
                }
                else if (action == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (action == "FindIndex")
                {
                    string ch = cmdArgs[1];
                    int index = text.IndexOf(ch);
                    Console.WriteLine(index);
                }
                else if (action == "Cut")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int count = int.Parse(cmdArgs[2]);
                    text = text.Substring(startIndex, count);
                    Console.WriteLine(text);
                }
                commands = Console.ReadLine();
            }
        }
    }
}
