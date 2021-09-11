using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int count = 0;
            string curentBook = Console.ReadLine();
            
            while (curentBook != "No More Books")
            {
                count++;
                if (curentBook == searchedBook)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                }


                curentBook = Console.ReadLine();
            }
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {count} books."); 

        }
    }
}
