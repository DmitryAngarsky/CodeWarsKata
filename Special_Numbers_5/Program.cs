using System;
using System.Linq;

namespace Special_Numbers_5
{
    class Program
    {
        public static string SpecialNumber(int number)
        {
            return $"{number}".All(n => n - '0' <= 5) 
                ? "Special!!" 
                : "NOT!!";
        }
        
        static void Main(string[] args)
        {
            const int test = 513;
            
            Console.WriteLine(SpecialNumber(test) == "Special!!");
            Console.ReadKey();
        }
    }
}