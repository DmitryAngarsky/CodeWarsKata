using System;
using System.Linq;

namespace SixCipher
{
    class Program
    {
        // public static string Encode(string s) => Cipher(s, i => i * 6);
        // public static string Decode(string s) => Cipher(s, i => i / 6);
        // private static string Cipher(string s, Func<int, int> f) => String.Concat(s.Select(c => (char)f(c)));
        
        private static string Encode(string str)
        {
            return string.Concat(str.Select(c => (char)(c * 6)));
        }

        private static string Decode(string str)
        {
            return string.Concat(str.Select(c => (char)(c / 6)));
        }
        
        static void Main(string[] args)
        {
            string test = "Hello World!";
            string test1 = "ưɞʈʈʚÀȊʚʬʈɘÆ";
            
            Console.WriteLine(Encode(test));
            Console.WriteLine(Decode(test1));
            Console.ReadKey();
        }
    }
}