using System;
using System.Linq;

namespace StringBreakers
{
    class Program
    {
        private static string StringBreakers(int n, string str)
        {
            string emptyStr = str.Replace(" ", "");
            int[] indexesToSplit = Enumerable
                .Range(0, emptyStr.Length)
                .Where(w => w % n == 0)
                .ToArray();

            string first = string.Concat(
                indexesToSplit
                    .Take(indexesToSplit.Length - 1)
                    .Select(i => emptyStr[i..(i + n)] + "\n"));
            
            string second = emptyStr.Substring(indexesToSplit.Last());
            
            return first + second;
            
            //return string.Concat(str.Replace(" ", "").Select((x,i) => i != 0 && i % n == 0 ? "\n" + x : x.ToString()));
        }
        
        static void Main(string[] args)
        {
            const string str = "This is an example string";
            const int count = 5;
            
            Console.WriteLine(StringBreakers(count, str));
        }
    }
}