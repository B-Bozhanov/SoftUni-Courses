using System;

namespace Lotary_Billet
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int j = 0;
            int k = 0;
            int l = 0;
            int m = 0;
            int n = 0;

            int count = 0;
            for (int i = 0; i < num; i++)
            {
                for (j = 65; j <= 76; j++)
                {
                    if (j % 2 != 0)
                    {
                        continue;
                    }
                    for (k = 102; k >= 97; k--)
                    {

                        for (l = 65; l <= 67; l++)
                        {
                            for (m = 1; m <= 10; m++)
                            {
                                for (n = 10; n >= 1; n--)
                                {
                                    count++;
                                    if (count == num)
                                    {
                                        Console.WriteLine($"{(char)j}{(char)k}{(char)l}{m}{n} ");
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
