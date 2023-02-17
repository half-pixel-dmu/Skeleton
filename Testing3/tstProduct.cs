using ClassLibrary;
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
    }
}
