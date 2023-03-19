using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BooksBL;
using BookStore_Api.Entities;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        Class1 _logic = new Class1();

        [HttpGet("get/all/books")]

        public IActionResult GetBooks() {

            return Ok(_logic.GetAllBooks());
        }

        [HttpPost("add/books")]

        public IActionResult AddBooks([FromBody] Books book)
        {
            return Ok(_logic.AddBooks(book));
        }

        [HttpGet("getby/{id}")]

        public IActionResult GetBook(int id)
        {
            return Ok(_logic.GetBookById(id));
        }
    }
}
