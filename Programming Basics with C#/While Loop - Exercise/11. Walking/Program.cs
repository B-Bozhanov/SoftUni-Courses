using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputSteps = 10000;           
            string command = Console.ReadLine();
            int currentSteps = 0;

            while (command != "Going home")
            {
                int steps = int.Parse(command);
                currentSteps += steps;
                if (currentSteps >= inputSteps)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{currentSteps - inputSteps} steps over the goal!");
                    return;
                }
                command = Console.ReadLine();
            }
            int lastSteps = int.Parse(Console.ReadLine());
            currentSteps += lastSteps;
            if (currentSteps < inputSteps)
            {
                Console.WriteLine($"{inputSteps - currentSteps} more steps to reach goal.");
            }
            else if (currentSteps >= inputSteps)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{Math.Abs(inputSteps - currentSteps)} steps over the goal!");
            }
        }
    }
}
