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




    }
}
