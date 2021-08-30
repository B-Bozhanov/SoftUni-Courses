using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hhTest = int.Parse(Console.ReadLine());
            int mmTest = int.Parse(Console.ReadLine());
            int hhArrive = int.Parse(Console.ReadLine());
            int mmArrive = int.Parse(Console.ReadLine());

            mmTest += hhTest * 60;
            mmArrive += hhArrive * 60;

            //late
            if (mmArrive > mmTest)
            {
                int diff = mmArrive - mmTest;
                Console.WriteLine("Late");
                if (diff >= 60)
                {
                    int h = diff / 60;
                    int mm = diff % 60;

                    Console.WriteLine($"{h}:{mm:d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{mmArrive - mmTest} minutes after the start");
                }

            }
            //Early
            else if (mmArrive < mmTest - 30)
            {
                int diff = mmTest - mmArrive;
                Console.WriteLine("Early");
                if (diff >= 60)
                {
                    int h = diff / 60;
                    int mm = diff % 60;

                    Console.WriteLine($"{h}:{mm:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{mmTest - mmArrive} minutes before the start");
                }
            }
            //On time
            else
            {
                int mm = mmTest - mmArrive;
                if (mmTest == mmArrive)
                {       
                    Console.WriteLine("On time");                                                                                 
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{mm} minutes before the start");
                }
            }
        }
    }
}
