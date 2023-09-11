using WebAPIDemo.Data;
using WebAPIDemo.Models;

namespace WebAPIDemo.Repositories
{
    public class BookRepository: IBookRepository
    {
        private readonly ApplicationDbContext _db;
        public BookRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public int AddBook(Book book)
        {
            _db.Books.Add(book);
            int res = _db.SaveChanges();
            return res;
        }

        public int DeleteBook(int id)
        {
            int res = 0;
            var b = _db.Books.Find(id);
            if (b != null)
            {
                _db.Books.Remove(b);
                res = _db.SaveChanges();
            }
            return res;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _db.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            var b = _db.Books.Find(id);
            return b;
        }

        public int UpdateBook(Book book)
        {
            int res = 0;
            var b = _db.Books.Where(x => x.Id == book.Id).FirstOrDefault();
            if (b != null)
            {
                b.Name = book.Name;
                b.AuthorName =book.AuthorName;
                b.Price = book.Price;
                res = _db.SaveChanges();
            }
            return res;
        }
    }
}
