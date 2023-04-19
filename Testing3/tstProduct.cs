using ClassLibrary;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingProduct
{
    [TestClass]
    public class tstProduct
    {
        // Good test data
        string ProductTitle = "Cleaning service";
        string ProductDescription = "A great cleaning service";
        string ProductPrice = "12.5";
        string ProductAvailability = "true";
        string StaffNo = "3";

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

        [TestMethod]
        public void FindMethodOK()
        {
            clsProduct anProduct = new clsProduct();

            Boolean Found = false;

            int ProductNo = 2;

            Found = anProduct.Find(ProductNo);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductNoFound()
        {
            clsProduct anProduct = new clsProduct();

            Boolean Found = false;

            Boolean OK = true;

            int ProductNo = 99;

            Found = anProduct.Find(ProductNo);

            if (anProduct.ProductNumber != 99)
            {
                OK = false;
            }

            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestProductTitleFound()
        {
            clsProduct anProduct = new clsProduct();

            Boolean Found = false;

            Boolean OK = true;

            int ProductNo = 2;

            Found = anProduct.Find(ProductNo);

            if (anProduct.ProductTitle != "Clean your house")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductDescriptionFound()
        {
            clsProduct anProduct = new clsProduct();

            Boolean Found = false;

            Boolean OK = true;

            int ProductNo = 2;

            Found = anProduct.Find(ProductNo);

            if (anProduct.ProductDescription != "A good cleaning service just for you")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductPriceFound()
        {
            clsProduct anProduct = new clsProduct();

            Boolean Found = false;

            Boolean OK = true;

            int ProductNo = 2;

            Found = anProduct.Find(ProductNo);

            if (anProduct.ProductPrice != 25)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductCreateDateFound()
        {
            clsProduct anProduct = new clsProduct();

            Boolean Found = false;

            Boolean OK = true;

            int ProductNo = 2;

            Found = anProduct.Find(ProductNo);

            if (anProduct.ProductCreateDate != Convert.ToDateTime("17/02/2023"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductAvailabilityFound()
        {
            clsProduct anProduct = new clsProduct();

            Boolean Found = false;

            Boolean OK = true;

            int ProductNo = 2;

            Found = anProduct.Find(ProductNo);

            if (anProduct.ProductAvailability == false)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            clsProduct anProduct = new clsProduct();

            Boolean Found = false;

            Boolean OK = true;

            int ProductNo = 2;

            Found = anProduct.Find(ProductNo);

            if (anProduct.StaffNo != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsProduct anProduct = new clsProduct();

            String Error = "";

            Error = anProduct.Valid(ProductTitle, ProductDescription, ProductPrice, ProductAvailability, StaffNo);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTitleMinLessOne()
        {
            clsProduct anProduct = new clsProduct();

            String Error = "";

            Error = anProduct.Valid("", ProductDescription, ProductPrice, ProductAvailability, StaffNo);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductTitleNoMin()
        {
            clsProduct anProduct = new clsProduct();

            String Error = "";

            Error = anProduct.Valid("a", ProductDescription, ProductPrice, ProductAvailability, StaffNo);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTitleNoMinPlusOne()
        {
            clsProduct anProduct = new clsProduct();

            String Error = "";

            Error = anProduct.Valid("aa", ProductDescription, ProductPrice, ProductAvailability, StaffNo);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTitleNoMaxLessOne()
        {
            clsProduct anProduct = new clsProduct();

            String Error = "";

            String Title = "".PadRight(249, 'a');

            Error = anProduct.Valid(Title, ProductDescription, ProductPrice, ProductAvailability, StaffNo);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTitleNoMax()
        {
            clsProduct anProduct = new clsProduct();

            String Error = "";

            String Title = "".PadRight(250, 'a');

            Error = anProduct.Valid(Title, ProductDescription, ProductPrice, ProductAvailability, StaffNo);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTitleNoMaxPlusOne()
        {
            clsProduct anProduct = new clsProduct();

            String Error = "";

            String Title = "".PadRight(251, 'a');

            Error = anProduct.Valid(Title, ProductDescription, ProductPrice, ProductAvailability, StaffNo);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductTitleNoExtremeMax()
        {
            clsProduct anProduct = new clsProduct();

            String Error = "";

            String Title = "".PadRight(500, 'a');

            Error = anProduct.Valid(Title, ProductDescription, ProductPrice, ProductAvailability, StaffNo);

            Assert.AreNotEqual(Error, "");
        }
    }
}
