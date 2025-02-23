using BookManagementAPI.Data;
using BookManagementAPI.Models;

namespace BookManagementAPI.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(BookDbContext context) : base(context)
        {
        }
    }
}
