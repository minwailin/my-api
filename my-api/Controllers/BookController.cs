using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_api.Data.Services;
using my_api.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost("add-book&author")]
        public IActionResult AddBook([FromBody] BookVM bookVM)
        {
            _bookService.AddBook(bookVM);
            return Ok(); 
        }

        [HttpGet("get-all")]
        public IActionResult GetAllBook()
        {
            var allBook = _bookService.GetAllBooks();
            return Ok(allBook);
        }

        [HttpGet("get-book-by-id/{id}")]
        public IActionResult GetBookById(int id)
        {
            var Book = _bookService.GetBookByID(id);
            return Ok(Book);
        }

        [HttpPut("update-book/{id}")]
        public IActionResult UpdateBook(int id,[FromBody] BookVM bookVM)
        {
           var BUpdate = _bookService.UpdateBookByID( id , bookVM);
            return Ok(BUpdate);
        }

        [HttpDelete("delete-book/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _bookService.DeleteBookByID(id);
            return Ok();
        }
    }
}

