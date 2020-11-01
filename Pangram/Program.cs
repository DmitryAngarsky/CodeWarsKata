using System;
using System.Linq;

namespace Pangram
{
    class Program
    {
        // public static bool IsPangram(string str) =>
        //     str.ToLower()
        //         .Where(Char.IsLetter)
        //         .Distinct()
        //         .Count() == 26;

        private static bool IsPangram(string str)
        {
            return !Enumerable.Range(1, 26).Except(str.ToLower()
                .Where(char.IsLetter)
                .Select(c => c - 96))
                .Any();
        }
        
        static void Main(string[] args)
        {
            const string test = "The quick brown fox jumps over the lazy dog.";
            
            Console.WriteLine(IsPangram(test));
            Console.ReadKey();
        }
    }
}