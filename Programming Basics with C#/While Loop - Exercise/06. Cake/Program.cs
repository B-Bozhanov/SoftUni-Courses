using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widh = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int volume = widh * length;
                        
            string command = Console.ReadLine();
            while (command != "STOP")
            {
                int pieces = int.Parse(command);
                volume -= pieces;

                if (volume <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(volume)} pieces more.");
                    return;
                }               
                command = Console.ReadLine();
            }
            Console.WriteLine($"{volume} pieces are left.");
        }
    }
}
