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
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Int32 OrderNo = 24;

            Found = AnOrder.Find(OrderNo);

            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean Ok = true;
            //create a test
            Int32 OrderNo = 21;
            //Invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the Order no
            if (AnOrder.OrderNo != 21)
            {
                Ok = false;
            }
            //check if the test is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //Invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.CustomerNo !=  21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //Invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }        
        //test to see that the result is correct
        Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //Invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.ProductId != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //Invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderPrice != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderStatusFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 21;
            //Invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderStatus != "Test Status")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }

}
