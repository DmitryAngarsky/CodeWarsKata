using System;
using System.Linq;

namespace TwoToOne
{
    class Program
    {
        public static string Longest(string s1, string s2)
        {
            //return string.Concat(string.Concat(s1, s2).Distinct().OrderBy(x => x));
            return string.Concat((s1 + s2).Distinct().OrderBy(x => x));
        }

        static void Main(string[] args)
        {
            string str1 = "xyaabbbccccdefww";
            string str2 = "xxxxyyyyabklmopq";

            Console.WriteLine(Longest(str1, str2));
            Console.ReadKey();
        }
    }
}
