using System;
using System.Linq;

namespace RailFenceCipher
{
    class Program
    {
        public static string Encode(string s, int n)
        {
            var mod = (n - 1) * 2;
            return string.Concat(s.Select((c, i) => new { c, i }).OrderBy(a => Math.Min(a.i % mod, mod - a.i % mod)).Select(a => a.c));
        }

        public static string Decode(string s, int n)
        {
            var mod = (n - 1) * 2;
            var pattern = Enumerable.Range(0, s.Length).OrderBy(i => Math.Min(i % mod, mod - i % mod));
            return string.Concat(s.Zip(pattern, (c, i) => new { c, i }).OrderBy(a => a.i).Select(a => a.c));
        }

        //      public static string Encode(string s, int n) =>
        //string.Concat(railPat(s, n).Zip(s, (rail, c) => (rail, c)).OrderBy(t => t.rail).Select(t => t.c));

        //      public static string Decode(string s, int n) =>
        //        string.Concat(railPat(s, n).Select((x, i) => (x, i)).OrderBy(t => t.x).Zip(s, (t, c) => (t.i, c)).OrderBy(t => t).Select(t => t.c));

        //      private static int[] railPat(string s, int n)
        //      {
        //          var rIDs = new int[s.Length];
        //          for (int i = 0, dir = -1, cur = 0; i < s.Length; rIDs[i++] = cur, cur += dir)
        //              if (cur == 0 || cur == n - 1) dir *= -1;
        //          return rIDs;
        //      }

      //  public static string Encode(string s, int n)
      //=> s.Zip(GetLevel(n), (letter, level) => (letter, level))
      //        .OrderBy(x => x.level)
      //        .Select(x => x.letter)
      //        .Aggregate("", (current, next) => current + next);

      //  public static string Decode(string s, int n)
      //   => s.Zip(GetLevel(n), (letter, level) => (letter, level))
      //       .Select((x, index) => (x.letter, x.level, index))
      //       .OrderBy(x => x.level)
      //       .Zip(s, (x, letter) => (letter, x.index))
      //       .OrderBy(x => x.index)
      //       .Select(x => x.letter)
      //       .Aggregate("", (current, next) => current + next);

      //  private static IEnumerable<int> GetLevel(int n)
      //  {
      //      while (true)
      //      {
      //          foreach (var item in Enumerable.Range(0, n).Concat(Enumerable.Range(1, n - 2).Reverse())) yield return item;
      //      }
      //  }
        //public static string Encode(string s, int n)
        //{
        //    string[] result = new string[n];
        //    int pointer = 0;
        //    bool isDownDirection = true;

        //    while(pointer < s.Length)
        //    {
        //        if (isDownDirection)
        //        {
        //            for (int i = 0; i < n - 1; i++)
        //            {
        //                if(pointer == s.Length)
        //                {
        //                    break;
        //                }

        //                result[i] += s[pointer];
        //                pointer++;

        //                if(i == n - 2)
        //                {
        //                    isDownDirection = false;
        //                }
        //            }
        //        } else
        //        {
        //            for (int i = n - 1; i > 0; i--)
        //            {
        //                if (pointer == s.Length)
        //                {
        //                    break;
        //                }

        //                result[i] += s[pointer];
        //                pointer++;

        //                if(i == 1)
        //                {
        //                    isDownDirection = true;
        //                }
        //            }
        //        }
        //    }

        //    return string.Join("", result);
        //}

        //public static string Decode(string s, int n)
        //{
        //    char[] decrypted = new char[s.Length];
        //    int p = 0;

        //    for (int k = 0; k < n; k++)
        //    {
        //        int index = k;
        //        bool down = true;
        //        while (index < s.Length)
        //        {
        //            decrypted[index] = s[p++];

        //            if (k == 0 || k == n - 1)
        //            {
        //                index = index + 2 * (n - 1);
        //            }
        //            else if (down)
        //            {
        //                index = index + 2 * (n - k - 1);
        //                down = !down;
        //            }
        //            else
        //            {
        //                index = index + 2 * k;
        //                down = !down;
        //            }
        //        }
        //    }
        //    return new String(decrypted);
        //}

        static void Main(string[] args)
        {
            string test1 = "WEAREDISCOVEREDFLEEATONCE";
            string test2 = "H !e,Wdloollr";

            Console.WriteLine(Encode(test1, 3));
            Console.WriteLine(Decode(test2, 4));
            Console.ReadKey();
        }
    }

}
