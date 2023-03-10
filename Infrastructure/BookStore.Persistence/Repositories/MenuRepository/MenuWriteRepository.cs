using BookStore.Application.Repositories.MenuRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.MenuRepository
{
    public class MenuWriteRepository : WriteRepository<Menu>, IMenuWriteRepository
    {
        public MenuWriteRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}