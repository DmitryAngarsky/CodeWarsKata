using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharacters
{
    class Program
    {
        public static Dictionary<char, int> Count(string str)
        {
            return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

            //Dictionary<char, int> dictionary = new Dictionary<char, int>();

            //foreach (char c in str)
            //    if (dictionary.ContainsKey(c))
            //        dictionary[c]++;
            //    else
            //        dictionary.Add(c, 1);

            //return dictionary;
        }

        static void Main(string[] args)
        {
            string test = "aabbiiissss qqq";
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 2);
            d.Add('b', 2);

            foreach (var keyValue in Count(test))
                Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");

            Console.ReadKey();
        }
    }
}
