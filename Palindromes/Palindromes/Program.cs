using System;
using System.Linq;

namespace Palindromes
{
    class Program
    {
        public static string solve(string s)
        {
            bool isPolindrom(string str) => str == string.Concat(str.Reverse());

            if (isPolindrom(s))
            {
                return "Ok";
            }
            else
            {
                return s.Select((c, i) => isPolindrom(s.Remove(i, 1))).Contains(true) ? "remove one" : "not possible"; ;
            }
        }

        static void Main(string[] args)
        {
            string test = "madmam";

            Console.WriteLine(solve(test));
            Console.ReadKey();
        }
    }
}
