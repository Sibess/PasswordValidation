using System;
using System.Text.RegularExpressions;

namespace PasswordValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePassword("P1zz@"));
        }

        public static bool ValidatePassword(string password)
        {
            Regex hasMiniMaxChars = new Regex(@".{6,26}");
            Regex hasUpperChar = new Regex(@"[A-Z]+");
            Regex hasLowerChar = new Regex(@"[a-z]+");
            Regex hasNumber = new Regex(@"[0-9]+");
            Regex hasSymbols = new Regex(@"[!@#$%^&*()+=_-{}[\]:;""'?<>,.]");
            Regex hasRepeatedChar = new Regex(@"^(?!.*(.).*\1.*\1).*");
            bool isValidated = hasMiniMaxChars.IsMatch(password) && hasUpperChar.IsMatch(password) && hasLowerChar.IsMatch(password) && hasNumber.IsMatch(password) && hasSymbols.IsMatch(password) && hasRepeatedChar.IsMatch(password);
            return isValidated;
        }
    }
}
