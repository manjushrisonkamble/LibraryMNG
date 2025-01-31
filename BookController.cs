using LibraryMNG.Data;
using LibraryMNG.Models;
using LibraryMNG.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LibraryMNG.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IBookRepository _bookRepository;

        public BookController(ApplicationDbContext context, IBookRepository bookRepository)
        { 
            _bookRepository = bookRepository;
            _context = context;
        }

        public IActionResult AllBooks()
        {
            IEnumerable<Book> books = _context.Books;
            return View(books);

        }

        [HttpGet]
        public IActionResult AddNewBook()
        {
            return View();

        }

        [HttpPost]
        public IActionResult AddNewBook(Book book)
        {
            Book book1 = new Book();
            book1.BookTitle = book.BookTitle;
            book1.Author = book.Author;
            book1.Genre = book.Genre;
            book1.PublishDate = book.PublishDate;
            book1.Status = book.Status;
            _bookRepository.AddBook(book1);
            return RedirectToAction("AllBooks");
        }

        [HttpGet]
        public IActionResult EditBook(int id)
        {
            var book1 = _bookRepository.GetBookById(id);
            return View(book1);
        }

        [HttpPost]
        public IActionResult EditBook(Book book)
        {
            var book1 = _bookRepository.GetBookById(book.BookId);
            book1.BookId = book.BookId;
            book1.BookTitle = book.BookTitle;
            book1.Author = book.Author;
            book1.Genre = book.Genre;
            book1.PublishDate = book.PublishDate;
            book1.Status = book.Status;
            _bookRepository.UpdateBook(book1);
            return RedirectToAction("AllBooks");

        }

        public IActionResult RemoveBook(Book book)
        {
            var book1 = _bookRepository.GetBookById(book.BookId);
            _bookRepository.DeleteBook(book1);
            return RedirectToAction("AllBook");
        }

    }
}
