using System;
using System.Collections.Generic;
using System.Linq;

namespace Wave
{
    class Program
    {
        static public List<string> wave(string str)
        {
            //return Enumerable.Range(0, str.Length)
            //    .Select(i => string.Concat(str.Select((x, y) => y == i ? char.ToUpper(x) : x)))
            //    .Where(x => x != str).ToList();

            return str.Select((x, u) => x == ' ' ? -1 : u)
                .Where(y => y != -1)
                .Select(s => string.Concat(
                    str.Select((c, i) => i == s ? char.ToUpper(c) : c)))
                    .ToList();
        }

        static void Main(string[] args)
        {
            string test = " gap ";

            foreach(string s in wave(test))
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
