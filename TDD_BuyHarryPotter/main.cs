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
        private double _discount = 0.95;

        static void Main() { }
        public int BuyBook(Dictionary<int, int> books)
        {
            if (books.Count() == 2)
            {
                var bookSum = books.Sum(r => r.Value);
                return (int)(bookSum * _bookPrice * _discount);
            }

            return books[1] * _bookPrice;
        }
    }
}
