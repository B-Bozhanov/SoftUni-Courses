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
                (
                 Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                );

            string commands = Console.ReadLine();
            while (songs.Count != 0)
            {
                string[] cmdArgs = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command == "Add")
                {
                    string currentSong = commands.Substring(command.Length + 1);

                    if (!songs.Contains(currentSong))
                    {
                        songs.Enqueue(currentSong);
                        commands = Console.ReadLine();
                        continue;
                    }
                    Console.WriteLine($"{currentSong} is already contained!");
                }
                else if (command == "Show")
                {
                    Console.WriteLine(String.Join(", ", songs));
                }
                
                commands = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
