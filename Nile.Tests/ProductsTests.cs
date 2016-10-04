using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nile.Data;

namespace Nile.Tests
{
    [TestClass]
    public class ProductsTests
    {
        [TestMethod]
        public void AddProduct()
        {
            Product expected = new Product("Test", 1, false);

            Products p = new Products();
            p.Add(expected);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddDuplicateIDShouldFail()
        {
            Product expected = new Product("Test", 1, false);

            Products p = new Products();
            p.Add(expected);
            p.Add(expected);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetNegativeIDShouldFail()
        {
            Product expected = new Product("Test", 1, false);

            Products p = new Products();
            p.Add(expected);

            p.Get(-5);
        }

        [TestMethod]
        public void GetNonexistantProductShouldBeNull()
        {
            Products p = new Products();

            var result = p.Get(1);
            Assert.IsNull(result);

        }

        [TestMethod]
        public void GetValidProduct()
        {
            Product expected = new Product("Test", 1, false);
            Products p = new Products();

            p.Add(expected);

            var result = p.Get(expected.ID);

            Assert.AreEqual(result, expected);
            Assert.AreSame(result, expected);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNeedsValidID()
        {
            Product expected = new Product("Test", 1, false);
            Products p = new Products();

            p.Add(expected);

            p.Remove(-10);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveFailsIfProductNotInList()
        {
            Product expected = new Product("Test", 1, false);
            Products p = new Products();

            p.Add(expected);

            p.Remove(10);

        }

        [TestMethod]
        public void RemoveShouldActuallyRemove()
        {
            Product expected = new Product("Test", 1, false);
            Products p = new Products();

            p.Add(expected);

            p.Remove(expected.ID);

            Assert.IsNull(p.Get(expected.ID));
        }

        [TestMethod]
        public void GetAllGetsAll()
        {
            Product a = new Product("A", 1, false);
            Product b = new Product("B", 1, false);
            Product c = new Product("C", 1, false);
            Products p = new Products();

            p.Add(a);
            p.Add(b);
            p.Add(c);

            var all = p.GetAll();
            

            Assert.IsTrue(all.Contains(a));
            Assert.IsTrue(all.Contains(b));
            Assert.IsTrue(all.Contains(c));

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UpdateFailsOnProductNotInList()
        {
            Product expected = new Product("Test", 1, false);
            Product notInList = new Product("Test2", 1, false);
            Products p = new Products();
            
            p.Add(expected);

            p.Update(notInList);
        }

        [TestMethod]
        public void UpdateWorksOnProductInList()
        {
            Product expected = new Product("Test", 1, false);

            Products p = new Products();

            p.Add(expected);

            p.Update(expected);
        }
    }
}
