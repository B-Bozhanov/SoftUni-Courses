using System;

namespace T11Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int charNum = 0;
            //int curentPoints = 0;
            int maxPoints = 0;
            string winnerName = " ";

            //int name3 = total - name1 - name2;

            while (name != "Stop")
            {
                int curentPoints = 0;

                for (int n = 0; n < name.Length; n++)
                {
                    charNum = (int)name[n];
                    int num = int.Parse(Console.ReadLine());

                    if (num == charNum)
                    {
                        curentPoints += 10;
                    }
                    else
                    {
                        curentPoints += 2;
                    }
                }
                if (curentPoints >= maxPoints)
                {
                    maxPoints = curentPoints;
                    winnerName = name;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"The winner is {winnerName} with {maxPoints} points!");

        }
    }
}
