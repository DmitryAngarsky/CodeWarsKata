using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingByBits
{
    class Program
    {
        private static IEnumerable<int> SortByBit(int[] array)
        {
            return array
                .OrderBy(i => Convert.ToString(i, 2).Count(bit => bit == '1'))
                .ThenBy(number => number)
                .ToArray();
            
            var test = array.OrderBy(s => s).OrderBy(i => Convert.ToString(i, 2).Count(c => c == '1')).ToArray();
            
            foreach (var i in test)
                Console.WriteLine(i);
            
            return test;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(SortByBit(new[] { 3, 8, 3, 6, 5, 7, 9, 1 }).SequenceEqual(new[] { 1, 8, 3, 3, 5, 6, 9, 7 }));
            Console.ReadKey();
        }
    }
}