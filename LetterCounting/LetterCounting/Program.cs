using System;
using System.Linq;

namespace LetterCounting
{
    class Program
    {
        // Best solution
        //public static string StringLetterCount(string str)
        //    => string.Concat(
        //        str
        //          .Where(char.IsLetter)
        //          .GroupBy(char.ToLowerInvariant)
        //          .OrderBy(g => g.Key)
        //          .Select(g => $"{g.Count()}{g.Key}"));

        public static string StringLetterCount(string str)
        {
            string lowerStr = str.Replace(" ", "").ToLower();
            return string.Concat(
                lowerStr
                .Where(ch => char.IsLetter(ch))
                .Select(c => $"{lowerStr.Count(s => s == c)}" + c)
                .Distinct()
                .OrderBy(x => x[1])
            );
        }

        static void Main(string[] args)
        {
            string test = "This is a test sentence.";

            Console.WriteLine(StringLetterCount(test));
            Console.ReadKey();
        }
    }
}
