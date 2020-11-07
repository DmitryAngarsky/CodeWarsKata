using System;
using System.Linq;

namespace Rot13
{
    class Program
    {
        private static string Rot13(string message)
        {
            // return String.Join("", message
            //     .Select(x => char.IsLetter(x) 
            //         ? (x >= 65 && x <= 77) || (x >= 97 && x <= 109) 
            //             ? (char)(x + 13) 
            //             : (char)(x - 13) 
            //         : x));
            //
            // return string.Concat(message
            //     .Select(c => char.IsLetter(c) 
            //         ? (char) (c + (char.ToLower(c) > 'm' ? -13 : 13)) 
            //         : c));
            
            char GetReplace(char c) => char.IsLetter(c) ? c - 97 >= 13 ? (char)(c - 13) : (char)(c + 13) : c;
            return string.Concat(
                message.Select(c => char.IsUpper(c)
                    ? char.ToUpper(GetReplace(char.ToLower(c))) 
                    : GetReplace(c)));
        }
        
        static void Main(string[] args)
        {
            const string test = "Test";
            
            Console.WriteLine(Rot13(test));
            Console.ReadKey();
        }
    }
}