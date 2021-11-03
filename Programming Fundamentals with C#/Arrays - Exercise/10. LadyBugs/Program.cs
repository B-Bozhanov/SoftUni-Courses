using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            //"1 right 1"
            // 0 1 2 10 50 -- bugs
            // 0 1 1 0 0 -- field

            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] bugs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < bugs.Length; i++)
            {
                if (bugs[i] > field.Length - 1 || bugs[i] < 0)
                {
                    continue;
                }
                else
                {
                    field[bugs[i]] = 1;
                }
            }

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] Command = new string[3];
                Command = command.Split();
                int INDEX = int.Parse(Command[0]);
                string direction = Command[1];
                int Flying = int.Parse(Command[2]);

                if (INDEX >= 0
                    && INDEX < field.Length
                    && field[INDEX] == 1)
                {
                    if (direction == "right")
                    {
                        field[INDEX] = 0;
                        for (int i = INDEX; i < field.Length; i++)
                        {
                            if (i + Flying >= field.Length)
                            {
                                break;
                            }
                            else if (field[i + Flying] == 1)
                            {
                                i = (i + Flying) - 1;
                                continue;
                            }
                            else
                            {
                                field[i + Flying] = 1;
                                break;
                            }
                        }
                    }

                    else if (direction == "left")
                    {
                        field[INDEX] = 0;
                        for (int i = INDEX; i >= 0; i--)
                        {
                            if (i - Flying < 0)
                            {
                                break;
                            }
                            else if (field[i - Flying] == 1)
                            {
                                i = (i + Flying) - 1;
                                continue;
                            }
                            else
                            {
                                field[i - Flying] = 1;
                                break;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"{string.Join(" ", field)}");
        }
    }
}