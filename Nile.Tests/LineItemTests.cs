using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nile.Data;

namespace Nile.Tests
{
    [TestClass]
    public class LineItemTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullProductShouldFail()
        {
            LineItem l = new LineItem(null, 1);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DiscontinuedProductShouldFail()
        {
            LineItem l = new LineItem(new Product("a", 1m, true), 1);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeQuantityShouldFail()
        {
            LineItem l = new LineItem(new Product("a", 1m, false), -4);

        }

        [TestMethod]
        public void TotalPrice()
        {
            LineItem l = new LineItem(new Product("a", 5m, false), 10);

            Assert.AreEqual(50m, l.TotalPrice);
        }


        [TestMethod]
        public void SetProduct()
        {
            LineItem l = new LineItem(new Product("a", 1m, false), 1);
            Product expectedProduct = new Product("Expected", 1m, false);
            l.Product = expectedProduct;

            Assert.AreEqual(l.Product, expectedProduct);
        }

        [TestMethod]
        public void GetProduct()
        {

            Product expectedProduct = new Product("Expected", 1m, false);
            LineItem l = new LineItem(expectedProduct, 1);

            Assert.AreEqual(l.Product, expectedProduct);
        }

        [TestMethod]
        public void SetQuantity()
        {
            Product expectedProduct = new Product("Expected", 1m, false);
            LineItem l = new LineItem(expectedProduct, 1);
            int expected = 5;

            l.Quantity = expected;

            Assert.AreEqual(l.Quantity, expected);

        }


        [TestMethod]
        public void GetQuantity()
        {
            Product expectedProduct = new Product("Expected", 1m, false);
            int expected = 5;

            LineItem l = new LineItem(expectedProduct, expected);


            Assert.AreEqual(l.Quantity, expected);

        }


    }
}
