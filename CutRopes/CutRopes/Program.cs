using System;
using System.Collections.Generic;
using System.Linq;

namespace CutRopes
{
    class Program
    {
        public static int[] CutTheRopes(int[] a)
        {
            List<int> sourceArray = new List<int>(a);
            List<int> result = new List<int>();

            while (sourceArray.Count != 0)
            {
                result.Add(sourceArray.Count());
                int min = sourceArray.Min();

                sourceArray = sourceArray.Select(x => x - min).Where(f => f > 0).ToList();
            }

            return result.ToArray();
        }

        static void Main(string[] args)
        {
            int[] test = new int[] { 3, 3, 2, 9, 7 };

            foreach(int a in CutTheRopes(test))
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}
