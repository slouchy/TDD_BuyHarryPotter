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
            return bookCount * _bookPrice;
        }
    }
}
