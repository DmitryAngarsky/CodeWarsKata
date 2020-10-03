using System;
using System.Linq;

namespace BinaryToTextASCII
{
    class Program
    {
        public static string BinaryToString(string binary)
        {
            // return
            //     Encoding.ASCII.GetString(
            //         Enumerable.Range(0, binary.Length/8).Select(i => Convert.ToByte(binary.Substring(8*i, 8), 2)).ToArray());
            // return string.Concat(Regex.Matches(binary, ".{8}").Select(m => (char) Convert.ToByte(m.Value, 2)));
            
            return string.IsNullOrEmpty(binary) ? "" : 
            string.Concat(
            Enumerable.Range(0, binary.Length)
                .Where(w => w % 8 == 0)
                .Select(s => (char)Convert
                    .ToInt32(binary[s..(s + 8)], 2)));
        }
        
        static void Main(string[] args)
        {
            string test = "0100100001100101011011000110110001101111";
            Console.WriteLine(BinaryToString(test));
            Console.ReadKey();
        }
    }
}