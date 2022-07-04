using System;
using System.Collections.Generic;
namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new StackOfStrings();
            var test = new Stack<string>();
            stack.Push("z");
            stack.Push("w");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            test.Push("a");
            test.Push("b");
            test.Push("c");
            test.Push("d");
            Console.WriteLine(stack.IsEmpty());
            stack.AddRange(test);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
