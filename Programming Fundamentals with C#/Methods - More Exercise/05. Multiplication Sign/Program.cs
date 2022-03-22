using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = int.Parse(Console.ReadLine());
            int secondnumber = int.Parse(Console.ReadLine());
            int thirdnumber = int.Parse(Console.ReadLine());
            string result = string.Empty;
            result = GetMultuplyingFrom3Nums(firstnumber, secondnumber, thirdnumber);

            Console.WriteLine(result);
        }

        private static string GetMultuplyingFrom3Nums(int firstnumber, int secondnumber, int thirdnumber)
        {
            string result = string.Empty;
            if ((firstnumber > 0 && secondnumber > 0 && thirdnumber > 0)
                || firstnumber < 0 && secondnumber < 0 && thirdnumber > 0
                || firstnumber < 0 && thirdnumber < 0 && secondnumber > 0
                || thirdnumber < 0 && secondnumber < 0 && firstnumber > 0)
            {
                result = "positive";
                return result;
            }
            else if (firstnumber == 0 || secondnumber == 0 || thirdnumber == 0)
            {
                result = "zero";
                return result;
            }
            else
            {
                result = "negative";
                return result;
            }
        }     
    }
}
