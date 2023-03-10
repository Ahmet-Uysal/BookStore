using BookStore.Application.Repositories.BookRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.BookRepository
{
    public class BookWriteRepository : WriteRepository<Book>, IBookWriteRepository
    {
        public BookWriteRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}