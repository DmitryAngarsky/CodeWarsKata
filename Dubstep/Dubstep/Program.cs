using System;
using System.Linq;

namespace Dubstep
{
    class Program
    {
        public static string SongDecoder(string input)
        {
            //return Regex.Replace(input, "(WUB)+", " ").Trim();
            return string.Concat(input.Replace("WUB", " ").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => x + " ")).TrimEnd();
        }
        static void Main(string[] args)
        {
            string test = "WUBWEWUBAREWUBWUBTHEWUBCHAMPIONSWUBMYWUBFRIENDWUB";

            Console.WriteLine(SongDecoder(test));
            Console.ReadKey();
        }
    }
}
