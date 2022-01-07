using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.Data;
namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public List<Book> Get()
        {
            return BookData.Listar();
        }

        [HttpGet("{id}")]
        public Book Get(int ID)
        {
            return BookData.Obtener(ID);
        }

        [HttpPost]
        public bool Post([FromBody]Book book)
        {
           return BookData.Agregar_Book(book);
        }
        [HttpPut]
        public bool Put([FromBody] Book book)
        {
            return BookData.Modificar_Book(book);
        }
        [HttpDelete]
        public bool Delete (int id)
        {
           return BookData.Eliminar(id);
        }
    }
}
