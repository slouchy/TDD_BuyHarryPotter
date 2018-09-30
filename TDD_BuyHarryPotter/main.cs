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

        internal int BuyBook(int bookCount)
        {
            if (bookCount == 2)
            {
                return (int)(1 * _bookPrice + 1 * _bookPrice * 0.95);
            }

            return bookCount * _bookPrice;
        }
    }
}
