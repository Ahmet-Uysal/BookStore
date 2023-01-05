using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Domain.Entities.Common;

namespace BookStore.Application.Dtos.Category
{
    public class GetCategoriesIgnoreIncludes : BaseEntity
    {
        public string Name { get; set; }
        public Guid? ParentId { get; set; }
    }
}