using System;

namespace _04._Numbers_Divided_by_3_Without_Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            while (count <= 100)
            {
                if (count % 3 == 0)
                {
                    Console.WriteLine(count);
                }
                count++;
            }

        }
    }
}
