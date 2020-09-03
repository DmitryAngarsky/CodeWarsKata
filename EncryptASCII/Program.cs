using System;
using System.Text;
using System.Linq;

namespace EncryptASCII
{
    
    class Program
    {
        public static string EncryptWord(string word)
        {
            string GetASCII(string str)
            {
                return string.Concat(Encoding.ASCII.GetBytes(str.ToCharArray(), 0, 1));
            }

            switch (word.Count())
            {
                case 0:
                    return "";
                case 1:
                    return GetASCII(word);
                case 2:
                    return GetASCII(word) + word.Last();
                case 3:
                    return GetASCII(word) + string.Concat(word.Substring(1).Reverse());
                default:
                    return GetASCII(word) + word[word.Length - 1] + string.Concat(word.Skip(2).Take(word.Length - 3)) + word[1];
            }
        }

        private static string Encrypt(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            else if (s.Length == 1) return $"{(int)s[0]}";
            else if (s.Length == 2) return $"{(int)s[0]}{s[1]}";
            return $"{(int)s[0]}{s.Last()}{s.Substring(2, s.Length - 3)}{s[1]}";
        }

        public static string EncryptThis(string input)
        {
            return string.Join(" ", input.Split(' ').Select(Encrypt));
        }

        static void Main(string[] args)
        {
            string test1 = "A wise old owl lived in an oak";

            Console.WriteLine(EncryptThis(test1));
            Console.ReadKey();
        }
    }
}
