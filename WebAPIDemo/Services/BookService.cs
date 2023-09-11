using WebAPIDemo.Models;
using WebAPIDemo.Repositories;

namespace WebAPIDemo.Services
{
    public class BookService: IBookService
    {
        private readonly IBookRepository _repo;
        public BookService(IBookRepository repo)
        {
            _repo = repo;
        }
        public int AddBook(Book book)
        {
            return _repo.AddBook(book);
        }
        public int DeleteBook(int id)
        {
            return (_repo.DeleteBook(id));
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return _repo.GetAllBooks();
        }
        public Book GetBookById(int id)
        {
            return _repo.GetBookById(id);
        }

        public int UpdateBook(Book book)
        {
            return _repo.UpdateBook(book);
        }
    }
}
