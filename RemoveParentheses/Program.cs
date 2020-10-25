using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RemoveParentheses
{
    class Program
    {
        // public static string RemoveParentheses(string s)
        //     => s.Contains('(') ? RemoveParentheses(Regex.Replace(s, @"\([^()]*\)","")) : s;
        
        public static string RemoveParentheses(string s)
        {
            return Regex.Replace(s, @"\((?>[^()]+|\((?<Depth>)|\)(?<-Depth>))*(?(Depth)(?!))\)", string.Empty);
        }
        
        static void Main(string[] args)
        {
            const string test = "(first group) (second group) (third group)";
            
            Console.WriteLine(RemoveParentheses(test));
            Console.ReadKey();
        }
    }
}