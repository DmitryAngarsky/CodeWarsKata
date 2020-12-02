using System;
using System.Linq;

namespace ComplementaryDNA
{
    class Program
    {
        public static string MakeComplement(string dna)
        {
            return string.Concat(dna.Select(c => c switch
            {
                'A' => 'T',
                'T' => 'A',
                'G' => 'C',
                'C' => 'G',
                _ => c
            }));
            return string.Concat(dna.Select(c => "AGCT"["TCGA".IndexOf(c)]));
        }
        
        static void Main(string[] args)
        {
            string test = "TAACG";
            
            Console.WriteLine(MakeComplement(test));
            Console.ReadKey();
        }
    }
}