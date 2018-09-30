using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace TDD_BuyHarryPotter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BuyBook_OnetypeOneBook_ShouldBe100()
        {
            var bookStroe = new BookStore();
            int exceptedPrice = 100;

            int actuallPrice = bookStroe.BuyBook(new Dictionary<int, int>
            {
                [1] = 1
            });

            Assert.AreEqual(exceptedPrice, actuallPrice);
        }

        [TestMethod]
        public void BuyBook_OnetypeTwoBook_ShouldBe200()
        {
            var bookStroe = new BookStore();
            int exceptedPrice =200;

            int actuallPrice = bookStroe.BuyBook(new Dictionary<int, int>
            {
                [1] = 2,
            });

            Assert.AreEqual(exceptedPrice, actuallPrice);
        }
    }
}
