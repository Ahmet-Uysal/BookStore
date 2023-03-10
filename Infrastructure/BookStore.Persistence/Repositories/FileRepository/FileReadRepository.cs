using BookStore.Application.Repositories.FileRepository;
using BookStore.Persistence.Contexts;
using F = BookStore.Domain.Entities;
namespace BookStore.Persistence.Repositories.FileRepository
{
    public class FileReadRepository : ReadRepository<F.File>, IFileReadRepository
    {
        public FileReadRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}