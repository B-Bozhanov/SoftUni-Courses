using System;
using System.Linq;


namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            // 123
            while (command != "END")
            {

                string reversed = string.Empty;
                for (int i = command.Length -1; i >= 0; i--)
                {
                    reversed += command[i];
                }
                if (command == reversed)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("fal");
                }
               
                //char[] curentNum = new char[command.Length];
                //char[] reversedNum = new char[command.Length];


                //for (int i = 0; i < command.Length; i++)
                //{
                //    curentNum[i] = command[i];
                //}
                //for (int i = command.Length - 1; i >= 0; i--)
                //{
                //    reversedNum[(curentNum.Length - 1) - i] = command[i];

                //}
                //string curent = string.Empty;
                //string reversed = string.Empty;
                //for (int i = 0; i < curentNum.Length; i++)
                //{
                //    curent += curentNum[i];
                //}
                //for (int i = 0; i < reversedNum.Length; i++)
                //{
                //    reversed += reversedNum[i];
                //}
                //if (curent == reversed)
                //{
                //    Console.WriteLine("true");
                //}
                //else
                //{
                //    Console.WriteLine("false");
                //}

                command = Console.ReadLine();
            }


        }
    }
}
