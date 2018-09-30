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
            return books[1] * _bookPrice;            
        }
    }
}
