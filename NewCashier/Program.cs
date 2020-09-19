using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace NewCashier
{
    class Program
    {
        // My Solution
        // public static string GetOrder(string input)
        // {
        //     string[] menu = {
        //         "Burger", "Fries", "Chicken", "Pizza", 
        //         "Sandwich", "Onionrings", "Milkshake", "Coke"
        //     };
        //     
        //     var resilt = string.Empty;
        //     
        //     foreach (var t in menu)
        //     {
        //         if (input.Contains(t.ToLower()))
        //         {
        //             resilt += string.Concat(Enumerable.Repeat($"{t} ", input.Split(t.ToLower()).Length - 1));
        //         }
        //     }
        //     
        //     return resilt.Trim();
        // }

        private static string GetOrder(string input) => 
            string.Join(" ", new []{"Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke"}
                .SelectMany(f => Enumerable.Repeat(f, Regex.Matches(input, f.ToLower()).Count)));
        
        static void Main(string[] args)
        {
            string test = "milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza";
            Console.WriteLine(GetOrder(test));
            Console.ReadKey();
        }
    }
}