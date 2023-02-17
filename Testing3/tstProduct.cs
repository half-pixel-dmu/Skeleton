using ClassLibrary;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingProduct
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProduct anProduct = new clsProduct();

            Assert.IsNotNull(anProduct);
        }

        [TestMethod]
        public void ProductNumberPropertyOK()
        {
            clsProduct anProduct = new clsProduct();

            int number = 1;

            anProduct.ProductNumber = number;

            Assert.AreEqual(anProduct.ProductNumber, number);
        }

        [TestMethod]
        public void ProductTitlePropertyOK()
        {
            clsProduct anProduct = new clsProduct();

            string title = "title";

            anProduct.ProductTitle = title;

            Assert.AreEqual(anProduct.ProductTitle, title);
        }

        [TestMethod]
        public void ProductDescriptionPropertyOK()
        {
            clsProduct anProduct = new clsProduct();

            string description = "nice description";

            anProduct.ProductDescription = description;

            Assert.AreEqual(anProduct.ProductDescription, description);
        }

        [TestMethod]
        public void ProductPricePropertyOK()
        {
            clsProduct anProduct = new clsProduct();

            float price = 10;

            anProduct.ProductPrice = price;

            Assert.AreEqual(anProduct.ProductPrice, price);
        }

        [TestMethod]
        public void ProductCreateDatePropertyOK()
        {
            clsProduct anProduct = new clsProduct();

            DateTime testDate = DateTime.Now.Date;

            anProduct.ProductCreateDate = testDate;

            Assert.AreEqual(anProduct.ProductCreateDate, testDate);
        }

        [TestMethod]
        public void ProductAvailabilityPropertyOK()
        {
            clsProduct anProduct = new clsProduct();

            bool availability = false;

            anProduct.ProductAvailability = availability;

            Assert.AreEqual(anProduct.ProductAvailability, availability);
        }

        [TestMethod]
        public void StaffNoPropertyOK()
        {
            clsProduct anProduct = new clsProduct();

            int staffNumber = 1;

            anProduct.StaffNo = staffNumber;

            Assert.AreEqual(anProduct.StaffNo, staffNumber);
        }
    }
}
