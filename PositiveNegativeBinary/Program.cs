using System;
using System.Linq;

namespace PositiveNegativeBinary
{
    class Program
    {
        private static int[] Positive2Negative(int[] binaryArray)
        {
            int[] test = Convert
                .ToString(~Convert.ToInt32(binaryArray.Aggregate("", (c, n) => c + n), 2) + 1, 2)
                .PadRight(32, '0')
                .Skip(28)
                .Select(c => c - '0')
                .ToArray();
            
            Console.WriteLine(string.Concat(test));
            return test;
        }
        
        static void Main(string[] args)
        {
            int[] test = {0, 0, 0, 0};
            
            Console.WriteLine(Positive2Negative(test).SequenceEqual(new int[] {0,0,0,0}));
            Console.ReadKey();
        }
    }
}