using LibraryMNG.Models;

namespace LibraryMNG.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();

        Book GetBookById(int id);

        public void AddBook(Book book);
        public void UpdateBook(Book book);
        public void DeleteBook(Book book);

        
    }
}
