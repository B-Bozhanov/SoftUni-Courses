using System;

namespace _08._Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double middle = Math.Ceiling(n / 2);

            for (int rows = 1; rows <= n; rows++)
            {
                for (int i = 1; i <= n * 2 * 2; i++)
                {
                    if (rows == 1 || rows == n)
                    {
                        Console.Write($"*");
                    }
                    else
                    {
                        if (i == 1 || i == n * 4 / 2 || i == n * 4 / 2 + 1 || i == n * 4)
                        {
                            Console.Write($"*");
                        }
                        else
                        {
                            Console.Write($"/");
                        }                       
                    }
                    
                    if (i == n * 4 / 2)
                    {
                        for (int distance = 0; distance < n; distance++)
                        {
                            if (rows == middle)
                            {
                                Console.Write($"|");
                            }
                            else
                            {
                                Console.Write($" ");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
