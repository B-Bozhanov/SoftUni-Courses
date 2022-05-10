using System;

namespace T05.DateModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            var date1 = Console.ReadLine();
            var date2 = Console.ReadLine();
            var result = DateModifier.DateDiference(date1, date2);
            Console.WriteLine(result);
        }
    }
}
