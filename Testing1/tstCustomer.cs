using ClassLibrary;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;



namespace TestingCustomer
{

    [TestClass]
    public class tstCustomer
    {
        string CustomerNo = "1001";
        string CustomerName = "Daniel Hatel";
        string CustomerEmail = "daniel.hatel@yahoo.com";
        string CustomerAddress = "Not here, NG8 5LH";
        string CustomerDateJoined = DateTime.Now.Date.ToString();
        Boolean CustomerConfirmed = true;


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
            if (AnCustomer.CustomerName != "Daniel Hatel")
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
            if (AnCustomer.CustomerEmail != "daniel.hatel@yahoo.com")
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
            if (AnCustomer.CustomerAddress != "Not here, NG8 5LH")
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
            if (AnCustomer.CustomerDateJoined != Convert.ToDateTime("20/06/2022"))
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
            if (AnCustomer.CustomerConfirmed != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";

            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "a";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "aa";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(249, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(250, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(250, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(251, 'a');  //this should fail
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a'); //this should fail
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "a";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "aa";
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(249, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(250, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(250, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(251, 'a');  //this should fail
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(500, 'a'); //this should fail
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerDateJoinedExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);

            string CustomerDateJoined = TestDate.ToString();

            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateJoinedMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(-1);

            string CustomerDateJoined = TestDate.ToString();

            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateJoinedMin()
        {
            clsCustomer AnCustomer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            string CustomerDateJoined = TestDate.ToString();

            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateJoinedPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(1);

            string CustomerDateJoined = TestDate.ToString();

            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateJoinedExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);

            string CustomerDateJoined = TestDate.ToString();

            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateJoinedInvalidData()
        {
            clsCustomer AnCustomer = new clsCustomer();

            String Error = "";

            string CustomerDateJoined = "This is not a date!";

            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();

            String Error = "";

            String CustomerAddress = "";

            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            clsCustomer AnCustomer = new clsCustomer();

            String Error = "";

            String CustomerAddress = "a";

            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();

            String Error = "";

            String CustomerAddress = "aa";

            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();

            String Error = "";

            String CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(249, 'a');

            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            clsCustomer AnCustomer = new clsCustomer();

            String Error = "";

            String CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(250, 'a');

            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();

            String Error = "";

            String CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(251, 'a');

            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            clsCustomer AnCustomer = new clsCustomer();

            String Error = "";

            String CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(125, 'a');

            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);

            Assert.AreEqual(Error, "");
        }

    }

}