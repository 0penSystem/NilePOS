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
