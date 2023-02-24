using ClassLibrary;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;



namespace TestingCustomer
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //rest to see that it exists 
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some tesst data to assign to the property 
            Int32 TestData = 1000;
            //assign the data to the property 
            AnCustomer.CustomerNo = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.CustomerNo, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some tesst data to assign to the property 
            string TestData = "name";
            //assign the data to the property 
            AnCustomer.CustomerName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some tesst data to assign to the property 
            string TestData = "email";
            //assign the data to the property 
            AnCustomer.CustomerEmail = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some tesst data to assign to the property 
            string TestData = "address";
            //assign the data to the property 
            AnCustomer.CustomerAddress = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.CustomerAddress, TestData);
        }

        [TestMethod]
        public void CustomerDateJoinedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some tesst data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AnCustomer.CustomerDateJoined = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.CustomerDateJoined, TestData);
        }

        [TestMethod]
        public void CustomerConfirmedPropertyOK()
        {
            //crate an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data 
            Boolean TestData = true;
            //assign the dara to the property 
            AnCustomer.CustomerConfirmed = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(AnCustomer.CustomerConfirmed, TestData);
        }

    }

}