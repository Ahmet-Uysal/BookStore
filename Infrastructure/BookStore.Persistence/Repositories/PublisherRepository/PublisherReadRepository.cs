using BookStore.Application.Repositories.PublisherRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.PublisherRepository
{
    public class PublisherReadRepository : ReadRepository<Publisher>, IPublisherReadRepository
    {
        public PublisherReadRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}