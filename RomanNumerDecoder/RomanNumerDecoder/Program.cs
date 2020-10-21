using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerDecoder
{
    class Program
    {
        public static Dictionary<char, int> RomanNumber = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        public static Dictionary<string, int> RomanNumberStr = new Dictionary<string, int>
        {
            { "IV", 4 },
            { "IX", 9 },
            { "XL", 40 },
            { "XC", 90 },
            { "CD", 400 },
            { "CM", 900 },
        };

        public static int Solution(string roman)
        {
            int result = 0;

            foreach(KeyValuePair<string, int> keyValue in RomanNumberStr)
            {
                if (roman.IndexOf(keyValue.Key) != -1)
                {
                    result += keyValue.Value;
                    roman = roman.Replace(keyValue.Key, "");
                }
            }

            return roman.Select(c => RomanNumber[c]).Sum() + result;
        }

        static void Main(string[] args)
        {
            string test = "MCMLIV";

            Console.WriteLine(Solution(test));
            Console.ReadKey();
        }
    }
}
