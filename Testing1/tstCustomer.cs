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
            Int32 TestData = 1001;
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

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerNo = 1001;
            Found = AnCustomer.Find(CustomerNo);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1001;
            Found = AnCustomer.Find(CustomerNo);
            if (AnCustomer.CustomerNo != 1001)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1001;
            Found = AnCustomer.Find(CustomerNo);
            if(AnCustomer.CustomerName != "Daniel Hatel")
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1001;
            Found = AnCustomer.Find(CustomerNo);
            if(AnCustomer.CustomerEmail != "daniel.hatel@yahoo.com                            ")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1001;
            Found = AnCustomer.Find(CustomerNo);
            if(AnCustomer.CustomerAddress != "Not here, NG8 5LH")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateJoinedFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1001;
            Found = AnCustomer.Find(CustomerNo);
            if (AnCustomer.CustomerDateJoined != Convert.ToDateTime("01/01/2000"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerConfirmedFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1001;
            Found = AnCustomer.Find(CustomerNo);
            if(AnCustomer.CustomerConfirmed != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
                
        }

    }


}