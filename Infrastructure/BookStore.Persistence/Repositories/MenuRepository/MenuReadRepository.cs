using BookStore.Application.Repositories.MenuRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.MenuRepository
{
    public class MenuReadRepository : ReadRepository<Menu>, IMenuReadRepository
    {
        public MenuReadRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}