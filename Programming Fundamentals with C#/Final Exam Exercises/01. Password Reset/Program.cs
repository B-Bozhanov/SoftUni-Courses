using System;
using System.Linq;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Done")
            {
            StringBuilder currPassword = new StringBuilder();

                string[] commandArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];

                if (action == "TakeOdd")
                {

                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            currPassword.Append(password[i]);
                        }
                    }
                    Console.WriteLine(currPassword);
                    password = currPassword.ToString();
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(commandArgs[1]);
                    int length = int.Parse(commandArgs[2]);

                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if (action == "Substitute")
                {
                    string substring = commandArgs[1];
                    string replaceSring = commandArgs[2];

                    if (password.Contains(substring))
                    {
                        password.Replace(substring, replaceSring);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                command = Console.ReadLine();
            }
            //Console.WriteLine($"Your password is: {currPassword}");
        }
    }
}
