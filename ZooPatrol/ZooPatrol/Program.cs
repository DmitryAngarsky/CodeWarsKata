using System;
using System.Linq;

namespace ZooPatrol
{
    class Program
    {
        //HashSet<int> animals = new HashSet<int>(array);
  
        //foreach (int i in Enumerable.Range(1, array.Length + 1))
        //{
        //    if (!animals.Contains(i)) 
        //    { 
        //        return i; 
        //    }
        //}
    
        //return -1;

        public static int FindNumber(int[] array)
        {
            return Enumerable.Range(1, array.Length + 1).Except(array).First();
        }

        static void Main(string[] args)
        {
            int[] test = new int[] { 13, 11, 10, 3, 2, 1, 4, 5, 6, 9, 7, 8 };

            Console.WriteLine(FindNumber(test));
            Console.ReadKey();
        }
    }
}
