using System;

namespace PerfectSquare
{
    class Program
    {
        public static long FindNextSquare(long num)
        {
            double sqrt = Math.Sqrt(num);
            return num % sqrt == 0 ? (long)((sqrt + 1) * (sqrt + 1)) : -1;
        }
        static void Main(string[] args)
        {
            long ex = 319225;
            Console.WriteLine(FindNextSquare(ex));
            Console.ReadKey();
        }
    }
}
