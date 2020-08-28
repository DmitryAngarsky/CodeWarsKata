using System;
using System.Linq;

namespace SquareEveryDigit
{
    class Program
    {
        public static int SquareDigits(int n)
        {
            return int.Parse(string.Concat(n.ToString().Select(x => (int)char.GetNumericValue(x) * (int)char.GetNumericValue(x))));
        }

        static void Main(string[] args)
        {
            int digit = 9119;
            Console.WriteLine(SquareDigits(digit));
            Console.ReadKey();
        }
    }
}
