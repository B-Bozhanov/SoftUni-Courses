using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double totalAverage = 0;
            int count = 0;

            while (presentation != "Finish")
            {
                int counter = 0;
                double totalGrades = 0;
                for (int i = 0; i < jury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    counter++;
                    totalGrades += grade;
                }
                double average = totalGrades / counter;
                count++;
                totalAverage += average;
                Console.WriteLine($"{presentation} - {average:f2}.");

                presentation = Console.ReadLine();
            }
            double studentAverage = totalAverage / count;
            Console.WriteLine($"Student's final assessment is {studentAverage:f2}.");
        }
    }
}
