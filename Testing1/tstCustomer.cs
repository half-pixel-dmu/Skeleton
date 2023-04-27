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
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerNo = 1001;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1001;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the property
            if (AnCustomer.CustomerNo != 1001)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1001;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the property
            if (AnCustomer.CustomerName != "Daniel Hatel")
            {
                OK = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1001;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the property
            if (AnCustomer.CustomerEmail != "daniel.hatel@yahoo.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1001;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the property
            if (AnCustomer.CustomerAddress != "Not here, NG8 5LH")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateJoinedFound()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1001;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the property
            if (AnCustomer.CustomerDateJoined != Convert.ToDateTime("20/06/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerConfirmedFound()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1001;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the property
            if (AnCustomer.CustomerConfirmed != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            string CustomerName = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "a";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            //this should pass
            string CustomerName = "aa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(249, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(250, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(250, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(251, 'a');  //this should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerEmail = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "a";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "aa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(249, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(250, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(250, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(251, 'a');  //this should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerDateJoinedExtremeMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string CustomerDateJoined = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateJoinedMinLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus one day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string CustomerDateJoined = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateJoinedMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string CustomerDateJoined = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateJoinedPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string CustomerDateJoined = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateJoinedExtremeMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string CustomerDateJoined = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateJoinedInvalidData()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerDateJoined = "This is not a date!";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String CustomerAddress = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String CustomerAddress = "a";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String CustomerAddress = "aa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(249, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(250, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(251, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(125, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerAddress, CustomerDateJoined);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

    }
    
}

