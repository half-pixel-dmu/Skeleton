using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestingProduct
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();

            Assert.IsNotNull(AllProducts);
        }

        [TestMethod]
        public void ProductListOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();

            List<clsProduct> TestList = new List<clsProduct>();

            clsProduct TestItem = new clsProduct();

            TestItem.ProductTitle = "nice title";
            TestItem.ProductDescription = "nice description";
            TestItem.ProductPrice = 12.5;
            TestItem.ProductAvailability = true;
            TestItem.StaffNo = 2;

            TestList.Add(TestItem);

            AllProducts.ProductList = TestList;

            Assert.AreEqual(AllProducts.ProductList, TestList);
        }

        [TestMethod]
        public void ThisProductPropertyOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();

            clsProduct TestItem = new clsProduct();

            TestItem.ProductTitle = "nice title";
            TestItem.ProductDescription = "nice description";
            TestItem.ProductPrice = 12.5;
            TestItem.ProductAvailability = true;
            TestItem.StaffNo = 2;

            AllProducts.ThisProduct = TestItem;

            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();

            List<clsProduct> TestList = new List<clsProduct>();

            clsProduct TestItem = new clsProduct();

            TestItem.ProductTitle = "nice title";
            TestItem.ProductDescription = "nice description";
            TestItem.ProductPrice = 12.5;
            TestItem.ProductAvailability = true;
            TestItem.StaffNo = 2;

            TestList.Add(TestItem);

            AllProducts.ProductList = TestList;

            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();

            clsProduct TestItem = new clsProduct();

            int PrimaryKey = 0;

            TestItem.ProductTitle = "nice title";
            TestItem.ProductDescription = "nice description";
            TestItem.ProductPrice = 12.5;
            TestItem.ProductAvailability = true;
            TestItem.StaffNo = 2;

            AllProducts.ThisProduct = TestItem;

            PrimaryKey = AllProducts.Add();

            AllProducts.ThisProduct.Find(PrimaryKey);

            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();

            clsProduct TestItem = new clsProduct();

            int PrimaryKey = 0;

            TestItem.ProductTitle = "nice title";
            TestItem.ProductDescription = "nice description";
            TestItem.ProductPrice = 12.5;
            TestItem.ProductAvailability = true;
            TestItem.StaffNo = 2;

            AllProducts.ThisProduct = TestItem;

            PrimaryKey = AllProducts.Add();

            TestItem.ProductNumber = PrimaryKey;

            TestItem.ProductTitle = "nice title updated";
            TestItem.ProductDescription = "nice description updated";
            TestItem.ProductPrice = 17.5;
            TestItem.ProductAvailability = false;
            TestItem.StaffNo = 3;

            AllProducts.ThisProduct = TestItem;

            AllProducts.Update();

            AllProducts.ThisProduct.Find(PrimaryKey);

            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();

            clsProduct TestItem = new clsProduct();

            int PrimaryKey = 0;

            TestItem.ProductTitle = "to delete title";
            TestItem.ProductDescription = "to delete description";
            TestItem.ProductPrice = 8.5;
            TestItem.ProductAvailability = false;
            TestItem.StaffNo = 6;

            AllProducts.ThisProduct = TestItem;

            PrimaryKey = AllProducts.Add();

            AllProducts.ThisProduct.Find(PrimaryKey);

            AllProducts.Delete();

            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByProductTitleMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();

            clsProductCollection FilteredProducts = new clsProductCollection();

            FilteredProducts.ReportByProductTitle("");

            Assert.AreEqual(AllProducts.Count, FilteredProducts.Count);
        }

        [TestMethod]
        public void ReportByProductTitleDataFound()
        {
            clsProductCollection FilteredProducts = new clsProductCollection();

            Boolean OK = true;

            FilteredProducts.ReportByProductTitle("test");

            if (FilteredProducts.Count == 2)
            {
                if (FilteredProducts.ProductList[0].ProductNumber != 11)
                {
                    OK = false;
                }

                if (FilteredProducts.ProductList[1].ProductNumber != 12)
                {
                    OK = false;
                }
            } 
            else
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
