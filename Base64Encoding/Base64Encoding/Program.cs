using System;
using System.Linq;

namespace Base64Encoding
{
    class Program
    {
        public static string ToBase64(string s)
        {
            var test = s.Select(c => Convert.ToString(c, 2));
            foreach(string b in test)
            {
                Console.WriteLine(b);
            }
            return s;
        }

        public static string FromBase64(string s)
        {
            // Happy coding!
            return s;
        }

        static void Main(string[] args)
        {
            string test = "this is a string!!";
            string test1 = "dGhpcyBpcyBhIHN0cmluZyEh";

            Console.WriteLine(ToBase64(test));
            Console.WriteLine(FromBase64(test1));
            Console.ReadKey();
        }
    }
}
