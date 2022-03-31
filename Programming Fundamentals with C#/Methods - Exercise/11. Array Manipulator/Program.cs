using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            if (numbers.Length >= 1 || numbers.Length <= 50)
            {


                string[] command = Console.ReadLine().Split();
                // command[0] -> string e.g."exchange" - command[1] -> action e.g. even/odd
                // 1 2 3 4 5
                // exchange 2
                while (command[0] != "end")
                {
                    switch (command[0])
                    {
                        case "exchange":
                            int action = int.Parse(command[1].ToString());
                            Exchange(numbers, action);
                            break;
                        case "max":
                            PrintMaxEvenOrOddIndex(numbers, command[1]);
                            break;
                        case "min":
                            PrintMinEvenOrOddIndex(numbers, command[1]);
                            break;
                        case "first":
                            int count = int.Parse(command[1].ToString());
                            PrintFirstEvenOrOddNums(numbers, count, command[2]);
                            break;
                        case "last":
                            int count2 = int.Parse(command[1].ToString());
                            PrintLastEvenOrOddNums(numbers, count2, command[2]);
                            break;
                    }

                    command = Console.ReadLine().Split();
                }

                Console.Write($"[");
                Console.Write(string.Join(", ", numbers));
                Console.WriteLine($"]");
            }
        }

        private static void PrintLastEvenOrOddNums(int[] numbers, int action, string command)
        {
            int count = 0;
            int[] curentEven = new int[0]; //
            int[] curentOdd = new int[0];
            if (action > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (command == "even")
            {

                for (int i = numbers.Length -1; i >= 0 ; i--)
                {
                    if (numbers[i] % 2 == 0 && count < action)
                    {
                        Array.Resize(ref curentEven, curentEven.Length + 1);
                        for (int j = count; j < curentEven.Length; j++)
                        {
                            curentEven[j] = numbers[i];
                        }
                        count++;
                    }
                }
                count = 0;
              
                if (curentEven.Length == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", curentEven.Reverse()));
                    Console.WriteLine("]");
                }

            }
            else if (command == "odd")    // 1 10 100 1000
            {
                for (int i = numbers.Length -1; i >= 0 ; i--)
                {
                    if (numbers[i] % 2 != 0 && count < action)
                    {
                        Array.Resize(ref curentOdd, curentOdd.Length + 1);
                        for (int j = count; j < curentOdd.Length; j++)
                        {
                            curentOdd[j] = numbers[i];
                        }
                        count++;
                    }
                }
                count = 0;
                
                if (curentOdd.Length == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", curentOdd.Reverse()));
                    Console.WriteLine("]");
                }
            }
        }

        private static void PrintFirstEvenOrOddNums(int[] numbers, int action, string command)
        {
            // 1 2 3 4 5 6 7 8 9 10
            int count = 0;
            int[] curentEven = new int[0];
            int[] curentOdd = new int[0];
            if (action > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (command == "even")
            {
               
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0 && count < action)
                    {
                        Array.Resize(ref curentEven, curentEven.Length + 1);
                        for (int j = count; j < curentEven.Length; j++)
                        {
                            curentEven[j] = numbers[i];
                        }
                        count++;
                    }
                }
                count = 0;
                if (curentEven.Length == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", curentEven));
                    Console.WriteLine("]");
                }
               
            }
            else if (command == "odd")    // 1 10 100 1000
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0 && count < action)
                    {
                        Array.Resize(ref curentOdd, curentOdd.Length + 1);
                        for (int j = count; j < curentOdd.Length; j++)
                        {
                            curentOdd[j] = numbers[i];
                        }
                        count++;
                    }
                }
                count = 0;
                if (curentOdd.Length == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", curentOdd));
                    Console.WriteLine("]");
                }
            }
        }

        private static void PrintMinEvenOrOddIndex(int[] numbers, string command)
        {
            int minEvenNum = int.MaxValue;
            int minOddNum = int.MaxValue;
            int evenIndex = -1;
            int oddIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (minEvenNum >= numbers[i] && numbers[i] % 2 == 0)
                {
                    minEvenNum = numbers[i];
                    evenIndex = i;
                }
                else if (minOddNum >= numbers[i] && numbers[i] % 2 != 0)
                {
                    minOddNum = numbers[i];
                    oddIndex = i;
                }
            }
            if (command == "even")
            {
                if (evenIndex == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(evenIndex);
                }
            }
            else if (command == "odd")
            {
                if (oddIndex == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(oddIndex);
                }
            }
        }

        static void PrintMaxEvenOrOddIndex(int[] numbers, string command)
        {
            int maxEvenNum = int.MinValue;
            int maxOddNum = int.MinValue;
            int evenIndex = -1;
            int oddIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (maxEvenNum <= numbers[i] && numbers[i] % 2 == 0)
                {
                    maxEvenNum = numbers[i];
                    evenIndex = i;
                }
                else if (maxOddNum <= numbers[i] && numbers[i] % 2 != 0)
                {
                    maxOddNum = numbers[i];
                    oddIndex = i;
                }
            }
            if (command == "even")
            {
                if (evenIndex == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(evenIndex);
                }
            }
            else if (command == "odd")
            {
                if (oddIndex == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(oddIndex);
                }
            }


        }

        static int[] Exchange(int[] numbers, int action)
        {
            if (action < 0 || action >= numbers.Length)
            {
                Console.WriteLine("Invalid index");
                return numbers;
            }

            for (int i = 0; i <= action; i++) // 1 2 3 4 5
            {
                int firstIndex = numbers[0];
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Length - 1] = firstIndex;
            }
            return numbers;
        }
    }
}
