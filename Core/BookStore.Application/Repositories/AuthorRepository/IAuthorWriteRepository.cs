using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Domain.Entities;

namespace BookStore.Application.Repositories.AuthorRepository
{
    public interface IAuthorWriteRepository : IWriteRepository<Author>
    {

    }
}