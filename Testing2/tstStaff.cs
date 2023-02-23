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

        public void StaffNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to asign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Staff.StaffNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffNo, TestData);
        }

        public void StaffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to asign to the property
            string TestData = "21b";
            //assign the data to the property
            Staff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffName, TestData);
        }

        public void StaffEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to asign to the property
            string TestData = "21b";
            //assign the data to the property
            Staff.StaffEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffEmail, TestData);
        }

        public void StaffAvailabilityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to asign to the property
            Boolean TestData = true;
            //assign the data to the property
            Staff.StaffAvailability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffAvailability, TestData);
        }

        public void StaffDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data to asign to the property
            Boolean TestData = true;
            //assign the data to the property
            Staff.Staffat = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffAvailability, TestData);
        }
        public void TestMethod1()
        {
        }
    }
}
