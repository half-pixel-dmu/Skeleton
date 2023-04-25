using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance ofthe class we want
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffAvailability = true;
            TestItem.StaffNo = 1;
            TestItem.StaffName = "Alex";
            TestItem.StaffEmail = "Alex@email.com";
            TestItem.StaffDate = DateTime.Now.Date;
            TestItem.ProductNo = 2;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create  some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.StaffAvailability = true;
            TestStaff.StaffNo = 1;
            TestStaff.StaffName = "Alex";
            TestStaff.StaffEmail = "Alex@email.com";
            TestStaff.StaffDate = DateTime.Now.Date;
            TestStaff.ProductNo = 2;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see thhat they are equal
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create instance of class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item for the test
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffAvailability = true;
            TestItem.StaffNo = 1;
            TestItem.StaffName = "Alex";
            TestItem.StaffEmail = "Alex@email.com";
            TestItem.StaffDate = DateTime.Now.Date;
            TestItem.ProductNo = 2;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see theya re the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffAvailability = true;
            TestItem.StaffNo = 1;
            TestItem.StaffName = "Alex";
            TestItem.StaffEmail = "Alex@email.com";
            TestItem.StaffDate = DateTime.Now.Date;
            TestItem.ProductNo = 2;
            //set thisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see they are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance of class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffAvailability = true;
            TestItem.StaffNo = 1;
            TestItem.StaffName = "Alex";
            TestItem.StaffEmail = "Alex@email.com";
            TestItem.StaffDate = DateTime.Now.Date;
            TestItem.ProductNo = 2;
            //set thisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key
            TestItem.StaffNo = PrimaryKey;
            //modify the test data
            TestItem.StaffAvailability = false;
            TestItem.StaffNo = 2;
            TestItem.StaffName = "Adi";
            TestItem.StaffEmail = "Adi@email.com";
            TestItem.StaffDate = DateTime.Now.Date;
            TestItem.ProductNo = 3;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see they match
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create instance
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffAvailability = true;
            TestItem.StaffNo = 1;
            TestItem.StaffName = "Alex";
            TestItem.StaffEmail = "Alex@email.com";
            TestItem.StaffDate = DateTime.Now.Date;
            TestItem.ProductNo = 1;
            //set thisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            //create instance
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a blank string (should return all records;
            FilteredStaffs.ReportByName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaffs.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //create instance
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a name that doesn't exist
            FilteredStaffs.ReportByName("xx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaffs.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create an instance
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that doesn't exist
            FilteredStaffs.ReportByName("xx");
            //check that the correct number of records are found
            if(FilteredStaffs.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredStaffs.StaffList[0].StaffNo != 8)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredStaffs.StaffList[1].StaffNo != 10)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
