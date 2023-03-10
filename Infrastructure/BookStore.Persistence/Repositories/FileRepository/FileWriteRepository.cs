using BookStore.Application.Repositories.FileRepository;
using BookStore.Persistence.Contexts;
using F = BookStore.Domain.Entities;
namespace BookStore.Persistence.Repositories.FileRepository
{
    public class FileWriteRepository : WriteRepository<F.File>, IFileWriteRepository
    {
        public FileWriteRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}