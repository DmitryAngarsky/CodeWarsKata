using System;
using System.Linq;

namespace DigitalСypher_3
{
    class Program
    {
        // public static int FindTheKey(string message, int[] code)
        // {
        //     var repeatingCode = string.Concat(message.Select((x,i) => code[i] - (x - 96)));
        //     return Convert.ToInt32(FindCode(repeatingCode));
        // }
        //
        // private static string FindCode(string target) 
        //     => Enumerable.Range(1, target.Length)
        //         .Select(x => string.Concat(target.Take(x)))
        //         .First(x => string.Concat(Enumerable.Repeat(x, target.Length)).StartsWith(target));
        
        public static int FindTheKey(string message, int[] code)
        {
            bool IsSequence(string seq, string substring)
            {
                for (int i = 0; i < seq.Length; i += 1) {
                    if (seq[i] != substring[i % substring.Length]) {
                        return false;
                    }
                }
                
                return true;
            }
            
            var sequence = string.Concat(message.Select((c, i) => code[i] - (c - 96)));
            string result = string.Empty;
            
            for (int i = 0; i < sequence.Count(); i += 1) {
                result += sequence[i];
                if (IsSequence(sequence, result)) {
                    return int.Parse(result);
                }
            }
            
            return int.Parse(result);
        }
        
        static void Main(string[] args)
        {
            const string message = "masterpiece";
            int[] code = {14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8};
            
            Console.WriteLine(FindTheKey(message, code));
            Console.ReadKey();
        }
    }
}