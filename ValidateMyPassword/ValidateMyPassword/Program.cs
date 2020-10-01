using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidateMyPassword
{
    class Program
    {
        public static string validator(string password)
        {
            //return Regex.IsMatch(password, @"^(?=.*\d)(?=.*[a-zA-Z])(\w{4,20})$") ? "VALID" : "INVALID";
            return password.All(char.IsLetterOrDigit)
                && password.Any(char.IsDigit)
                && password.Any(char.IsLetter)
                && password.Length > 3
                && password.Length < 20
                ? "VALID" : "INVALID";
        }

        static void Main(string[] args)
        {
            string test1 = "Username123";
            string test2 = "Username";
            string test3 = "123";
            string test4 = "Username123!";
            string test5 = "ThisPasswordIsTooLong1234";

            Console.WriteLine(validator(test1));
            Console.WriteLine(validator(test2));
            Console.WriteLine(validator(test3));
            Console.WriteLine(validator(test4));
            Console.WriteLine(validator(test5));
            Console.ReadKey();
        }
    }
}
