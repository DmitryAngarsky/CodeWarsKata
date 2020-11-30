using System;
using System.Collections.Generic;
using System.Linq;

namespace AlphabetWar_vol2
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

        private static string BombResult(string str)
        {
            LinkedList<char> linkedList = new LinkedList<char>(str.ToCharArray());
            LinkedListNode<char> currentNode = linkedList.First;

            while (currentNode != null)
            {
                if (currentNode.Value == '*')
                {
                    if(currentNode.Previous != null && currentNode.Previous.Value != '*')
                        linkedList.Remove(currentNode.Previous);
                    if(currentNode.Next != null && currentNode.Next.Value != '*')
                        linkedList.Remove(currentNode.Next);
                }

                currentNode = currentNode.Next;
            }
            
            return string.Concat(linkedList.Where(c => c != '*'));
        }
        
        public static string AlphabetWar(string fight)
        {
            fight = BombResult(fight);
            int result = AlphabetSum(fight, RightSide) - AlphabetSum(fight, LeftSide);
            
            return result == 0 
                ? "Let's fight again!" 
                : result > 0 
                    ? "Right side wins!" 
                    : "Left side wins!";
        }
        
        static void Main()
        {
            string test = "sb***nb*nzw****bunutw*w";
            
            Console.WriteLine(BombResult(test));
            Console.WriteLine(AlphabetWar(test));
            Console.ReadKey();
        }
    }
}