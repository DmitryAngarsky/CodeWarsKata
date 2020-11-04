using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidatePIN
{
    class Program
    {
        public static bool ValidatePin(string pin)
        {
            return (pin.Length == 4
                   || pin.Length == 6)
                   && pin.All(char.IsDigit);
        }
        
        static void Main(string[] args)
        {
            string test = "a234";
            
            Console.WriteLine(ValidatePin(test));
            Console.ReadKey();
        }
    }
}