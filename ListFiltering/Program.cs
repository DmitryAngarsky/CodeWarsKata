using System;
using System.Collections.Generic;
using System.Linq;

namespace ListFiltering
{
    class Program
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            //foreach (object x in listOfItems)
            //    if (x is int) yield return (int)x;
            return listOfItems.OfType<int>();
        }
        
        static void Main(string[] args)
        {
            List<object> test = new List<object>() { 1, 2, "aasf", "1", "123", 123 };

            foreach(var s in GetIntegersFromList(test))
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}