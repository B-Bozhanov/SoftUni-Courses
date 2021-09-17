using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double standardTicket = 0;
            double kidTicket = 0;
            double studentTicket = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                double counter = 0;
                string muvie = Console.ReadLine();
                if (muvie == "Finish")
                {
                    break;
                }
                int emptySpace = int.Parse(Console.ReadLine());

                for (int j = 0; j < emptySpace; j++)
                {
                    string command = Console.ReadLine();
                    if (command == "End")
                    {
                        break;
                    }
                    counter++;
                    switch (command)
                    {
                        case "standard":
                            standardTicket++; break;
                        case "kid":
                            kidTicket++; break;
                        case "student":
                            studentTicket++; break;
                    }
                    
                }
                Console.WriteLine($"{muvie} - {counter / emptySpace * 100:f2}% full.");
            }
            double totalTickets = standardTicket + kidTicket + studentTicket;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTicket / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standardTicket / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidTicket / totalTickets * 100:f2}% kids tickets.");

            //string muvie = Console.ReadLine();
            //double standardTicket = 0;
            //double kidTicket = 0;
            //double studentTicket = 0;


            //while (muvie != "Finish")
            //{
            //    int emptySpace = int.Parse(Console.ReadLine());
            //    double counter = 0;
            //    int count = emptySpace;
            //    string command = Console.ReadLine();
            //    while (command != "End")
            //    {
            //        switch (command)
            //        {
            //            case "standard":
            //                standardTicket++; break;
            //            case "kid":
            //                kidTicket++; break;
            //            case "student":
            //                studentTicket++; break;
            //        }
            //        counter++;
            //        count--;
            //        if (count <= 0)
            //        {
            //            break;
            //        }
            //        command = Console.ReadLine();
            //    }
            //    Console.WriteLine($"{muvie} - {counter / emptySpace * 100:f2}% full.");

            //    muvie = Console.ReadLine();
            //}
            //double totalTickets = standardTicket + kidTicket + studentTicket;
            //Console.WriteLine($"Total tickets: {totalTickets}");
            //Console.WriteLine($"{studentTicket / totalTickets * 100:f2}% student tickets.");
            //Console.WriteLine($"{standardTicket / totalTickets * 100:f2}% standard tickets.");
            //Console.WriteLine($"{kidTicket / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
