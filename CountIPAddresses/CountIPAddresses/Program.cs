using System;
using System.Linq;

namespace CountIPAddresses
{
    class Program
    {
        public static long IpsBetween(string start, string end)
        {
            //start.Split('.').Zip(end.Split('.'), (s,e) => int.Parse(e) - int.Parse(s)).Aggregate(0, (a,b) => (a << 8) + b);
            //private static long ToNum(string ip) => ip.Split('.').Aggregate(0, (a, b) => (a << 8) | int.Parse(b));
            long GetDec(string ip) => BitConverter.ToInt32(ip.Split('.').Select(a => byte.Parse(a)).Reverse().ToArray(), 0);
            return GetDec(end) - GetDec(start);
        }

        static void Main(string[] args)
        {
            string start = "20.0.0.10";
            string end = "20.0.1.0";

            Console.WriteLine(IpsBetween(start, end));
            Console.ReadKey();
        }
    }
}
