using System;
using System.Collections.Generic;
using System.Linq;

namespace Pagination
{
    public class Pagination<T>
    {
        private readonly IEnumerable<T> _sourceCollection;
        private int _currentPage = 1;
        private int _itemsPerPage = 10;

        public IEnumerable<T> Items { get => _sourceCollection.Skip(_itemsPerPage * (_currentPage - 1)).Take(_itemsPerPage); }

        public int CurrentPage
        {
            get => _currentPage;
            set => _currentPage = value <= 0 ? 1 : value;
        }

        public int ItemsPerPage
        {
            get => _itemsPerPage;
            set => _itemsPerPage = value <= 0 ? 10 : value;
        }

        public int Total => _sourceCollection.Count();
        public int TotalPages => (int)Math.Ceiling((double)Total / ItemsPerPage);

        public Pagination(IEnumerable<T> source)
        {
            _sourceCollection = source ?? (IEnumerable<T>)Enumerable.Range(0, 0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pagination = new Pagination<int>(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 });

            var first = pagination.Items.ToList(); // first contains the list 1,2,3,4,5,6,7,8,9,10
            Console.WriteLine("first");
            foreach (var l in first)
                Console.WriteLine(l);

            Console.WriteLine("second");
            pagination.CurrentPage = 2;
            var second = pagination.Items.ToList(); // second contains the list 11,12,13,14,15,16,17,18,19,20
            foreach (var l in second)
                Console.WriteLine(l);

            Console.WriteLine("third");
            pagination.CurrentPage = 3;
            var last = pagination.Items.ToList();  // last contains the list 21,22,23
            foreach(var l in last)
                Console.WriteLine(l);

            Console.WriteLine("total");
            int total = pagination.Total; // total is set to 23
            int pages = pagination.TotalPages; // pages is set to 3

            Console.WriteLine(pagination.Total);
            Console.WriteLine(pagination.TotalPages);

            Console.ReadKey();
        }
    }
}
