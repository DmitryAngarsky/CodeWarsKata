using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrhGrabscrab
{
    class Program
    {
        public static List<string> Grabscrab(string anagram, List<string> dictionary)
        {
            return dictionary.Where(x => string.Concat(x.OrderBy(y => y)) == string.Concat(anagram.OrderBy(z => z))).ToList();
            //return dictionary.Where(w => w.OrderBy(o => o).SequenceEqual(anagram.OrderBy(o => o))).ToList();
        }

        static void Main(string[] args)
        {
            List<string> pirateDictionary = new List<string>{ "donkey", "pool", "horse", "loop" };
            string pirateWord = "ooqqqlp";

            foreach (string w in Grabscrab(pirateWord, pirateDictionary))
            {
                Console.WriteLine(w);
            }
            
            Console.ReadKey();
        }
    }
}
