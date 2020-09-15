using System;
using System.Globalization;

namespace NumberFormat
{
    class Program
    {
        public static string NumberFormat(int number)
        {
            return number.ToString("N0", CultureInfo.InvariantCulture);
            //return $"{number:N0}";
        }

        static void Main(string[] args)
        {
            int test = -420902;

            Console.WriteLine(NumberFormat(test));
            Console.ReadKey();
        }
    }
}
