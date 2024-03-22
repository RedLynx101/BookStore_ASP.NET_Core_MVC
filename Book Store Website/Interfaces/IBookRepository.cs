using Book_Store_Website.Models;

namespace Book_Store_Website.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks(int pageNum = 1, int pageSize = 10);
        int GetTotalBooks();
    }
}