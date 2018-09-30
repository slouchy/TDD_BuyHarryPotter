using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace TDD_BuyHarryPotter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BuyHarryPotter_Buy1TypeBook_ShouldBe100()
        {
            var bookStore = new BookStore();
            int buyBook = bookStore.BuyBook(1);

            var expected = 100;

            Assert.AreEqual(expected, buyBook);
        }

        [TestMethod]
        public void BuyHarryPotter_Buy2TypeBook_ShouldBe195()
        {
            var bookStore = new BookStore();
            int buyBook = bookStore.BuyBook(2);

            var expected = 195;

            Assert.AreEqual(expected, buyBook);
        }
    }
}
