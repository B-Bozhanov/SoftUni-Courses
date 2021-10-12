using System;

namespace T06Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Име на града -текст с възможности("Bansko", "Borovets", "Varna" или "Burgas")
            //2.Вид на пакета -текст с възможности("noEquipment", "withEquipment", "noBreakfast" или "withBreakfast")
            //3.Притежание на VIP отстъпка - текст с възможности "yes" или "no"
            //4.Дни за престой -цяло число в интервала[1 … 10000]

            string city = Console.ReadLine();
            string packаgeType = Console.ReadLine();
            string VIP = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());
            
            double pricePerDay = 0;

            if ((city == "Bansko") || (city == "Borovets"))
            {
                switch (packаgeType)
                {
                    case "noEquipment":
                        pricePerDay = 80;
                        if (VIP == "yes")
                        {
                            pricePerDay *= 0.95;
                        }
                        break;
                    case "withEquipment":
                        pricePerDay = 100;
                        if (VIP == "yes")
                        {
                            pricePerDay *= 0.90;
                        }
                        break;
                }
            }
            else if ((city == "Varna") || (city == "Burgas"))
            {
                switch (packаgeType)
                {
                    case "noBreakfast":
                        pricePerDay = 100;
                        if (VIP == "yes")
                        {
                            pricePerDay *= 0.93;
                        }
                        break;
                    case "withBreakfast":
                        pricePerDay = 130;
                        if (VIP == "yes")
                        {
                            pricePerDay *= 0.88;
                        }
                        break;
                }
            }
            double totalPrice = pricePerDay * days;
            if (days > 7)
            {
                totalPrice = pricePerDay * (days - 1);
            }
            else if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            if (((city == "Bansko") || (city == "Borovets")) && ((packаgeType == "noEquipment") || (packаgeType == "withEquipment")))
            {
                Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
            }
            else if (((city == "Varna") || (city == "Burgas")) && ((packаgeType == "noBreakfast") || (packаgeType == "withBreakfast")))
            {
                Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }

    }
}

