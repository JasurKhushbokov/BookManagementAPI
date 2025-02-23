using BookManagementAPI.Models;
using BookManagementAPI.Repositories;

namespace BookManagementAPI.Service
{
    public class BookService : Service<Book>, IBookService
    {
        public BookService(IBookRepository repository) : base(repository)
        {
        }
    }   
}
