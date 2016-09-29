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
            Product p = new Product("A Thing", 1, false);
            //LineItem l = new LineItem(p, 1);
            // o.AddLineItem(l);
            o.Complete();
        }
    }
}
