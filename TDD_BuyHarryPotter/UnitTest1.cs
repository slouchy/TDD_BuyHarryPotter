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
        BookStore _bookStore;

        [TestInitialize]
        public void TeatInit()
        {
            InitBookStore();
        }

        [TestMethod]
        public void BuyHarryPotter_Buy1TypeBook1Book_ShouldBe100()
        {
            Dictionary<int, int> books = new Dictionary<int, int>
            {
                [1] = 1
            };

            TotalPriceShouldBe(100, books);
        }

        [TestMethod]
        public void BuyHarryPotter_Buy1TypeBook2Book_ShouldBe200()
        {
            Dictionary<int, int> books = new Dictionary<int, int>
            {
                [1] = 2
            };

            TotalPriceShouldBe(200, books);
        }

        [TestMethod]
        public void BuyHarryPotter_Buy2TypeBookEach1Book_ShouldBe195()
        {
            Dictionary<int, int> books = new Dictionary<int, int>
            {
                [1] = 1,
                [2] = 1,
            };

            TotalPriceShouldBe(190, books);
        }


        [TestMethod]
        public void BuyHarryPotter_Buy3TypeBookEach1Book_ShouldBe270()
        {
            Dictionary<int, int> books = new Dictionary<int, int>
            {
                [1] = 1,
                [2] = 1,
                [3] = 1,
            };

            TotalPriceShouldBe(270, books);
        }

        [TestMethod]
        public void BuyHarryPotter_Buy4TypeBookEach1Book_ShouldBe320()
        {
            Dictionary<int, int> books = new Dictionary<int, int>
            {
                [1] = 1,
                [2] = 1,
                [3] = 1,
                [4] = 1,
            };

            TotalPriceShouldBe(320, books);
        }

        [TestMethod]
        public void BuyHarryPotter_Buy6TypeBookEach1Book_ShouldBe450()
        {
            Dictionary<int, int> books = new Dictionary<int, int>
            {
                [1] = 1,
                [2] = 1,
                [3] = 1,
                [4] = 1,
                [5] = 1,
                [6] = 1,
            };

            TotalPriceShouldBe(450, books);
        }

        [TestMethod]
        public void BuyHarryPotter_Buy6TypeBookEach2Book_ShouldBe900()
        {
            Dictionary<int, int> books = new Dictionary<int, int>
            {
                [1] = 2,
                [2] = 2,
                [3] = 2,
                [4] = 2,
                [5] = 2,
                [6] = 2,
            };

            TotalPriceShouldBe(900, books);
        }

        [TestMethod]
        public void BuyHarryPotter_Buy0TypeBookEach0Book_ShouldBe0()
        {
            Dictionary<int, int> books = new Dictionary<int, int>();

            TotalPriceShouldBe(0, books);
        }

        private void InitBookStore()
        {
            _bookStore = new BookStore();
        }

        private void TotalPriceShouldBe(int totalPrice, Dictionary<int, int> books)
        {
            Assert.AreEqual(totalPrice, _bookStore.BuyBook(books));
        }
    }
}