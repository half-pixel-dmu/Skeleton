using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingOrder
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder anOrder = new clsOrder();

            Assert.IsNotNull(anOrder);
        }

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            clsOrder anOrder = new clsOrder();

            int number = 1;

            anOrder.OrderNo = number;

            Assert.AreEqual(anOrder.OrderNo, number);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            clsOrder anOrder = new clsOrder();

            int number = 1;

            anOrder.CustomerNo = number;

            Assert.AreEqual(anOrder.CustomerNo, number);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder anOrder = new clsOrder();

            DateTime testDate = DateTime.Now.Date;

            anOrder.OrderDate = testDate;

            Assert.AreEqual(anOrder.OrderDate, testDate);
        }

        [TestMethod]
        public void ProductIdPropertyOK()
        {
            clsOrder anOrder = new clsOrder();

            int number = 1;

            anOrder.ProductId = number;

            Assert.AreEqual(anOrder.ProductId, number);
        }

        [TestMethod]
        public void OrderPricePropertyOK()
        {
            clsOrder anOrder = new clsOrder();

            int number = 1;

            anOrder.OrderPrice = number;

            Assert.AreEqual(anOrder.OrderPrice, number);

        }
        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            clsOrder anOrder = new clsOrder();

            string description = "Status pending";

            anOrder.OrderStatus = description;

            Assert.AreEqual(anOrder.OrderStatus, description);

        }
    }
}
