using System;
using System.Linq;

namespace RGBToHexConversion
{
    class Program
    {
        public static string Rgb(int r, int g, int b)
        {
            return string.Concat(
                new int[] { r, g, b }
                .Select(i => Math.Clamp(i, 0 , 255).ToString("X2")));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Rgb(211, 53, 12));
            Console.ReadKey();
        }
    }
}
