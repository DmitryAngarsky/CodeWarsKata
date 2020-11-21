using System;
using System.Linq;

namespace Form_The_Largest
{
    class Program
    {
        private static int MaxNumber(int n)
        {
            return int.Parse($"{n}".OrderByDescending(c => c - '0').ToArray());
            return int.Parse(string.Concat($"{n}".OrderByDescending(c => c - '0')));
        }
        
        static void Main(string[] args)
        {
            int test = 566797;
            
            Console.WriteLine(MaxNumber(test));
            Console.ReadKey();
        }
    }
}