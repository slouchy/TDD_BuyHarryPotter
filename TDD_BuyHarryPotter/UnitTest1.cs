﻿using System;
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
        public void BuyHarryPotter_Buy2TypeBookEach1Book_ShouldBe195()
        {
            Dictionary<int, int> books = new Dictionary<int, int>
            {
                [1] = 1,
                [2] = 1,
            };

            TotalPriceShouldBe(195, books);
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
