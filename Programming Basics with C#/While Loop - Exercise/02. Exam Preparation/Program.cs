using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int unsatisfactionGrades = int.Parse(Console.ReadLine());
            int poorGrade = 0;
            double goodGrades = 0;
            int gradeCount = 0;
            string lastTask = string.Empty;

            string taskName = Console.ReadLine();

            while (taskName != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    poorGrade++;
                    gradeCount++;
                    goodGrades += grade;
                }
                else
                {
                    goodGrades += grade;
                    gradeCount++;
                    lastTask = taskName;
                }
                if (poorGrade == unsatisfactionGrades)
                {
                    Console.WriteLine($"You need a break, {poorGrade} poor grades.");
                    return;
                }

                taskName = Console.ReadLine();
            }
            double averageGrade = goodGrades / gradeCount;

            Console.WriteLine($"Average score: {averageGrade:f2}");
            Console.WriteLine($"Number of problems: {gradeCount}");
            Console.WriteLine($"Last problem: {lastTask}");
        }
    }
}
