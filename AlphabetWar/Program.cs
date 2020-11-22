using System;
using System.Collections.Generic;
using System.Linq;

namespace AlphabetWar
{
    class Program
    {
        public static Dictionary<char, int> LeftSide = new Dictionary<char, int>()
        {
            {'w', 4},
            {'p', 3},
            {'b', 2},
            {'s', 1}
        };
        
        public static Dictionary<char, int> RightSide = new Dictionary<char, int>()
        {
            {'m', 4},
            {'q', 3},
            {'d', 2},
            {'z', 1}
        };
        
        public static string AlphabetWar(string fight)
        {
            var test = fight.Aggregate(0, (c, i) => LeftSide.ContainsKey(i) ? -LeftSide[i] : RightSide[i]);
            return test == 0 ? "Let's fight again!" : test > 0 ? "Right side wins!" : "Left side wins!";
        }
        
        static void Main(string[] args)
        {
            string test = "zdqmwpbs";
            
            Console.WriteLine(AlphabetWar(test));
            Console.ReadKey();
        }
    }
}