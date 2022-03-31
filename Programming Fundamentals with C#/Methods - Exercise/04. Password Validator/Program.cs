using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            //It should contain 6 – 10 characters(inclusive)
            //It should contain only of letters and digits
            //It should contain at least 2 digits

            string password = Console.ReadLine();
            bool IsCorect = false;
            int count = 0;

            IsCorect = CheckLength(password);
            count = IsTrue(IsCorect, count);
            IsCorect = CheckLettersAndDigits(password);
            count = IsTrue(IsCorect, count);
            IsCorect = CheckDigits(password);
            count = IsTrue(IsCorect, count);
            if (count == 3)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static int IsTrue(bool IsCorect, int count)
        {
            if (IsCorect)
            {
                count++;
            }

            return count;
        }

        static bool CheckDigits(string password)
        {
            bool IsHaveLeastTwoDigits = false;
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                IsHaveLeastTwoDigits = true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                IsHaveLeastTwoDigits = false;
                return IsHaveLeastTwoDigits;
            }
            return IsHaveLeastTwoDigits;
        }

        static bool CheckLettersAndDigits(string password)
        {
            bool IsHaveLettersAndDigits = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57
                    || password[i] >= 65 && password[i] <= 90
                    || password[i] >= 97 && password[i] <= 122)
                {
                    IsHaveLettersAndDigits = true;
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    IsHaveLettersAndDigits = false;
                    return IsHaveLettersAndDigits;
                }
            }
            return IsHaveLettersAndDigits;
        }

        static bool CheckLength(string password)
        {
            bool IsInRange = false;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                IsInRange = false;
                return IsInRange;
            }
            else
            {
                IsInRange = true;
            }
            return IsInRange;
        }
    }
}
