using WebAPIDemo.Models;

namespace WebAPIDemo.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
        int AddBook(Book book);
        int UpdateBook(Book book);
        int DeleteBook(int id);
    }
}
