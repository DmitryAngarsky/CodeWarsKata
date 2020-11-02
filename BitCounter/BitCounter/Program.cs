using System;

namespace BitCounter
{
    class Program
    {
        public static bool SharedBits(int a, int b)
        {
            return Convert.ToString(a & b, 2).Replace("0", "").Length >= 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SharedBits(10, 15));
            Console.ReadKey();
        }
    }
}
