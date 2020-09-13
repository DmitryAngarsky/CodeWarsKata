using System;
using System.Linq;

namespace BitCounting
{
    class Program
    {
        public static int CountBits(int n)
        {
            //return (n == 0) ? 0 : (n & 1) + CountBits(n >> 1);
            return Convert.ToString(n, 2).Count(c => c == '1');
        }

        static void Main(string[] args)
        {
            int test = 1234;

            Console.WriteLine(CountBits(test));
            Console.ReadKey();
        }
    }
}
