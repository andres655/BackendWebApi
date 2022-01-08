using Microsoft.VisualStudio.TestTools.UnitTesting;
using webapi.Controllers;

namespace TestWebApi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDelete()
        {
            BookController bookController= new BookController();

            bool result = bookController.Delete(3);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestGet()
        {
            BookController bookController = new BookController();

            webapi.Book result = bookController.Get(1);
            Assert.AreEqual(1, result.Id);
        }
    }
}