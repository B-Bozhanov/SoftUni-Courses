using System;

namespace _08._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupNum = int.Parse(Console.ReadLine());
            double Musala = 0;
            double Monblan = 0;
            double Kilimandjaro = 0;
            double K2 = 0;
            double Everest = 0;
            double totalPeoples = 0;

            for (int i = 1; i <= groupNum; i++)
            {
                int mans = int.Parse(Console.ReadLine());
                totalPeoples += mans;
                if (mans <=5)
                {
                    Musala += mans;
                }
                else if (mans <= 12)
                {
                    Monblan += mans;
                }
                else if (mans <= 25)
                {
                    Kilimandjaro += mans;
                }
                else if (mans <= 40)
                {
                    K2 += mans;
                }
                else if (mans >= 41)
                {
                    Everest += mans;
                }
            }
            Console.WriteLine($"{Musala / totalPeoples*100:f2}%");
            Console.WriteLine($"{Monblan / totalPeoples * 100:f2}%");
            Console.WriteLine($"{Kilimandjaro / totalPeoples * 100:f2}%");
            Console.WriteLine($"{K2 / totalPeoples * 100:f2}%");
            Console.WriteLine($"{Everest / totalPeoples * 100:f2}%");
        }
    }
}
