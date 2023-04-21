﻿using ClassLibrary;
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
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerConfirmed = true;
            TestItem.CustomerNo = 100;
            TestItem.CustomerAddress = "Some Street, NG3 8 HV";
            TestItem.CustomerEmail = "pruna.nane@yahoo.com";
            TestItem.CustomerName = "Pruna Nane";
            TestItem.CustomerDateJoined = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see thisCustomer matches the test data
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerConfirmed = true;
            TestItem.CustomerAddress = "Some Street, NG3 8 HV";
            TestItem.CustomerEmail = "pruna.nane@yahoo.com";
            TestItem.CustomerName = "Pruna Nane";
            TestItem.CustomerDateJoined = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //modify the test data
            TestItem.CustomerConfirmed = false;
            TestItem.CustomerAddress = "Every Street, NG3 8 HV";
            TestItem.CustomerEmail = "gina.tone@yahoo.com";
            TestItem.CustomerName = "Gina Tone";
            TestItem.CustomerDateJoined = DateTime.Now.Date;
            //set the record based on the new test data
            AllCustomer.ThisCustomer = TestItem;
            //update the record
            AllCustomer.Update();
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see thisCustomer matches the test data
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }
    }
}
