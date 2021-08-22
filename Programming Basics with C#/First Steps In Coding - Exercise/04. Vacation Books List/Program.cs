using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Брой страници в текущата книга – цяло число в интервала[1…1000]
            //2.Страници, които прочита за 1 час – цяло число в интервала[1…1000]
            //3.Броят на дните, за които трябва да прочете книгата – цяло число в интервала[1…1000]

            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalHours = pages / pagesPerHour;
            int totalDays = totalHours / days;

            Console.WriteLine(totalDays);

        }
    }
}
