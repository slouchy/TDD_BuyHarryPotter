using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_BuyHarryPotter
{
    public class BookStore
    {
        static void Main() { }

        private int _bookPrice = 100;
        private Dictionary<int, double> _discountLookup = new Dictionary<int, double>
        {
            [1] = 1,
            [2] = 0.95,
            [3] = 0.9,
            [4] = 0.8,
            [5] = 0.75
        };

        internal int BuyBook(Dictionary<int, int> books)
        {
            double bookDiscount = 0.75;
            var bookTotalCount = books.Sum(r => r.Value);
            if (books.Count() < 6)
            {
                bookDiscount = _discountLookup[books.Count()];
            }

            return (int)(bookTotalCount * _bookPrice * bookDiscount);
        }
    }
}
