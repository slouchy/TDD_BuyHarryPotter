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
            var bookSum = books.Sum(r => r.Value);
            var bookDiscount = _discountLookup[books.Count()];
            return (int)(bookSum * _bookPrice * bookDiscount);
        }
    }
}
