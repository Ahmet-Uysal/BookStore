using BookStore.Application.Repositories.EndpointRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.EndpointRepository
{
    public class EndpointReadRepository : ReadRepository<Endpoint>, IEndpointReadRepository
    {
        public EndpointReadRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}