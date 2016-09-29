using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nile.Data;

namespace Nile.Tests
{
    [TestClass]
    public class CustomersTests
    {
        [TestMethod]
        public void AddCustomer()
        {
            Customer expected = new Customer("Alice", "Baker", null);

            Customers c = new Customers();
            c.Add(expected);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddDuplicateIDShouldFail()
        {
            Customer expected = new Customer("Alice", "Baker", null);

            Customers c = new Customers();
            c.Add(expected);
            c.Add(expected);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetNegativeIDShouldFail()
        {
            Customer expected = new Customer("Alice", "Baker", null);

            Customers c = new Customers();
            c.Add(expected);

            c.Get(-5);
        }

        [TestMethod]
        public void GetNonexistantCustomerShouldBeNull()
        {
            Customers c = new Customers();

            var result = c.Get(1);
            Assert.IsNull(result);

        }

        [TestMethod]
        public void GetValidCustomer()
        {

            Customer expected = new Customer("Alice", "Baker", null);
            Customers c = new Customers();

            c.Add(expected);

            var result = c.Get(expected.ID);

            Assert.AreEqual(result, expected);
            Assert.AreSame(result, expected);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNeedsValidID()
        {

            Customer expected = new Customer("Alice", "Baker", null);
            Customers c = new Customers();

            c.Add(expected);

            c.Remove(-10);

        }

        [TestMethod]
        public void RemoveShouldActuallyRemove()
        {
            Customer expected = new Customer("Alice", "Baker", null);
            Customers c = new Customers();

            c.Add(expected);

            c.Remove(expected.ID);

            Assert.IsNull(c.Get(expected.ID));
        }

        [TestMethod]
        public void GetAllGetsAll()
        {
            Customer alice = new Customer("Alice", "Baker", null);
            Customer bob = new Customer("Bob", "Baker", null);
            Customer third = new Customer("Third", "Party", null);
            Customers c = new Customers();

            c.Add(alice);
            c.Add(bob);
            c.Add(third);

            var all = c.GetAll();

            Assert.IsTrue(all.Contains(alice));
            Assert.IsTrue(all.Contains(bob));
            Assert.IsTrue(all.Contains(third));

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UpdateFailsOnCustomerNotInList()
        {
            Customer alice = new Customer("Alice", "Baker", null);

            Customer bob = new Customer("Bob", "Baker", null);
            Customers c = new Customers();
            
            c.Add(alice);

            c.Update(bob);
        }

        [TestMethod]
        public void UpdateWorksOnCustomerInList()
        {
            Customer alice = new Customer("Alice", "Baker", null);
            
            Customers c = new Customers();

            c.Add(alice);

            c.Update(alice);
        }
    }
}
