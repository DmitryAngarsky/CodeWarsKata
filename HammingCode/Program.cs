using System;
using System.Text;
using System.Linq;

namespace HammingCode
{
    internal static class Program
    {
        // Best solution
        // public static string encode(string text)
        // {
        //     return string.Concat(
        //         string.Concat(
        //             text.Select(s => Convert.ToString(s, 2).PadLeft(8, '0')))
        //             .Select(s => s == '1' ? "111" : "000"));
        // }
        //
        // public static string decode(string bits)
        // {
        //     string text = string.Concat(
        //         Enumerable.Range(0, bits.Length)
        //             .Where(w => w % 3 == 0)
        //             .Select(s => bits[s..(s + 3)]
        //                 .Count(c => c == '1') > 1 ? '1' : '0'));
        //     
        //     return string.Concat(
        //         Enumerable.Range(0, text.Length)
        //             .Where(w => w % 8 == 0)
        //             .Select(s => (char)Convert
        //                 .ToInt32(text[s..(s + 8)], 2)));
        // }
        
        private static string Encode(string text)
        {
            return string.Concat(
                Encoding.ASCII
                    .GetBytes(text)
                    .SelectMany(b => 
                        Convert.ToString(b, 2).PadLeft(8, '0')
                            .Select(c => String.Concat(Enumerable.Repeat(c, 3))))
            );
        }

        private static string Decode(string bits)
        {
            var temp = string.Concat(
                Enumerable.Range(0, bits.Length / 3)
                    .Select(i => string.Concat(
                        bits.Substring(i * 3, 3)
                            .OrderBy(b => b)
                            .ElementAt(1)))
                );
            
            string result = Encoding.ASCII.GetString(
                Enumerable
                    .Range(0, temp.Length / 8)
                    .Select(i => Convert.ToByte(temp.Substring(i * 8, 8), 2))
                    .ToArray());
            
            return result;   
        }
        
        static void Main(string[] args)
        {
            const string encodeString = "hey";
            const string decodeString = "100111111000111001000010000111111000000111001111000111110110111000010111";
            
            Console.WriteLine(Encode(encodeString));
            Console.WriteLine(Decode(decodeString));
            Console.ReadKey();
        }
    }
}