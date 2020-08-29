using System;
using System.Linq;

namespace PersistentBugger
{
    class Program
    {
        public static int Persistence(long n)
        {
            int count = 0;
            while (n > 9)
            {
                n = (long)n.ToString().Select(x => char.GetNumericValue(x)).Aggregate((x, y) => x * y);
                count += 1;
            }
            return count;
            //Recursion solution
            //long nF = n.ToString().Aggregate(1, (a, b) => a * (b - '0'));
            //return n < 9 ? 0 : 1 + Persistence(nF);
        }

        static void Main(string[] args)
        {
            //long test1 = 39;
            long test2 = 999;

            Console.WriteLine(Persistence(test2));
            Console.ReadKey();
        }
    }
}
