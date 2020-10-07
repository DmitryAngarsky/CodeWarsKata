using System;
using System.Linq;

namespace Base64Encoding
{
    class Program
    {
        static readonly string base64Table = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
        public static string ToBase64(string s)
        {
            var append = s.Length % 3 == 1 ? "==" : s.Length % 3 == 2 ? "=" : "";

            var allBytes = string.Join("", s.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
            var newList = Enumerable.Range(0, allBytes.Length / 6).Select(x => allBytes.Substring(x * 6, 6)).ToList();

            if (allBytes.Length % 6 != 0)
            {
                newList.Add(allBytes.Substring(allBytes.Length / 6 * 6, allBytes.Length % 6).PadRight(6, '0'));
            }

            return (string.Join("", newList.Select(x => base64Table[Convert.ToByte(x, 2)])) + append);
        }

        public static string FromBase64(string s)
        {
            var allBytes = string.Join("", s.Where(x => x != '=').Select(x => Convert.ToString(base64Table.IndexOf(x), 2).PadLeft(6, '0')));

            var countOfBytes = allBytes.Count();

            return string.Join("", Enumerable.Range(0, countOfBytes / 8).Select(x => (char)Convert.ToInt32(allBytes.Substring(x * 8, 8), 2)));
        }

        static void Main(string[] args)
        {
            string test = "t";
            string test1 = "dGhpcyBpcyBhIHN0cmluZyEh";

            Console.WriteLine(ToBase64(test));
            Console.WriteLine(FromBase64(test1));
            Console.ReadKey();
        }
    }
}
