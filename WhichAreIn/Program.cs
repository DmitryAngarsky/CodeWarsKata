using System;
using System.Linq;

namespace WhichAreIn
{
    class Program
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            return array1
                .Where(s1 => array2.Any(s2 => s2.Contains(s1)))
                .OrderBy(s => s)
                .ToArray();
            
            return array2
                .Where(str => array1.Any(s => str.IndexOf(s, StringComparison.Ordinal) != -1))
                .SelectMany(s => array1.Where(c => s.IndexOf(c, StringComparison.Ordinal) != -1))
                .Distinct()
                .OrderBy(x => x)
                .ToArray();
        }
        
        static void Main()
        {
            string[] test1 = { "code", "ewar", "wars" };
            string[] test2 = { "codewars" };

            foreach (string str in inArray(test1, test2))
                Console.WriteLine(str);
            
            Console.ReadKey();
        }
    }
}