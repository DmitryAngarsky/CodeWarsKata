using System;
using System.Linq;

namespace BreakСamelCase
{
    class Program
    {
        public static string BreakCamelCase(string str)
        {
            return string.Concat(str.Select(c => char.IsUpper(c) ? " " + c : $"{c}"));
        }

        static void Main(string[] args)
        {
            string test = "camelCasing";

            Console.WriteLine(BreakCamelCase(test));
            Console.ReadKey();
        }
    }
}
