using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;




namespace TestOrderCollection
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection allOrder = new clsOrderCollection();
            Assert.IsNotNull(allOrder);
        }
        [TestMethod]
        public void AdressLiskOK()
        {
            clsOrderCollection allOrder = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductId = 1;
            TestItem.OrderPrice = 2;
            TestItem.OrderStatus = "Some Status";
            TestList.Add(TestItem);
            allOrder.OrderList = TestList;
            Assert.AreEqual(allOrder.OrderList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Int32 SomeCount = 2;
            AllOrder.Count = SomeCount;
            Assert.AreEqual(AllOrder.Count, SomeCount);
        }
        [TestMethod]
        public void ThisAdressPropertyOK()
        {
            clsOrderCollection allOrder = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderNo = 1;
            TestOrder.CustomerNo = 1;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.ProductId = 1;
            TestOrder.OrderPrice = 2;
            TestOrder.OrderStatus = "Some Status";
            allOrder.ThisOrder = TestOrder;
            Assert.AreEqual(allOrder.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductId = 1;
            TestItem.OrderPrice = 2;
            TestItem.OrderStatus = "Some Status";
            TestList.Add(TestItem);
            AllOrder.OrderList = TestList;


        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.OrderNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductId = 1;
            TestItem.OrderPrice = 2;
            TestItem.OrderStatus = "Some Status";
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see they are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.OrderNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductId = 1;
            TestItem.OrderPrice = 2;
            TestItem.OrderStatus = "Some Status";
            AllOrder.ThisOrder = TestItem;
            PrimaryKey = AllOrder.Add();
            TestItem.OrderNo = PrimaryKey;
            TestItem.OrderNo = 2;
            TestItem.CustomerNo = 3;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductId = 2;
            TestItem.OrderPrice = 4;
            TestItem.OrderStatus = "Any Status";
            AllOrder.ThisOrder = TestItem;
            AllOrder.Update();
            AllOrder.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);


        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.OrderNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ProductId = 1;
            TestItem.OrderPrice = 2;
            TestItem.OrderStatus = "Some Status";
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            AllOrder.Delete();
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByOrderNo(string text)
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
        clsOrderCollection FilteredOrder = new clsOrderCollection();
        FilteredOrder.ReportByOrderNo("");
            Assert.AreEqual(AllOrder.Count, FilteredOrder.Count);
    }
}
    }

