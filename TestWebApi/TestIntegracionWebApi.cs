
using webapi.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using webapi;

namespace TestWebApi
{
   public class TestIntegracionWebApi
    {
        [Fact]
        public void TestInsertBook_Then_ModifyIt()
        {
        
            BookController bookController = new BookController();
            int  ID = 5;
            
                Book defaultPRofile = BuildBookProfile(ID);
            //llama al servicio post
            bookController.Post(defaultPRofile);
            //llama prueba el servicio get
            Book userStep1 = (Book)bookController.Get(ID);
            
                Assert.AreEqual(defaultPRofile.Id, userStep1.Id);
                Assert.AreEqual(defaultPRofile.Titulo, userStep1.Titulo);
                Assert.AreEqual(defaultPRofile.Autor, userStep1.Autor);

            //llama al servicio put
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
               Id=5,    
               Titulo="La Vuelta al Mundo",
               Descripcion="En 80 dias",
               Autor="Julio Verne"
               
            };
        }
    }
}
