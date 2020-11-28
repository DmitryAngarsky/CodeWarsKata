using System;
using System.Linq;

namespace GA_DE_RY_PO_LU_KICypherVol_2
{
    class Program
    {
        private static string EncodeDecode(string str, string key)
        {
            key = key + key.ToUpper();
            for (int i = 0; i < key.Length; i+=2)
            {
                str = str.Replace(key[i], '~').Replace(key[i+1], key[i]).Replace('~', key[i+1]);
            }
            return str;
        }
        
        private static string Translate(string str, string key)
        {
            char[] charsWithKey = str.ToLower()
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
        
        public static string Encode(string str, string key)
        {
            return Translate(str, key);
        }
 
        public static string Decode(string str, string key)
        {
            return Translate(str, key);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}