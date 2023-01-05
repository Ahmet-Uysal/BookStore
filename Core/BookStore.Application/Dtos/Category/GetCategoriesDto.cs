using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Domain.Entities.Common;
using C = BookStore.Domain.Entities;

namespace BookStore.Application.Dtos.Category
{
    public class GetCategoriesDto : BaseEntity
    {
        public string Name { get; set; }
        public Guid? ParentId { get; set; }

        public ICollection<GetCategoriesDto> SubCategories { get; set; }
    }
}