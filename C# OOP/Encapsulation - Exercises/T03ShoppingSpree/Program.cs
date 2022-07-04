using System;
using System.Collections.Generic;
using System.Linq;

namespace T03ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ';', '=' };
            string[] personInfo = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] productInfo = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            // peter 11 george 13

            for (int i = 0; i < personInfo.Length ; i += 2)
            {
                try
                {
                    Person person = new Person(personInfo[i], decimal.Parse(personInfo[i + 1]));
                    persons.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            for (int i = 0; i < personInfo.Length; i += 2)
            {
                try
                {
                    Product product = new Product(productInfo[i], decimal.Parse(productInfo[i + 1]));
                    products.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
          
            string commands = Console.ReadLine();
            while (commands != "END")
            {
                string[] cmdArgs = commands.Split();
                string personName = cmdArgs[0];
                string productName = cmdArgs[1];

                Person currentPerson = persons.FirstOrDefault(x => x.Name == personName);
                Product currentProduct = products.FirstOrDefault(x => x.Name == productName);

                if (currentPerson.Money >= currentProduct.Cost)
                {
                    currentPerson.Bag.Add(currentProduct.Name);
                    currentPerson.Money -= currentProduct.Cost;
                    Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                }
                else
                {
                    Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                }

                commands = Console.ReadLine();
            }

            foreach (var item in persons)
            {
                if (item.Bag.Count == 0)
                {
                    Console.WriteLine($"{item.Name} Nothing bought");
                }
                else
                {
                    Console.WriteLine(item.PersonInfo);
                }
            }
        }
    }
}
