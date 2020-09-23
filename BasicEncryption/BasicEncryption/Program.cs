using System;
using System.Linq;

namespace BasicEncryption
{
    internal static class Program
    {
        //public static string Encrypt(string text, int rule) =>
        //    string.Concat(text.Select(c=>(char) ((c+rule)%256)));
        
        private static string Encrypt(string text, int rule)
        {
            return text.Aggregate("", (a, b) => a + (char)(b + rule & 255));
        }

        private static void Main()
        {
            string test = Encrypt("please encrypt me6", 2);

            Console.WriteLine(test);
            Console.ReadKey();
        }
    }
}
