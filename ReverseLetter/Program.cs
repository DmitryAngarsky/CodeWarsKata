using System;
using System.Linq;

namespace ReverseLetter
{
    class Program
    {
        public static string ReverseLetter(string str)
        {
            //My solution
            //return string.Concat(Regex.Replace(str, "[^a-zA-Z]", string.Empty).Reverse());
            return string.Concat(str.Where(char.IsLetter).Reverse());
        }

        static void Main(string[] args)
        {
            string test = "ultr53o?n";

            Console.WriteLine(ReverseLetter(test));
            Console.ReadKey();
        }
    }
}
