using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesInfo = new Dictionary<string, List<string>>();

            string currCourse = Console.ReadLine();
            while (currCourse != "end")
            {
                string[] courseArgs = currCourse
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string courseName = courseArgs[0];
                string studentName = courseArgs[1];

                if (!coursesInfo.ContainsKey(courseName))
                {
                    coursesInfo.Add(courseName, new List<string>());
                }
                coursesInfo[courseName].Add(studentName);

                currCourse = Console.ReadLine();
            }

            foreach (var courses in coursesInfo)
            {
                Console.Write($"{courses.Key}: {courses.Value.Count}");
                Console.WriteLine();
                foreach (var student in courses.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
