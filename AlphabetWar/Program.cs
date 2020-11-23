using System;
using System.Collections.Generic;
using System.Linq;

namespace AlphabetWar
{
    class Program
    {
        private static readonly Dictionary<char, int> LeftSide = new Dictionary<char, int>()
        {
            {'w', 4},
            {'p', 3},
            {'b', 2},
            {'s', 1}
        };

        private static readonly Dictionary<char, int> RightSide = new Dictionary<char, int>()
        {
            {'m', 4},
            {'q', 3},
            {'d', 2},
            {'z', 1}
        };

        private static int AlphabetSum(string str, Dictionary<char, int> dic) => str.Where(dic.ContainsKey).Sum(a => dic[a]);
        
        public static string AlphabetWar(string fight)
        {
            int result = AlphabetSum(fight, RightSide) - AlphabetSum(fight, LeftSide);
            
            return result == 0 
                ? "Let's fight again!" 
                : result > 0 
                    ? "Right side wins!" 
                    : "Left side wins!";
            
            var score = fight.Sum(x => "sbpw".IndexOf(x) + 1 + -("zdqm".IndexOf(x) + 1));
            return score == 0 ? "Let's fight again!" : score < 0 ? "Right side wins!" : "Left side wins!";
        }
        
        static void Main(string[] args)
        {
            string test = "wwwwwwz";
            
            Console.WriteLine(AlphabetWar(test));
            Console.ReadKey();
        }
    }
}