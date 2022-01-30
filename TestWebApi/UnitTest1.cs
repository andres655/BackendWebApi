using Microsoft.VisualStudio.TestTools.UnitTesting;
using webapi;
using webapi.Controllers;

namespace TestWebApi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDelete()
        {
            BookController bookController = new BookController();

            bool result = bookController.Delete(0);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestGet()
        {
            BookController bookController = new BookController();

            webapi.Book result = (webapi.Book)bookController.Get(0);
            Assert.AreEqual(0, result.Id);
        }

        [TestMethod]
        public void TestPost()
        {
            BookController bookController = new BookController();
            int ID = 5;
            Book defaultPRofile = BuildBookProfile(ID);
            // var BookAppService = serviceProvider.GetRequiredService<BookController>();
            //BookAppService.Post(defaultPRofile);
            bookController.Post(defaultPRofile);
            Book userStep1 = (Book)bookController.Get(ID);

            Assert.AreEqual(defaultPRofile.Id, userStep1.Id);
            Assert.AreEqual(defaultPRofile.Titulo, userStep1.Titulo);
            Assert.AreEqual(defaultPRofile.Autor, userStep1.Autor);
        }

        [TestMethod]
        public void TestPut()
        {
            BookController bookController = new BookController();
            int ID = 5;
            Book defaultPRofile = BuildBookProfile(ID);
            bookController.Put(defaultPRofile);

            Book userStep2 = (Book)bookController.Get(ID);
            Assert.AreEqual(defaultPRofile.Id, userStep2.Id);
            Assert.AreEqual(defaultPRofile.Titulo, userStep2.Titulo);
            Assert.AreEqual(defaultPRofile.Autor, userStep2.Autor);
        }

        private Book BuildBookProfile(int ID)
        {
            return new Book()
            {
                Id = 5,
                Titulo = "La Vuelta al Mundo",
                Descripcion = "En 80 dias",
                Autor = "Julio Verne"

            };
        }
    }
}