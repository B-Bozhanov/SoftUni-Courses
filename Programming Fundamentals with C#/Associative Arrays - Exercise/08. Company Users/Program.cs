using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyes = new Dictionary<string, List<string>>();

            string currCompany = Console.ReadLine();
            while (currCompany != "End")
            {
                string[] companyArgs = currCompany
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string company = companyArgs[0];
                string employeeId = companyArgs[1];

                if (!companyes.ContainsKey(company))
                {
                    companyes.Add(company, new List<string>());
                }
                if (!companyes[company].Contains(employeeId))
                {
                    companyes[company].Add(employeeId);
                }

                currCompany = Console.ReadLine();
            }

            foreach (var courses in companyes)
            {
                Console.WriteLine($"{courses.Key}");

                foreach (var student in courses.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
