using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
                var Person1 = new Person();
                var Person2 = new Person(2);
                var Person3 = new Person("Boazhan", 33);

            Console.WriteLine(Person3.Age);

        }
    }
}
