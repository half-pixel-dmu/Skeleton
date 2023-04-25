using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass to the method
        string StaffNo = "8";
        string StaffName = "Alex";
        string StaffEmail = "Alex@email.com";
        string StaffDate = DateTime.Now.Date.ToString();
        string ProductNo = "2";
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //test to see if it exists
            Assert.IsNotNull(Staff);
        }

        [TestMethod]
        public void StaffNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to asign to the property
            Int32 TestData = 8;
            //assign the data to the property
            Staff.StaffNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffNo, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //see above test for comments
            clsStaff Staff = new clsStaff();

            string TestData = "Alex";

            Staff.StaffName = TestData;

            Assert.AreEqual(Staff.StaffName, TestData);
        }

        [TestMethod]
        public void StaffEmailPropertyOK()
        {
            //see above test for comments
            clsStaff Staff = new clsStaff();

            string TestData = "Alex@email.com";

            Staff.StaffEmail = TestData;

            Assert.AreEqual(Staff.StaffEmail, TestData);
        }

        [TestMethod]
        public void StaffAvailabilityPropertyOK()
        {
            //see above test for comments
            clsStaff Staff = new clsStaff();

            Boolean TestData = true;

            Staff.StaffAvailability = TestData;

            Assert.AreEqual(Staff.StaffAvailability, TestData);
        }

        [TestMethod]
        public void StaffDatePropertyOK()
        {
            //see above test for comments
            clsStaff Staff = new clsStaff();

            DateTime TestData = DateTime.Now.Date;

            Staff.StaffDate = TestData;

            Assert.AreEqual(Staff.StaffDate, TestData);
        }

        [TestMethod]
        public void ProductNoPropertyOK()
        {
            //see above test for comments
            clsStaff Staff = new clsStaff();

            Int32 TestData = 2;

            Staff.ProductNo = TestData;

            Assert.AreEqual(Staff.ProductNo, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create instance of class
            clsStaff AStaff = new clsStaff();
            //boolean to store the result of validation
            Boolean Found = false;
            //create the test data for the method
            Int32 StaffNo = 8;
            //invoke method
            Found = AStaff.Find(StaffNo);
            //test to see if true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestStaffNoFound()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable
            Boolean Found = false;
            //Boolean to record data
            Boolean OK = true;
            //test data
            Int32 StaffNo = 8;
            //invoke method
            Found = AStaff.Find(StaffNo);
            //check the staff no
            if (AStaff.StaffNo != 8)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStaffDateFound()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable
            Boolean Found = false;
            //Boolean to record data
            Boolean OK = true;
            //test data
            Int32 StaffNo = 8;
            //invoke method
            Found = AStaff.Find(StaffNo);
            //check the staff no
            if (AStaff.StaffDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStaffEmailFound()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable
            Boolean Found = false;
            //Boolean to record data
            Boolean OK = true;
            //test data
            Int32 StaffNo = 8;
            //invoke method
            Found = AStaff.Find(StaffNo);
            //check the staff no
            if (AStaff.StaffEmail != "Alex@email.com")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStaffAvailabilityFound()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable
            Boolean Found = false;
            //Boolean to record data
            Boolean OK = true;
            //test data
            Int32 StaffNo = 8;
            //invoke method
            Found = AStaff.Find(StaffNo);
            //check the staff no
            if (AStaff.StaffAvailability != true)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestProductNoFound()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable
            Boolean Found = false;
            //Boolean to record data
            Boolean OK = true;
            //test data
            Int32 StaffNo = 8;
            //invoke method
            Found = AStaff.Find(StaffNo);
            //check the staff no
            
            if (AStaff.ProductNo != 2)
            {
                OK = false;
            }
            
            //test to see if result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable
            Boolean Found = false;
            //Boolean to record data
            Boolean OK = true;
            //test data
            Int32 StaffNo = 8;
            //invoke method
            Found = AStaff.Find(StaffNo);
            //check the staff no
            if (AStaff.StaffName != "Alex")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = "a"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method++
            string StaffName = "aa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = ""; //this should trigger an error
            StaffName = StaffName.PadRight(99, 'a'); //this should pass
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = ""; //this should trigger an error
            StaffName = StaffName.PadRight(100, 'a'); //this should pass
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = ""; //this should trigger an error
            StaffName = StaffName.PadRight(101, 'a'); //this should pass
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = ""; //this should trigger an error
            StaffName = StaffName.PadRight(250, 'a'); //this should pass
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffName = ""; //this should trigger an error
            StaffName = StaffName.PadRight(50, 'a'); //this should pass
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            DateTime TestDate;
            //set the date to totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string StaffDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            DateTime TestDate;
            //set the date to totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string StaffDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            DateTime TestDate;
            //set the date to totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string StaffDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            DateTime TestDate;
            //set the date to totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string StaffDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            DateTime TestDate;
            //set the date to totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(+100);
            //convert the date variable to a string variable
            string StaffDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the StaffDate to a non date value
            string StaffDate = "this is not a date!";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = "a"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = "aa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = ""; //this should trigger an error
            StaffEmail = StaffEmail.PadRight(249, 'a'); //this should pass
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = ""; //this should trigger an error
            StaffEmail = StaffEmail.PadRight(250, 'a'); //this should pass
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = ""; //this should trigger an error
            StaffEmail = StaffEmail.PadRight(251, 'a'); //this should pass
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = ""; //this should trigger an error
            StaffEmail = StaffEmail.PadRight(500, 'a'); //this should pass
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffEmail = ""; //this should trigger an error
            StaffEmail = StaffEmail.PadRight(125, 'a'); //this should pass
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string ProductNo = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNoMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string ProductNo = "a"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNoMinPlus()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string ProductNo = "aa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffEmail, StaffDate, ProductNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        public void TestMethod1()
        {
        }
    }
}
