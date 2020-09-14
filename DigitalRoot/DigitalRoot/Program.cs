using System;

namespace DigitalRoot
{
    class Program
    {
        public static int DigitalRoot(long n)
        {
            return (int)(1 + (n - 1) % 9);
            //return n < 10 ? (int)n : DigitalRoot((long)n.ToString().Select(x => char.GetNumericValue(x)).Sum());
        }

        static void Main(string[] args)
        {
            long test = 493193;

            Console.WriteLine(DigitalRoot(test));
            Console.ReadKey();
        }
    }
}
