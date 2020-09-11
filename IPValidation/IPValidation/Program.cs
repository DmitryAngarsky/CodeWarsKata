using System;
using System.Linq;

namespace IPValidation
{
    class Program
    {
        public static bool is_valid_IP(string ipAddres)
        {
            var arr = ipAddres.Split('.');
            var isEmptyEntries = arr.Where(x => x.Contains(" ")).Count() == 0;
            var isNumber = arr.Where(x => ushort.TryParse(x, out ushort result));
            var isByte = isNumber.Where(x => ushort.Parse(x) < 256).Count() == 4;
            return isNumber.Count() == 4 &&
                   !isNumber.Select(x => byte.TryParse(x, out byte result) && x.Length > 1 ? !x.StartsWith('0') : true).Contains(false) && isByte && isEmptyEntries;
        }

        static void Main(string[] args)
        {
            string test = "12.34.56 .1";

            Console.WriteLine(is_valid_IP(test));
            Console.ReadKey();
        }
    }
}
