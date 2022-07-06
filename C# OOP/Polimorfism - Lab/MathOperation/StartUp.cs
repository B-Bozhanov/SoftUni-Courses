using System;

namespace Operations
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            MathOperations operations = new MathOperations();
            Console.WriteLine(operations.Add(2, 2));
            Console.WriteLine(operations.Add(2.4, 2.6, 3.5));
            Console.WriteLine(operations.Add(2.4m, 2.6m, 3.5m));
        }
    }
}
