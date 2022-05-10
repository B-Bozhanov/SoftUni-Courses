using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var person = Console.ReadLine().Split(' ');
                var name = person[0];
                var age = int.Parse(person[1]);

                family.AddMember(name, age);
            }

            var oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
