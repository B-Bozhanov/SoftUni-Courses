using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grade = 0;
            double poorGrade = 0;

            for (int i = 1; i <= 12; i++)
            {
                double curentGrade = double.Parse(Console.ReadLine());
                grade += curentGrade;
                if (curentGrade >= 4.00)
                {
                    continue;
                }
                else 
                {
                    poorGrade += curentGrade;
                }
                if (poorGrade >= 4)
                {
                    Console.WriteLine($"{name} has been excluded at {i - 1} grade");
                    return;
                }

            }
            double averageGrade = grade / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
