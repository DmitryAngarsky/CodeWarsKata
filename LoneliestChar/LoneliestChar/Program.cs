using System;

namespace LoneliestChar
{
    class Program
    {
        public static char[] Loneliest(string result)
        {
            return result.ToCharArray();
        }

        static void Main(string[] args)
        {
            string test = "    a b  sc     p     t   k";

            Console.WriteLine(Loneliest(test));
            Console.ReadKey();
        }
    }
}
