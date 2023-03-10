using BookStore.Application.Repositories.PublisherRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.PublisherRepository
{
    public class PublisherWriteRepository : WriteRepository<Publisher>, IPublisherWriteRepository
    {
        public PublisherWriteRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}