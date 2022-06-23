using System;
using System.Linq;

namespace BeaverAtWork
{
    public class StartUp
    {
        public static void Main()
        {
            var pondSize = int.Parse(Console.ReadLine());
            var pond = new char[pondSize, pondSize];

            FillPond(pond);
            int[] pondInfo = GetPondInfo(pond);

            var beaver = new Beaver(pondInfo[0], pondInfo[1], 'B');
            beaver.BranchesForCollect = pondInfo[2];

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    Console.WriteLine($"The Beaver failed to collect every wood branch. There are {beaver.BranchesForCollect} branches left.");
                    break;
                }

                int row = 0;
                int col = 0;
                switch (command)
                {
                    case "up": row -= 1; break;
                    case "down": row += 1; break;
                    case "left": col -= 1; break;
                    case "right": col += 1; break;
                }

                beaver.Move(pond, row, col);

                if (beaver.BranchesForCollect == 0)
                {
                    Console.WriteLine($"The Beaver successfully collect {beaver.Branches.Count} wood branches: " +
                        $"{String.Join(", ", beaver.Branches.Reverse())}.");
                    break;
                }
            }

            PrintPond(pond);
        }
        private static void FillPond(char[,] pond)
        {
            for (int row = 0; row < pond.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Where(x => !Char.IsWhiteSpace(x)).ToArray();
                for (int col = 0; col < pond.GetLength(1); col++)
                {
                    pond[row, col] = input[col];
                }
            }
        }
        private static int[] GetPondInfo(char[,] pond)
        {
            int[] info = new int[3];
            for (int row = 0; row < pond.GetLength(0); row++)
            {
                for (int col = 0; col < pond.GetLength(1); col++)
                {
                    if (pond[row, col] == 'B')
                    {
                        info[0] = row;
                        info[1] = col;
                    }
                    else if (Char.IsLower(pond[row, col]))
                    {
                        info[2] += 1;
                    }
                }
            }
            return info;
        }
        private static void PrintPond(char[,] pond)
        {
            for (int row = 0; row < pond.GetLength(0); row++)
            {
                for (int col = 0; col < pond.GetLength(1); col++)
                {
                    Console.Write(pond[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}