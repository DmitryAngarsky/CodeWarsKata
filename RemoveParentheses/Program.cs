using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RemoveParentheses
{
    class Program
    {
        public static string RemoveParentheses(string s)
        {
            var str = s;
            var result = new Regex(@"\(.*\)").Replace(s, "");
            return result;
        }
        
        static void Main(string[] args)
        {
            const string test = "(first group) (second group) (third group)";
            
            Console.WriteLine(RemoveParentheses(test));
            Console.ReadKey();
        }
    }
}