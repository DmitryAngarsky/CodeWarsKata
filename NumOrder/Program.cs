using System;
using System.Linq;

namespace NumOrder
{
    class Program
    {
        private static string Order(string words)
        {
            return string.IsNullOrEmpty(words)
                ? string.Empty
                : string.Join(" ", words.Split().OrderBy(w => w.SingleOrDefault(char.IsDigit)));
            
            // return string.Join(" ", words.Split().OrderBy(w => (int)w.FirstOrDefault(char.IsDigit)));
        }
          
        static void Main(string[] args)
        {
            const string theory = "Thi1s is2 3a T4est";
            const string fact = "is2 Thi1s T4est 3a";
            
            Console.WriteLine(theory.Equals(Order(fact)));
            Console.ReadKey();
        }
    }
}
