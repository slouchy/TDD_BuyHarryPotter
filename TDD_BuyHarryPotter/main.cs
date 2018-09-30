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

        static void Main() { }
        public int BuyBook(Dictionary<int, int> books)
        {
            if (books.Count() == 2)
            {
                return (int)(books[1] * _bookPrice * 0.95 + books[2] * _bookPrice * 0.95);
            }

            return books[1] * _bookPrice;
        }
    }
}
