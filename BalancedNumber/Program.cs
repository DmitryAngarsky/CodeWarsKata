using System;
using System.Linq;

namespace BalancedNumber
{
    class Program
    {
        private int TakeHalf(string str, int isOdd) => 
            $"{str}"
                .Take($"{str}".Length / 2 + isOdd)
                .Sum(c => c - '0');

        private int SwitchOdd(string str) => 
            $"{str}".Length % 2 == 0 
                ? TakeHalf(str, -1) 
                : TakeHalf(str, 1);

        private void MisteryZip(string str)
        {
            var zip = str.Take(str.Length / 2).Zip(str.Skip(str.Length /2), (first, second) => first - second);
        }
        
        public static string BalancedNumber(int number)
        {
            var test = $"{number}".Take($"{number}".Length / 2 - 1);
            Console.WriteLine(string.Concat(test));
            return $"{number}".Length % 2 == 0 ? "Balanced" : "Not Balanced";
        }
        
        static void Main(string[] args)
        {
            const int test = 1230987;
            
            Console.WriteLine(BalancedNumber(test) == "Not Balanced");
            Console.ReadKey();
        }
    }
}
