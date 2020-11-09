using System;

namespace BinaryAddition
{
    class Program
    {
        public static string AddBinary(int a, int b)
        {
            return Convert.ToString(a + b, 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AddBinary(1, 2));
            Console.ReadKey();
        }
    }
}
