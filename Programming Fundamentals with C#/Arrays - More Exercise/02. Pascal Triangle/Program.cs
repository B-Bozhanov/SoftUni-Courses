using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4

            //1
            //1 1
            //1 2 1
            //1 3 3 1

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[1];
            int[] curentArray = null;

            for (int i = 0; i < n; i++)
            {
                if (i < 1)
                {
                    numbers[i] = 1;
                }
                else if (i < 2)
                {
                    numbers[i] = 1;
                }
                else
                {
                    numbers[0] = 1;
                    numbers[numbers.Length - 1] = 1;

                    for (int j = 0; j < curentArray.Length - 1; j++)
                    {
                        numbers[j + 1] = curentArray[j] + curentArray[j + 1];
                    }

                }
                curentArray = numbers;
                Console.WriteLine($"{string.Join(" ", curentArray)}");
                Array.Resize(ref numbers, numbers.Length + 1);
            }
        }
    }
}
