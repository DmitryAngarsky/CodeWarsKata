using System;
using System.Collections.Generic;
using System.Linq;

namespace StringDuplicates
{
    class Program
    {
        // My solution
        //public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        //{
        //    T previous = default(T);
        //    foreach (T current in iterable)
        //    {
        //        if (!current.Equals(previous))
        //        {
        //            previous = current;
        //            yield return current;
        //        }
        //    }
        //}

        //public static string[] dup(string[] arr)
        //{
        //    return arr.Select(x => string.Concat(UniqueInOrder(x))).ToArray();
        //}

        public static string[] dup(string[] arr)
            => arr.Select(x => x.Aggregate("", (c, n) => c.EndsWith(n) ? c : c + n)).ToArray();

        //Regex
        //public static string[] dup(string[] arr)
        //{
        //    return arr.Select(x => Regex.Replace(x, "(.)\\1+", "$1")).ToArray();
        //}

        static void Main(string[] args)
        {
            string[] test = new string[] { "abracadabra","allottee","assessee" };

            foreach(string s in dup(test))
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
        
    }
    
}
