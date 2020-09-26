using System;
using System.Linq;

namespace int32ToIPv4
{
    class Program
    {
        // public static string UInt32ToIP1(uint n) => 
        //     $"{n>>24}.{n>>16&255}.{n>>8&255}.{n&255}";
        
        // public static string UInt32ToIP(uint ip) 
        //     => string.Join(".",(new int[] {24,16,8,0}).Select(e=> ip >> e & 255 ));
        
        // ReSharper disable once InconsistentNaming
        public static string UInt32ToIP(uint ip)
        {
            string ipStr = "00000000000000000000000000000000";
            var str = Convert.ToString(ip, 2);
            var format = ipStr[..^str.Length] + str;
            var test = Enumerable.Range(0, format.Length)
                .Where(n => n % 8 == 0)
                .Select(s => format[s..(s + 8)]);

            return string.Join(".", test.Select(s => Convert.ToByte(s, 2)));
        }
        
        static void Main(string[] args)
        {
            const uint test = 2154959208;
            
            Console.WriteLine(UInt32ToIP(test));
            Console.ReadKey();
        }
    }
}