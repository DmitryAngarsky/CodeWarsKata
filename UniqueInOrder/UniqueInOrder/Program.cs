using System;
using System.Collections.Generic;

namespace UniqueInOrder
{
    class Program
    {

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            T previous = default(T);
            foreach (T current in iterable)
            {
                if (!current.Equals(previous))
                {
                    previous = current;
                    yield return current;
                }
            }
        }

        //List<T> list = new List<T>();

        //    foreach(T element in iterable)
        //    {
        //        if (!list.Contains(element))
        //        {
        //            list.Add(element);
        //        } else if(list.LastIndexOf(element) != list.Count - 1) {
        //            list.Add(element);
        //        }
        //    }

        //    return list;
        //}

        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("1");
            list.Add("2");
            list.Add("2");
            list.Add("2");
            list.Add("3");
            list.Add("3");
            list.Add("3");

            //var test = UniqueInOrder(test);

            string test = "AAAABBBCCDAABBB";
            var iter = UniqueInOrder(test);
            foreach (var elem in iter)
            {
                Console.WriteLine(elem);
            }
            Console.ReadKey();
        }
    }
}
