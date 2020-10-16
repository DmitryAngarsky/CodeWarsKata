using System;
using System.Linq;

namespace ZooPatrol
{
    class Program
    {
        public static int FindNumber(int[] array)
        {
            var test = Enumerable.Range(1, array.Length + 1).Except(array);
            return test.First();
        }

        static void Main(string[] args)
        {
            int[] test = new int[] { 13, 11, 10, 3, 2, 1, 4, 5, 6, 9, 7, 8 };

            Console.WriteLine(FindNumber(test));
            Console.ReadKey();
        }
    }
}
