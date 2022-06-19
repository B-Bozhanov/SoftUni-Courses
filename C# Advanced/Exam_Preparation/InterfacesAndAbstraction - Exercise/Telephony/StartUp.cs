using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine().Split(' ');
            var webSites = Console.ReadLine().Split(' ');

            ISmartphone smartPhone = new Smartphone();
            IStationaryPhone stationaryPhone = new StationaryPhone();

            foreach (var number in phoneNumbers)
            {
                if (number.Any(x => !Char.IsDigit(x)))
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
                if (number.Length == 10)
                {
                    smartPhone.Calling(number);
                }
                else if (number.Length == 7)
                {
                    stationaryPhone.Dialing(number);
                }
            }

            foreach (var site in webSites)
            {
                if (site.Any(x => Char.IsDigit(x)))
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }

                smartPhone.Browsing(site);
            }
        }
    }
}
