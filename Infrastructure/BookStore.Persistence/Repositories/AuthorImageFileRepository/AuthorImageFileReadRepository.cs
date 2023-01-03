using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Repositories.AuthorImageFileRepository;
using BookStore.Domain.Entities;
using BookStore.Persistence.Contexts;

namespace BookStore.Persistence.Repositories.AuthorImageFileRepository
{
    public class AuthorImageFileReadRepository : ReadRepository<AuthorImageFile>, IAuthorImageFileReadRepository
    {
        public AuthorImageFileReadRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}