using Book_Store_Website.Interfaces;
using Book_Store_Website.Models;

namespace Book_Store_Website.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookstoreContext _context;

        public BookRepository(BookstoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetBooks(int pageNum = 1, int pageSize = 10)
        {
            return _context.Books
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public int GetTotalBooks()
        {
            return _context.Books.Count();
        }
    }
}