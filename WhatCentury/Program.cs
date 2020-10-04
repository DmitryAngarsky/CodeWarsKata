using System;

namespace WhatCentury
{
    internal static class Program
    {
        private static string WhatCentury(string year)
        {
            // int century = (int.Parse(year) / 100);
            // century = (int.Parse(year) % 100) == 0 ? century : century + 1;
            //
            // string terminator = "th";
            //
            // terminator = century % 10 == 1 && century != 11 ? "st" : terminator;
            // terminator = century % 10 == 2 && century != 12 ? "nd" : terminator;
            // terminator = century % 10 == 3 && century != 13 ? "rd" : terminator;
            //
            // return century + terminator;
            
            int intYear = int.Parse(year) / 100 + (int.Parse(year) % 100 == 0 ? 0 : 1);
            
            string suffix = (intYear % 10 == 1 && intYear != 11) ? "st"
                : (intYear % 10 == 2 && intYear != 12) ? "nd"
                : (intYear % 10 == 3 && intYear != 13) ? "rd"
                : "th";
            
            return intYear + suffix;
        }
        
        static void Main()
        {
            const string test = "2000";
            
            Console.WriteLine(WhatCentury(test));
            Console.ReadKey();
        }
    }
}