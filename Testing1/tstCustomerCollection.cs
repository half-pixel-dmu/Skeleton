using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that it exist
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerConfirmed = true;
            TestItem.CustomerNo = 1001;
            TestItem.CustomerAddress = "Not here, NG8 5LH";
            TestItem.CustomerEmail = "daniel.hatel@yahoo.com";
            TestItem.CustomerName = "Daniel Hatel";
            TestItem.CustomerDateJoined = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.CustomerList, TestList);

        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an insyance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllCustomer.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, SomeCount);
        }

        [TestMethod]
        public void ThisCustomerPropertOK()
        {
            //create an insyance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the property of the test object
            TestCustomer.CustomerConfirmed = true;
            TestCustomer.CustomerNo = 1001;
            TestCustomer.CustomerAddress = "Not here, NG8 5LH";
            TestCustomer.CustomerEmail = "daniel.hatel@yahoo.com";
            TestCustomer.CustomerName = "Daniel Hatel";
            TestCustomer.CustomerDateJoined = DateTime.Now.Date;
            //asign the data to the property
            AllCustomer.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerConfirmed = true;
            TestItem.CustomerNo = 1001;
            TestItem.CustomerAddress = "Not here, NG8 5LH";
            TestItem.CustomerEmail = "daniel.hatel@yahoo.com";
            TestItem.CustomerName = "Daniel Hatel";
            TestItem.CustomerDateJoined = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, TestList.Count);

        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
             clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, 2);
    }

    }
}
