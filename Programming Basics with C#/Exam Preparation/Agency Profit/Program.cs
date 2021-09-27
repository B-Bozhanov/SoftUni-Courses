using System;

namespace _01._Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string aircompany = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidsTickets = int.Parse(Console.ReadLine());
            double NetTicketPriceForAnAdult = double.Parse(Console.ReadLine());
            double serviceFee = double.Parse(Console.ReadLine());

            //Solution:

            double adultTicketsPrice = adultTickets * (serviceFee + NetTicketPriceForAnAdult);
            double kidsTicketPrice = (NetTicketPriceForAnAdult * 0.30 + serviceFee) * kidsTickets;
            double totalPriceWithFee = (adultTicketsPrice + kidsTicketPrice);
            double profit = totalPriceWithFee * 0.20;

            Console.WriteLine($"The profit of your agency from {aircompany} tickets is {profit:f2} lv.");

        }
    }
}
