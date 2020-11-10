using System;
using System.Linq;

namespace Decipher
{
    class Program
    {
        private static string DecipherThis(string s)
        {
            string ReplaceChar(string str) => str.Length >= 2 
                ? str[^1] + str.Substring(1, str.Length - 2) + str[0]
                : str;

            return string.IsNullOrWhiteSpace(s) 
                ? string.Empty 
                : string.Join(" ", s
                    .Split(" ")
                    .Select(w => $"{(char)int.Parse(string.Concat(w.TakeWhile(char.IsDigit)))}" 
                                            + ReplaceChar(string.Concat(w.SkipWhile(char.IsDigit)))));
        }
        
        static void Main(string[] args)
        {
            string test = " ";
            
            Console.WriteLine(DecipherThis(test));
            Console.ReadKey();
        }
    }
}
