using System;
using System.Linq;
using System.Collections.Generic;

namespace SumsOfParts
{
    class Program
    {
        public static IEnumerable<int> GetSum(IEnumerable<int> iterable)
        {
            int result = 0;
            foreach(var n in iterable)
            {
                yield return result += n;
            }
        }
        //return Enumerable.Range(0, ls.Length)
        //                     .Select(n => ls.Skip(n).Sum()).Append(0).ToArray();
        
        public static int[] PartsSums(int[] ls)
        {
            int[] result = new int[ls.Length + 1];
            result[ls.Length] = 0;
            
            for (int i = 0; i < ls.Length; i++)
            {
                result[i] = ls.Skip(i).Sum();
            }

            return result;
        }

        static void Main(string[] args)
        {
            var test = new int[] { 0, 1, 3, 6, 10 };
            
            foreach(int n in GetSum(test))
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
