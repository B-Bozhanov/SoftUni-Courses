using System;

namespace _03._Cat_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string cats = Console.ReadLine();
            string gender = Console.ReadLine();
            double totalMounts = 0;
            switch (cats)
            {
                case "British Shorthair":
                    if (gender == "m")
                    {
                        totalMounts = (13 * 12) / 6;
                    }
                    else
                    {
                        totalMounts = (14 * 12) / 6;
                    }
                    break;
                case "Siamese":
                    if (gender == "m")
                    {
                        totalMounts = (15 * 12) / 6;
                    }
                    else
                    {
                        totalMounts = (16 * 12) / 6;
                    }
                    break;
                case "Persian":
                    if (gender == "m")
                    {
                        totalMounts = (14 * 12) / 6;
                    }
                    else
                    {
                        totalMounts = (15 * 12) / 6;
                    }
                    break;
                case "Ragdoll":
                    if (gender == "m")
                    {
                        totalMounts = (16 * 12) / 6;
                    }
                    else
                    {
                        totalMounts = (17 * 12) / 6;
                    }
                    break;
                case "American Shorthair":
                    if (gender == "m")
                    {
                        totalMounts = (12 * 12) / 6;
                    }
                    else
                    {
                        totalMounts = (13 * 12) / 6;
                    }
                    break;
                case "Siberian":
                    if (gender == "m")
                    {
                        totalMounts = (11 * 12) / 6;
                    }
                    else
                    {
                        totalMounts = (12 * 12) / 6;
                    }
                    break;
                default:
                    Console.WriteLine($"{cats} is invalid cat!");
                    return;
            }
            Console.WriteLine($"{Math.Floor(totalMounts)} cat months");
        }
    }
}
