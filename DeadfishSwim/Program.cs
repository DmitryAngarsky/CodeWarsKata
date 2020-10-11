using System;
using System.Collections.Generic;

namespace DeadfishSwim
{
    internal static class Program
    {
        private static int[] Parse(string data)
        {
            int fish = 0;
            List<int> result = new List<int>();
            
            foreach (int i in data)
            {
                switch (i)
                {
                    case 'i':
                        fish += 1;
                        break;
                    case 's':
                        fish *= fish;
                        break;
                    case 'd':
                        fish -= 1;
                        break;
                    case 'o':
                        result.Add(fish);
                        break;
                }
            }
            
            return result.ToArray();
        }
        
        static void Main()
        {
            const string test = "iiisdoso";

            foreach (var fish in Parse(test))
            {
                Console.WriteLine(fish);
            }
            Console.ReadKey();
        }
    }
}