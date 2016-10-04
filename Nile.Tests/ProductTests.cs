using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nile.Data;

namespace Nile.Tests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameCannotBeNull()
        {
            Product p = new Product(null, 1m, false);
        }

        [TestMethod]
        public void getName()
        {
            Product p = new Product("Test", 1m, false);
            Assert.AreEqual(p.Name, "Test");
        }

        [TestMethod]
        public void setName()
        {
            Product p = new Product("Test", 1m, false);
            p.Name = "Test2";
            Assert.AreEqual(p.Name, "Test2");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void setNameErrorsOnNull()
        {
            Product p = new Product("Test", 1m, false);
            p.Name = null;
        }


        [TestMethod]
        public void getPrice()
        {
            Product p = new Product("Test", 1m, false);
            Assert.AreEqual(1m, p.UnitPrice);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void setPriceErrorsLessThan0()
        {
            Product p = new Product("Test", 1m, false);
            p.UnitPrice = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UnitPriceMustBePositive()
        {
            Product p = new Product("Test", 0m, false);
        }

        [TestMethod]
        public void ValidConstructorTest()
        {
            Product p = new Product("Test", 1m, false);
        }

    }
}
