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
            Int32 TestData = 123;
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

            string TestData = "Alex@gmail.com";

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

            Int32 TestData = 123;

            Staff.ProductNo = TestData;

            Assert.AreEqual(Staff.ProductNo, TestData);
        }

        public void TestMethod1()
        {
        }
    }
}
