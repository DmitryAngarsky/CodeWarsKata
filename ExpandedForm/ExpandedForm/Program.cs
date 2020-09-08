using System;
using System.Linq;

namespace ExpandedForm
{
    class Program
    {
        public static string ExpandedForm(long num)
        {
            //First solution
            //var expForm = string.Concat($"{num}".ToCharArray()
            //                                .Select((x, i) => string.Concat(x + new string('0', $"{num}".Count() - 1 - i) + " + "))
            //                                .Where(x => !x.StartsWith('0')));

            //return string.Concat(expForm).Remove(expForm.Length - 3);

            //Refactoring
            var expForm = $"{num}".Select((x, i) => x + new string('0', $"{num}".Length - 1 - i))
                                  .Where(x => !x.StartsWith('0'));

            return string.Join(" + ", expForm);
        }

        static void Main(string[] args)
        {
            long test = 70302;

            Console.WriteLine(ExpandedForm(test));
            Console.ReadKey();
        }
    }
    
}
