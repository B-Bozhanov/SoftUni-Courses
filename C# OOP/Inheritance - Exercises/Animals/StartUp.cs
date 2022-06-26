using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();

            string command = Console.ReadLine();
            while (command != "Beast!")
            {
                string[] args = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = args[0];
                int age = int.Parse(args[1]);
                string gender = args[2];

                if (age < 0 || gender != "Male" && gender != "Female")
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }

                switch (command)
                {
                    case "Cat": animals.Add(new Cat(name, age, gender)); break;
                    case "Dog": animals.Add(new Dog(name, age, gender)); break;
                    case "Frog": animals.Add(new Frog(name, age, gender)); break;
                    case "Tomcat": animals.Add(new Tomcat(name, age)); break;
                    case "Kitten": animals.Add(new Kitten(name, age)); break;

                        default:
                        Console.WriteLine("Invalid input!");
                        command = Console.ReadLine();
                        continue;
                }
                command = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal);
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}
