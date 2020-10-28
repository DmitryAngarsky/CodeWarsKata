using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitalCypher
{
    class Program
    {
        //public static Dictionary<char, int> GetlettersToNumber()
        //{
        //    Dictionary<char, int> lettersToNumber = new Dictionary<char, int>();
        //    int i = 1;

        //    for(char c = 'a'; c <= 'z'; c++)
        //        lettersToNumber.Add(c, i++);

        //    return lettersToNumber;
        //}

        public static int[] Encode(string str, int n)
        {
            //string temp = string.Concat(Enumerable.Range(0, str.Length / $"{n}".Length).Select(a => $"{n}"));
            //string result = temp.Length == str.Length ? temp : temp + string.Concat($"{n}".Take(str.Length - temp.Length));
            //foreach (var i in str.Select((c, i) => i % $"{n}".Length))
            //    Console.WriteLine(i);

            //return result.Select(c => c - '0').Zip(str.Select(c => GetlettersToNumber()[c]), (first, second) => first + second).ToArray();

            return str.Select((c, i) => c - 96 + ($"{n}"[i % $"{n}".Length] - '0')).ToArray();
        }

        static void Main(string[] args)
        {
            string test = "masterpiece";
            int test1 = 1939;

            foreach (int i in Encode(test, test1))
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
