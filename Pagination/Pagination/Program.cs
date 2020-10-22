using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Pagination
{
    public class Pagination<T>
    {
        private readonly IEnumerable<T> _sourceCollection;
        private int _currentPage = 1;
        private int _itemsPerPage = 10;

        public IEnumerable<T> Items { get; }

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
            var p = new Pagination<int>(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 });

            Console.WriteLine(p.TotalPages);
            Console.ReadKey();
        }
    }
}
