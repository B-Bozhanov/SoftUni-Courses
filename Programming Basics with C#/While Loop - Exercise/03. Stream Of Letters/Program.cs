using System;

namespace _03._Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            // H = 72
            string command = Console.ReadLine();
            string word = string.Empty;
            char firstCommand = ' ';
            char secondCommand = ' ';
            char thirdCommand = ' ';
            int countN = 0;
            int countC = 0;
            int countO = 0;
            string finalWords = string.Empty;

            while (command != "End")
            {
                int curr = command[0];
                if (curr < 65 || curr > 90
                    && curr < 97 || curr > 122 )
                {
                    command = Console.ReadLine();
                    continue;
                }
                switch (command)
                {
                    case "n":
                        firstCommand = 'n';
                        countN++;
                        break;
                    case "c":
                        secondCommand = 'c';
                        countC++;
                        break;
                    case "o":
                        thirdCommand = 'o';
                        countO++;
                        break;

                }
                if (command == "n" && countN >= 2)
                {
                    word += (char)curr;
                }
                else if (command == "c" && countC >= 2)
                {
                    word += (char)curr;
                }
                else if (command == "o" && countO >= 2)
                {
                    word += (char)curr;
                }
                else if (command != "n" && command != "c" && command != "o")
                {
                    word += (char)curr;
                }

                if (firstCommand == 'n' && secondCommand == 'c' && thirdCommand == 'o')
                {
                    finalWords += word + " ";
                    firstCommand = ' ';
                    secondCommand = ' ';
                    thirdCommand = ' ';
                    countN = 0;
                    countC = 0;
                    countO = 0;
                    word = string.Empty;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(finalWords);
        }
    }
}
