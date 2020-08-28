using System;
using System.Collections.Generic;
using System.Linq;


namespace FindTheUniqueNumber
{
    class Program
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            //var my = numbers.GroupBy(x => x).Where(y => y.Count() == 1).Select(i => i.First()).ToArray().First();
            return numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;
        }

        static void Main(string[] args)
        {
            int[] test3 = new[] { 11, 11, 14, 11, 11 };

            Console.WriteLine(GetUnique(test3));
            Console.ReadKey();
        }
    }
}
