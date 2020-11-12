using System;
using System.Linq;

namespace RagbabyCipher
{
    class Program
    {
        public static string Encode1(string t, string k) => Translate(t, k, 1); 
        public static string Decode1(string t, string k) => Translate(t, k, -1);

        private static string Translate(string text, string key, int forward, int count = 1)
        {
            key = string.Concat((key + "abcdefghijklmnopqrstuvwxyz").Distinct());
            
            return string.Concat(
                text.Select((c, j) => !char.IsLetter(c) 
                    ? text[j + (count = 1) - 1] 
                    : char.IsLower(c) 
                        ? key[(26 + key.IndexOf(c) + forward * count++) % 26] 
                        : char.ToUpper(key[(key.IndexOf(char.ToLower(c)) + forward * count++) % 26])));
        }

        private static string Transformation(string text, string key, int forward)
        {
            string result = string.Empty;
            int count = 1;
            
            var keyedAlphabet = string.Concat(key.Distinct()) 
                                  + string.Concat(Enumerable.Range(0, 26).Select(c => (char)(c + 97)).Except(key.Distinct()));

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    int index = keyedAlphabet.IndexOf(char.ToLower(c)) + (count * forward);
                    int trueIndex = index > 25 ? index % 26 : index < 0 ? 26 + (index % 26) : index;
                    
                    result += char.IsLower(c) ? keyedAlphabet[trueIndex] : char.ToUpper(keyedAlphabet[trueIndex]);
                    count++;
                }
                else
                {
                    result += c;
                    count = 1;
                }
            }
            
            return result;
        }
        private static string Encode(string text, string key)
        {
            return Transformation(text, key, 1);
        }

        private static string Decode(string text, string key)
        {
            return Transformation(text, key, -1);
        } 
        
        static void Main()
        {
            int n = 5;
            const string key = "cipher";
            
            const string test = "This.tHis.thIs.thiS...";
            const string test1 = "Urew.uRew.urEw.ureW...";
            
            Console.WriteLine(Encode(test, key));
            Console.WriteLine(Decode(test1, key));
            Console.ReadKey();
        }
    }
}
