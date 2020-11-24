using System;
using System.Linq;

namespace GA_DE_RY_PO_LU_KICypher
{
    class Program
    {
        public static string Encode(string str)
        {
            string key = "GADERYPOLUKI";

            var test = str.ToUpper()
                .Select(c => 
                    key.Contains(c) 
                        ? key.IndexOf(c) % 2 == 0 
                            ? key[key.IndexOf(c) + 1] 
                            : key[key.IndexOf(c) - 1] 
                        : c)
                .ToArray();

            return string.Concat(
                str.Select((c, i) =>
                    char.IsUpper(c)
                        ? char.ToUpper(test[i])
                        : char.ToLower(test[i])));
        }

        public static string Decode(string str)
        {
            return str;
        }
        
        static void Main(string[] args)
        {
            string test = "gaderypoluki";
            
            Console.WriteLine("agedyropulik" == Encode(test));
            Console.ReadKey();
        }
    }
}