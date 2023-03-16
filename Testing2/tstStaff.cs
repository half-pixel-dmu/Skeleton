using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
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
        public void TestMethod1()
        {
        }
    }
}
