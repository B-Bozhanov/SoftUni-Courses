using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int numOfRooms = int.Parse(Console.ReadLine());

            for (int i = floor; i > 0; i--)
            {
                for (int j = 0; j < numOfRooms; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (i == floor)
                        {
                            Console.Write($"L{i}{j} ");
                        }
                        else
                        {
                            Console.Write($"O{i}{j} ");
                        }
                    }
                    else
                    {
                        if (i == floor)
                        {
                            Console.Write($"L{i}{j} ");
                        }
                        else
                        {
                            Console.Write($"A{i}{j} ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
