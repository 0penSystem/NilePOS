using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nile.Data;

namespace Nile.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullNamesShouldThrowException()
        {
            Customer c = new Customer(null, null, null);
        }

        [TestMethod]
        public void ValidNames()
        {
            Customer c = new Customer("Test", "Name", null);
        }

        [TestMethod]
        public void OrderShouldNotBeNull()
        {
            Customer c = new Customer("Test", "Name", null);
            Assert.AreNotEqual(null, c.CurrentOrder);
        }


        [TestMethod]
        public void GetFirstName()
        {
            Customer c = new Customer("Test", "Name", null);
            Assert.AreEqual(c.FirstName, "Test");
        }

        [TestMethod]
        public void SetFirstName()
        {
            Customer c = new Customer("Test", "Name", null);
            c.FirstName = "New";
            Assert.AreEqual(c.FirstName, "New");
        }


        [TestMethod]
        public void GetLastName()
        {
            Customer c = new Customer("Test", "Name", null);
            Assert.AreEqual(c.LastName, "Name");
        }

        [TestMethod]
        public void SetLastName()
        {
            Customer c = new Customer("Test", "Name", null);
            c.LastName = "New";
            Assert.AreEqual(c.LastName, "New");
        }

    }
}
