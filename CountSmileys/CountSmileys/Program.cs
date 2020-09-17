using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CountSmileys
{
    class Program
    {
        public static int CountSmileys(string[] smileys)
        {
            //Regex.IsMatch(s, @"^[:;]{1}[~-]{0,1}[\)D]{1}$")
            // Regex.Matches(string.Join(" ",smileys), "([:;][-~]?)[)D]")
            return smileys.Where(x => Regex.IsMatch(x, @"^[;:][-~]?[D)]$")).Count();
        }

        static void Main(string[] args)
        {
            string[] test = new string[] { ";", ")", ";*", ":$", "8-D" };

            Console.WriteLine(CountSmileys(test));
            Console.ReadKey();
        }
    }
}
