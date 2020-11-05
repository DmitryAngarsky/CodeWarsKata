using System;
using System.Collections.Generic;
using System.Linq;

namespace Array.diff
{
    class Program
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            // With a hashset, we won't have to iterate over b for every item in a.
            // Instead, we can check if an item exists in constant time
            //HashSet<int> bSet = new HashSet<int>(b);

            //return a.Where(v => !bSet.Contains(v)).ToArray();

            return a.Where(e => !b.Contains(e)).ToArray();
        }

        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 2 };
            int[] arr2 = new int[] { 1 };

            foreach(int e in ArrayDiff(arr1, arr2))
                Console.WriteLine(e);

            Console.ReadKey();
        }
    }
}
