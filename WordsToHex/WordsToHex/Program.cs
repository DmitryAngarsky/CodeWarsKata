using System;
using System.Linq;

namespace WordsToHex
{
    class Program
    {
        public static string[] WordsToHex(string words)
        {
            string ToHex(string str) => "#" + string.Join("", str.Take(3).Select(c => Convert.ToString(c, 16))).PadRight(6, '0');
            return words
                .Split(" ")
                .Select(w => ToHex(w))
                .ToArray();
        }

        static void Main(string[] args)
        {
            string test = "Hello, my name is Gary and I like cheese.";

            Console.WriteLine(WordsToHex(test));
            Console.ReadKey();
        }
    }
}
