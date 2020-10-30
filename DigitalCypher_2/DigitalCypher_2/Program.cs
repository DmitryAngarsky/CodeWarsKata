using System;
using System.Linq;

namespace DigitalCypher_2
{
    class Program
    {
        public static string Decode(int[] code, int key)
        {
            return string.Join("", code.Select((c, i) => (char)(96 + c - ($"{key}"[i % $"{key}".Length] - '0'))));
        }

        static void Main(string[] args)
        {
            int[] test = new int[] { 20, 12, 18, 30, 21 };

            Console.WriteLine(Decode(test, 1939));
            Console.ReadKey();
        }
    }
}
