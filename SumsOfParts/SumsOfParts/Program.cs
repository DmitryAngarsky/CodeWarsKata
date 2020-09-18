using System;
using System.Linq;
using System.Collections.Generic;

namespace SumsOfParts
{
    class Program
    {
        //public IEnumerable<int> GetSum(IEnumerable<int> iterable, int n)
        //{
        //    int result = 0;
        //    for(int i = 0; i < iterable.LongCount() - n; i++)
        //    {
        //        yield return result += iterable[i];
        //    }
        //}
        public static int[] PartsSums(int[] ls)
        {
            return Enumerable.Range(0, ls.Length)
                             .Select(n => ls.Skip(n).Sum()).Append(0).ToArray();
        }

        static void Main(string[] args)
        {
            var test = new int[] { 0, 1, 3, 6, 10 };

            foreach(int n in PartsSums(test))
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
