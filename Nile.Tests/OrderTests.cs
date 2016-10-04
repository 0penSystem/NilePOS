using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nile.Data;

namespace Nile.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void SetOrderDate()
        {
            Order o = new Order();
            o.OrderDate = DateTime.MaxValue;
            Assert.AreEqual(o.OrderDate, DateTime.MaxValue);
        }

        [TestMethod]
        public void CompleteWorks()
        {
            Order o = new Order();
            Product p = new Product("A Thing", 1, false);
            LineItem l = new LineItem(p, 1);
            o.AddLineItem(l);
            o.Complete();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNullLineItemFails()
        {
            Order o = new Order();
            o.AddLineItem(null);
        }

        [TestMethod]
        public void TotalPrice()
        {
            Order o = new Order();
            Product p1 = new Product("Product A", 1m, false);
            Product p2 = new Product("Product B", 2m, false);
            LineItem l1 = new LineItem(p1, 1);
            LineItem l2 = new LineItem(p2, 1);
            o.AddLineItem(l1);
            o.AddLineItem(l2);

            Assert.AreEqual(3, o.TotalPrice);

        }

        [TestMethod]
        public void TotalPriceWhenEmptyIsZero()
        {
            Order o = new Order();

            Assert.AreEqual(0, o.TotalPrice);

        }


        [TestMethod]

        [ExpectedException(typeof(Exception))]
        public void NullListThrowsException()
        {
            Order o = new Order();
            var a = o.LineItems;
        }


        [TestMethod]

        [ExpectedException(typeof(Exception))]
        public void AddToCompleteOrderFails()
        {
            Order o = new Order();
            Product p = new Product("A Thing", 1, false);
            LineItem l = new LineItem(p, 1);
            LineItem l2 = new LineItem(p, 1);
            o.AddLineItem(l);
            o.Complete();
            o.AddLineItem(l2);
        }

        [TestMethod]
        
        public void MultipleSameProductsStack()
        {
            Order o = new Order();
            Product p = new Product("A Thing", 1, false);
            LineItem l = new LineItem(p, 1);
            LineItem l2 = new LineItem(p, 1);
            o.AddLineItem(l);
            o.AddLineItem(l2);            
            Assert.AreEqual(o.LineItems.Count, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CompleteTwiceFails()
        {
            Order o = new Order();
            Product p = new Product("A Thing", 1, false);
            LineItem l = new LineItem(p, 1);
            o.AddLineItem(l);
            o.Complete();
            o.Complete();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CompleteFailsWithNoLineItems()
        {
            Order o = new Order();
            o.Complete();
        }
    }
}
