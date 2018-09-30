using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_BuyHarryPotter
{
    public class BookStore
    {
        private const int _bookPrice = 100;
        private Dictionary<int, double> _discountLookup = new Dictionary<int, double>
        {
            [1] = 1,
            [2] = 0.95,
            [3] = 0.9,
            [4] = 0.8,
            [5] = 0.75
        };

        static void Main() { }
        public int BuyBook(Dictionary<int, int> books)
        {
            var discountPriceBooksTotal = books.Count();
            var bookTypeCount = books.Count();
            var orignPriceBooksTotal = books.Sum(r =>
            {
                return r.Value > 1 ? r.Value - 1 : 0;
            });

            if (bookTypeCount > 5)
            {
                bookTypeCount = 5;
            }

            var bookDiscount = _discountLookup[bookTypeCount];
            return (int)(discountPriceBooksTotal * _bookPrice * bookDiscount + orignPriceBooksTotal * _bookPrice);
        }
    }
}
