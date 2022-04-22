using System;
using System.Collections.Generic;
using System.Text;

namespace T06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>
                (Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                );

            while (true)
            {
                if (songs.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }

                string[] commands = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string cmdArgs = commands[0];
                StringBuilder sb = new StringBuilder();

                if (cmdArgs == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
                else if (cmdArgs == "Add")
                {
                    for (int i = 1; i < commands.Length; i++)
                    {
                        sb.Append(commands[i]);
                        if (i < commands.Length - 1)
                        {
                            sb.Append(' ');
                        }
                    }
                    string currentSong = sb.ToString();

                    if (songs.Contains(currentSong))
                    {
                        Console.WriteLine($"{currentSong} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(currentSong);
                    }
                }
                else if (cmdArgs == "Play")
                {
                    songs.Dequeue();
                }
            }
        }
    }
}
