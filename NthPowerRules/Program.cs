using System;
using System.Linq;

namespace NthPowerRules
{
    class Program
    {
        public static int ModifiedSum(int[] a, int n)
        {
            return a.Sum(x => (int) Math.Pow(x, n) - x);
            return a.Select(i => (int)Math.Pow(i, n)).Sum() - a.Sum();
        }
        
        static void Main(string[] args)
        {
            int[] test = {1, 2, 3};
            
            Console.WriteLine(ModifiedSum(test, 3));
            Console.ReadKey();
        }
    }
}
