using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treated = 0;
            int unTreated = 0;
            //int count = 1;

            for (int i = 1; i <= period; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && unTreated > treated)
                {
                    doctors++;
                    //count = 0;
                }
                if (patients >= doctors)
                {
                    treated += doctors;
                    unTreated += patients - doctors;
                }
                else if (patients < doctors)
                {
                    treated += patients;
                }
               // count++;
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {unTreated}.");
        }
    }
}
