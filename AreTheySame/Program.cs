using System;
using System.Linq;

namespace AreTheySame
{
    class Program
    {
        public static bool comp(int[] a, int[] b)
        {
            return a != null && b != null && a.Length == b.Length && b.OrderBy(x => x).SequenceEqual(a.OrderBy(x => x).Select(x => x * x).ToArray()) ? true : false;
        }

        static void Main(string[] args)
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };


            Console.WriteLine(comp(a, b));
            Console.Read();
        }
    }
}
