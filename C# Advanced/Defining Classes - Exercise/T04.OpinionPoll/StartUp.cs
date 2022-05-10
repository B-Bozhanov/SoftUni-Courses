using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var personInfo = Console.ReadLine().Split(' ');
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);

                persons.Add(new Person(name, age));
            }

            var result = persons.Where(x => x.Age > 30);

            foreach (var person in result.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
