using System;
using System.Linq;

namespace HammingDistance
{
    class Program
    {
        public static int Distance(string a, string b)
        {
            //return a.Zip(b, (x, y) => x != y).Count(x => x == true);
            //return Enumerable.Range(0, a.Length).Count(i => a[i] != b[i]);
            return a.Where((x, i) => a[i] != b[i]).Count();
        }

        static void Main(string[] args)
        {
            string str1 = "I like turtles";
            string str2 = "I like turkeys";

            Console.WriteLine(Distance(str1, str2));
            Console.ReadKey();
        }
    }
}
