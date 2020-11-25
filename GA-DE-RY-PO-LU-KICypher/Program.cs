using System;
using System.Linq;

namespace GA_DE_RY_PO_LU_KICypher
{
    class Program
    {
        public static string Encode1(string str) => Decode1(str);
        public static string Decode1(string str)
        {
            var s = "GDRPLKgdrplkAEYOUIaeyoui";
            var t = "AEYOUIaeyouiGDRPLKgdrplk";
            return string.Concat(str.Select(x => s.IndexOf(x) < 0 ? x : t[s.IndexOf(x)]));
        }
        
        private static string Translate(string str)
        {
            const string key = "GADERYPOLUKI";

            char[] charsWithKey = str.ToUpper()
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
                        ? char.ToUpper(charsWithKey[i])
                        : char.ToLower(charsWithKey[i])));
        }
        public static string Encode(string str)
        {
            return Translate(str);
        }

        public static string Decode(string str)
        {
            return Translate(str);
        }
        
        static void Main(string[] args)
        {
            string test = "agedyropulik";
            Console.WriteLine(Decode(test));
            Console.WriteLine("gaderypoluki" == Decode(test));
            Console.ReadKey();
        }
    }
}