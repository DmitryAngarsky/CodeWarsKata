using System;
using System.Linq;

namespace ValidateCard
{
    internal static class Program
    {
        private static bool Validate(string n)
        {
            return n
                .Replace(" ", "")
                .Reverse()
                .Select((num, i) => i % 2 != 0 ? (num - '0') * 2 : num - '0')
                .Select(s => s > 9 ?  s - 9 : s)
                .Sum() % 10 == 0;
        }
        
        static void Main(string[] args)
        {
            string test1 = "477 073 360";
            const string test2 = "5422 0148 5514";
            
            Console.WriteLine(Validate(test1));
            Console.ReadKey();
        }
    }
}