using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> pieces = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> currentPieces = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                pieces.AddRange(currentPieces);
            }
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandArgs = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                string currentPiece = commandArgs[1];

                if (action == "Add")
                {
                    List<string> current = new List<string> { currentPiece, commandArgs[2], commandArgs[3] };
                    pieces.Contains(currentPiece);
                    if (pieces.Contains(currentPiece))
                    {
                        Console.WriteLine($"{currentPiece} is already in the collection!");
                    }
                    else
                    {
                        pieces.AddRange(current);
                        Console.WriteLine($"{currentPiece} by {commandArgs[2]} in {commandArgs[3]} added to the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    if (pieces.Contains(currentPiece))
                    {
                        int index = pieces.FindIndex(x => x.Contains(currentPiece));
                        pieces.RemoveRange(index, 3);
                        Console.WriteLine($"Successfully removed {currentPiece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {currentPiece} does not exist in the collection.");
                    }
                }
                else if (action == "ChangeKey")
                {
                    if (pieces.Contains(currentPiece))
                    {
                        int index = pieces.FindIndex(x => x.Contains(currentPiece));
                        int indexOfKey = index + 2;
                        pieces[indexOfKey] = commandArgs[2];
                        Console.WriteLine($"Changed the key of {currentPiece} to {commandArgs[2]}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {currentPiece} does not exist in the collection.");
                    }
                }
                command = Console.ReadLine();
            }
            List<string> result = new List<string>();

            for (int i = 0; i < pieces.Count; i += 3)
            {
                result.Add($"{pieces[i]} -> Composer: {pieces[i + 1]}, Key: {pieces[i + 2]}");
            }
            result.Sort();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }


    }
}
