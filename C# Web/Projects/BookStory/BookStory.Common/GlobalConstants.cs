using System.Reflection.Metadata;
using System.Text;

namespace BookStory.Common
{
    public class GlobalConstants
    {
        public const int VerificationTimeMinutes = 5;

        public const string SaltTeaxt = "You can not broke my password"; //TODO: fix salt generator

        public static bool IsValidPassword(string password)
        {
            //TODO: Encode password from guid to string.

            if (password.Any(c => Char.IsDigit(c)
                && password.Any(c => Char.IsUpper(c))
                && password.Any(c => Char.IsLower(c))
                && password.Length > 6))
            {
                return true;
            }

            return false;
        }
    }
}