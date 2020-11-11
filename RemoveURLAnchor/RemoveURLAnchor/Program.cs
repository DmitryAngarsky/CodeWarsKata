using System;
using System.Linq;

namespace RemoveURLAnchor
{
    class Program
    {
        public static string RemoveUrlAnchor(string url)
        {
            var test = url.TakeWhile(c => c != '#');
            return string.Concat(url.TakeWhile(c => c != '#'));
        }

        static void Main(string[] args)
        {
            string test = "www.codewars.com/katas/?page=1#about";

            Console.WriteLine(RemoveUrlAnchor(test));
            Console.ReadKey();
        }
    }
}
