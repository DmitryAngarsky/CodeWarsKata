using System;
using System.Linq;

namespace CasinoChips
{
    class Program
    {
        public static int solve(int[] arr)
        {
            int result = 0;
            Array.Sort(arr);
            while (arr[1] > 0)
            {
                arr[2]--;
                arr[1]--;
                result++;
                Array.Sort(arr);
            }

            return result;
        }
        
        static void Main(string[] args)
        {
            int[] test = { 7, 4, 10 };
            
            Console.WriteLine(solve(test));
            Console.ReadKey();
        }
    }
}