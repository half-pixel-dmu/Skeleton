using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestingProduct
{
    [TestClass]
    public class tstOrderCollection
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
    }
}
