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

        [TestMethod]
        public void BuyBook_TwotypeOneBook_ShouldBe190()
        {
            var bookStroe = new BookStore();
            int exceptedPrice = 190;

            int actuallPrice = bookStroe.BuyBook(new Dictionary<int, int>
            {
                [1] = 1,
                [2] = 1,
            });

            Assert.AreEqual(exceptedPrice, actuallPrice);
        }

        [TestMethod]
        public void BuyBook_ThreetypeOneBook_ShouldBe270()
        {
            var bookStroe = new BookStore();
            int exceptedPrice = 270;

            int actuallPrice = bookStroe.BuyBook(new Dictionary<int, int>
            {
                [1] = 1,
                [2] = 1,
                [3] = 1,
            });

            Assert.AreEqual(exceptedPrice, actuallPrice);
        }

        [TestMethod]
        public void BuyBook_SixtypeSixBook_ShouldBe450()
        {
            var bookStroe = new BookStore();
            int exceptedPrice = 450;

            int actuallPrice = bookStroe.BuyBook(new Dictionary<int, int>
            {
                [1] = 1,
                [2] = 1,
                [3] = 1,
                [4] = 1,
                [5] = 1,
                [6] = 1
            });

            Assert.AreEqual(exceptedPrice, actuallPrice);
        }

        [TestMethod]
        public void BuyBook_TwotypeThreeBook_ShouldBe290()
        {
            var bookStroe = new BookStore();
            int exceptedPrice = 290;

            int actuallPrice = bookStroe.BuyBook(new Dictionary<int, int>
            {
                [1] = 2,
                [2] = 1
            });

            Assert.AreEqual(exceptedPrice, actuallPrice);
        }

        [TestMethod]
        public void BuyBook_ThreetypeFiveBook_ShouldBe470()
        {
            var bookStroe = new BookStore();
            int exceptedPrice = 470;

            int actuallPrice = bookStroe.BuyBook(new Dictionary<int, int>
            {
                [1] = 2,
                [2] = 1,
                [3] = 2
            });

            Assert.AreEqual(exceptedPrice, actuallPrice);
        }

        [TestMethod]
        public void BuyBook_SixtypeTwoBook_ShouldBe1050()
        {
            var bookStroe = new BookStore();
            int exceptedPrice = 1050;

            int actuallPrice = bookStroe.BuyBook(new Dictionary<int, int>
            {
                [1] = 2,
                [2] = 2,
                [3] = 2,
                [4] = 2,
                [5] = 2,
                [6] = 2
            });

            Assert.AreEqual(exceptedPrice, actuallPrice);
        }
    }
}
