using System;
using System.Linq;

namespace SplitStrings
{
    class Program
    {
        public static string[] Solution(string str)
        {
            //Enumerable.Range(0, str.Length / 2).Select(i => string.Concat(str. Skip(i * 2).Take(2))).ToArray();
            //Enumerable.Range(0, str.Length).Where(w => w % 2 == 0).Select(s => str[s..(s + 2)]).ToArray();
            //Enumerable.Range(0, str.Length).Where(x => x % 2 == 0).Select(x => str.Substring(x, 2)).ToArray();

            string[] SplitString(string s) => Enumerable.Range(0, s.Length / 2)
                .Select(i => s.Substring(i * 2, 2))
                .ToArray();

            return str.Length % 2 == 0 ? SplitString(str) : SplitString(str + "_");
        }

        static void Main(string[] args)
        {
            string test = "";

            foreach(string s in Solution(test))
            {
                Console.WriteLine(s);
            }
            
            Console.ReadKey();
        }
    }
}
