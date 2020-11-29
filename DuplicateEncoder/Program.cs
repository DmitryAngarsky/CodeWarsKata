using System;
using System.Linq;

namespace DuplicateEncoder
{
    class Program
    {
        public static string DuplicateEncode(string word)
        {
            return string.Concat(word.ToLower().Select(c => word.ToLower().Count(i => i == c) > 1 ? ')' : '('));
        }
        
        static void Main(string[] args)
        {
            string test = "Success";
            
            Console.WriteLine(DuplicateEncode(test) == ")())())");
            Console.ReadKey();
        }
    }
}