using Microsoft.AspNetCore.Mvc;
using BookApi.Models;
using BookApi.Services;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("books")]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;

        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }

        // POST /books
        [HttpPost]
        public IActionResult CreateBook([FromBody] Book book)
        {
            _bookService.Add(book);
            return Created($"/books/{book.Id}", book);
        }

        // GET /books
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = _bookService.GetAll();
            return Ok(books);
        }

        // POST /books/{id}/checkout
        [HttpPost("{id}/checkout")]
        public IActionResult CheckoutBook(int id)
        {
            return _bookService.Checkout(id) ? Ok() : NotFound();
        }

        // POST /books/{id}/return
        [HttpPost("{id}/return")]
        public IActionResult ReturnBook(int id)
        {
            return _bookService.Return(id) ? Ok() : NotFound();
        }
    }
}
