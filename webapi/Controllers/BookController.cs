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
        public IActionResult Get()
        {

            return Ok(BookData.Listar());
        }

        [HttpGet("{id}")]
        public Book Get(int ID)
        {
            return  BookData.Obtener(ID);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Book book)
        {
           return Ok(BookData.Agregar_Book(book));
        }
        [HttpPut]
        public IActionResult Put([FromBody] Book book)
        {
            return Ok(BookData.Modificar_Book(book));
        }
        [HttpDelete("{id}")]
        public  bool Delete (int id)
        {
           return BookData.Eliminar(id);
        }
    }
}
