using WebAPIDemo.Models;

namespace WebAPIDemo.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
        int AddBook(Book book);
        int UpdateBook(Book book);
        int DeleteBook(int id);
    }
}

