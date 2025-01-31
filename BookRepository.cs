using LibraryMNG.Data;
using LibraryMNG.Models;


namespace LibraryMNG.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly  ApplicationDbContext _context;
        

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddBook(Book book)
        {
            
                _context.Books.Add(book);
                _context.SaveChanges();
            
        }

        public void DeleteBook(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        

        public Book GetBookById(int id)
        {
            Book book = _context.Books.Where(x => x.BookId == id).FirstOrDefault();
            return book;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public void UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
            
        }
    }
}
