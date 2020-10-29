using System;
using System.Linq;

namespace AlphabetPosition
{
    class Program
    {
        public static string AlphabetPosition(string text)
        {
            //.Select(c => "abcdefghijklmnopqrstuvwxyz".IndexOf(c) + 1)
            //return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(c => c - 96));
        }

        static void Main(string[] args)
        {
            string test = "The sunset sets at twelve o' clock.";

            Console.WriteLine(AlphabetPosition(test));
            Console.ReadKey();
        }
    }
}
