using System;
using System.Linq;

namespace WeirdIPv6
{
    static class Program
    {
        private static string ParseIPv6(string iPv6)
        {
            return string.Concat(
                Enumerable
                    .Range(0, iPv6.Length)
                    .Where(n => n % 5 == 0)
                    .Select(s => iPv6[s..(s + 4)])
                    .Select(b => b.Select(c => (int)Convert
                        .ToByte(c.ToString(), 16))
                        .Sum())
                );
        }
        
        static void Main(string[] args)
        {
            string test = "1234:5678:9ABC:D00F:1111:2222:3333:4445";
            
            Console.WriteLine(ParseIPv6(test));
            Console.ReadKey();
        }
    }
}