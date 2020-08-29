using System;

namespace BuildAPileOfCubes
{
    class Program
    {
        public static long findNb(long m)
        {
            long n = 0;
            long total = 0;

            while (total < m)
            {
                n += 1;
                total += (n * n * n);
            }

            return total == m ? n : -1;
        }

        static void Main(string[] args)
        {
            long test = 1071225;
            Console.WriteLine(findNb(test));
            Console.ReadKey();
        }
    }
}
