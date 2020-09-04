using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CrackThePIN
{
    class Program
    {
        //My solution
        
        //public static string crack(string hash)
        //{
        //    MD5 md5 = new MD5CryptoServiceProvider();
        //    string result = "dcddb75469b4b4875094e14561e573d8";
        //    byte[] checkSum;
        //    int n = 0;
        //    string randomPin = "00000";

        //    while (hash != result)
        //    {
        //        n += 1;
        //        randomPin = $"{n}";
        //        if (randomPin.Length < 5 )
        //        {
        //            randomPin = new string('0', 5 - $"{n}".Length) + $"{n}";
        //        }

        //        checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(randomPin));
        //        result = BitConverter.ToString(checkSum).Replace("-", string.Empty).ToLower();
        //    }

        //    return randomPin;
        //}
        public static string crack(string h) => Enumerable.Range(0, 99999)
                                                          .Select(n => $"{n:00000}")
                                                          .First(i => h == string.Concat(MD5.Create()
                                                                                 .ComputeHash(Encoding.ASCII.GetBytes(i))
                                                                                 .Select(x => x.ToString("x2"))));

        static void Main(string[] args)
        {
            string test = "827ccb0eea8a706c4c34a16891f84e7b";

            Console.WriteLine(crack(test));
            Console.ReadKey();
        }
    }

}
