using System;
using System.Linq;
using System.Text;

namespace BasicEncryption
{
    class Program
    {
        public static string Encrypt(string text, int rule)
        {
            var cw = Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(text).Select(b => (byte)(b + rule )).ToArray());
            var test = Encoding.ASCII.GetString(text.Select(a => (byte)(a + rule & 255)).ToArray());
            var test1 = text.Aggregate("", (a, b) => Encoding.ASCII.GetString(new byte[] { (byte)b }));

            return test1;
        }

        static void Main(string[] args)
        {
            string test = Encrypt("please encrypt me6", 2);

            Console.WriteLine(test);
            Console.ReadKey();
        }
    }
}
