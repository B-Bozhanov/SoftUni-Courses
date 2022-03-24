
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
            int[] bugs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] field = new int[fieldSize];


            for (int i = 0; i < bugs.Length; i++)
            {
                if (bugs[i] >= 0 && bugs[i] < fieldSize)
                {
                    field[bugs[i]] = 1;
                }
            }

            string command = Console.ReadLine();
            string[] command2 = new string[3];
            while (command != "end")
            {
                command2 = command.Split();
                int INDEX = int.Parse(command2[0]);
                string direction = command2[1];
                int flying = int.Parse(command2[2]);
                IsFlyingAboveZero(ref direction, ref flying);


                if (INDEX >= 0 && INDEX < fieldSize)
                {

                    if (field[INDEX] == 1)
                    {

                        if (direction == "right")
                        {
                            for (int i = INDEX; i < field.Length; i++)
                            {

                                if (i + flying >= fieldSize)
                                {
                                    field[INDEX] = 0;
                                    break;
                                }
                                else if (field[i + flying] == 1)
                                {
                                    i = (i + flying) - 1;
                                    continue;
                                }
                                else
                                {
                                    field[INDEX] = 0;
                                    field[i + flying] = 1;
                                    break;
                                }

                            }

                        }
                        if (direction == "left")
                        {
                            for (int i = INDEX; i >= 0; i--)
                            {

                                if (i - flying < 0)
                                {
                                    field[INDEX] = 0;
                                    break;
                                }
                                else if (field[i - flying] == 1)
                                {
                                    i = (i - flying) + 1;
                                    continue;
                                }
                                else
                                {
                                    field[INDEX] = 0;
                                    field[i - flying] = 1;
                                    break;
                                }

                            }
                        }

                    }
                }


                command = Console.ReadLine();

            }
            Console.WriteLine($"{string.Join(" ", field)}");

        }

        private static void IsFlyingAboveZero(ref string direction, ref int flying)
        {
            if (direction == "left" && flying < 0)
            {
                flying = Math.Abs(flying);
                direction = "right";
            }
            else if (direction == "right" && flying < 0)
            {
                flying = Math.Abs(flying);
                direction = "left";
            }
        }
    }
}