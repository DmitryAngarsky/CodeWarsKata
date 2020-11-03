using System;
using System.Linq;

namespace Mumbling
{
    class Program
    {
        public static string Accum(string s)
        {
            //return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
            return string.Join("-", s.Select((c, i) => char.ToUpper(c).ToString() + string.Concat(Enumerable.Repeat(char.ToLower(c), i)))); ;
        }

        static void Main(string[] args)
        {
            string test = "abcd";

            Console.WriteLine(Accum(test));
            Console.ReadKey();
        }
    }
}
