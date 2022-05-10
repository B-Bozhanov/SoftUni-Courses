using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var listOfPersons = new List<Person>();

            Console.WriteLine("Max Persons in House - 5");
            Console.WriteLine("Enter person name /space/ person age!");

            while (true)
            {
                if (listOfPersons.Count >= 5)
                {
                    break;
                }
                var personInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var personName = personInfo[0];
                var personAge = int.Parse(personInfo[1]);
                var currentPerson = new Person();
                currentPerson.Name = personName;
                currentPerson.Age = personAge;

                listOfPersons.Add(currentPerson);

            }

            foreach (var person in listOfPersons)
            {
                Console.Write($"{person.Name} --> {person.Age}");
                Console.WriteLine();
            }
        }
    }
}
