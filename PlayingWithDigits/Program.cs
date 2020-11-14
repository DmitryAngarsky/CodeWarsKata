using System;
using System.Linq;

namespace PlayingWithDigits
{
    class Program
    {
        private static long DigPow(int n, int p)
        {
            long magic = (long)$"{n}"
                .Select((c, i) => Math.Pow(c - '0', p + i))
                .Sum();
            
            return magic % n == 0 ? magic / n : -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DigPow(46288, 3));
            Console.ReadKey();
        }
    }
}
