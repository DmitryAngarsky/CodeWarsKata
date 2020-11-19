using System;
using System.Linq;

namespace HighestScoringWord
{
    class Program
    {
        private static string High(string s)
        {
            return s.Split().OrderBy(w => w.Sum(c => c - 96)).Last();
            return s.Split()
                .Select(w => $"{w.Sum(c => c - 96)} " + w)
                .OrderByDescending(a => int.Parse(a.Split()[0]))
                .First().Split()[1];
        }
        
        static void Main()
        {
            string test = "man i need a taxi up to ubud";
            
            Console.WriteLine(High(test));
            Console.ReadKey();
        }
    }
}
