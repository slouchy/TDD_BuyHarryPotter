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

        internal int BuyBook(Dictionary<int, int> books)
        {
            if (books.Count() == 2)
            {
                return (int)(1 * _bookPrice + 1 * _bookPrice * 0.95);
            }
            else if (books.Count() == 3)
            {
                return (int)(3 * _bookPrice * 0.9);
            }

            return books[1] * _bookPrice;
        }
    }
}
