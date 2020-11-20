using System;
using System.Linq;

namespace MinimizeSumOfArray
{
    class Program
    {
        private static int MinSum(int[] a)
        {
            return a.OrderBy(n => n)
                .Skip(a.Length / 2)
                .Zip(a.OrderByDescending(n => n)
                    .Skip(a.Length / 2), (first, second) => first * second)
                .Sum();
            
            IOrderedEnumerable<int> orderedArray = a.OrderBy(i => i);

            return orderedArray.Take(a.Length / 2)
                .Zip(orderedArray.Skip(a.Length / 2).Reverse(), (first, second) => first * second)
                .Sum();
        }
        
        static void Main()
        {
            int[] test = {9,2,8,7,5,4,0,6};
            
            Console.WriteLine(MinSum(test));
            Console.ReadKey();
        }
    }
}