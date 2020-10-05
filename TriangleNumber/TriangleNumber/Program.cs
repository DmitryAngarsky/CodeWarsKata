using System;

namespace TriangleNumber
{
    class Program
    {
        public static bool isTriangleNumber(long number)
        {
            return Math.Sqrt(8 * number + 1) % 1 == 0;
        }

        static void Main(string[] args)
        {
            long test = 125250;

            Console.WriteLine(isTriangleNumber(test));
            Console.ReadKey();
        }
    }
}
