using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Domain.Entities.Common;

namespace BookStore.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public Guid? ParentId { get; set; }

        public Category Parent { get; set; }
        public ICollection<Category> SubCategories { get; set; }
    }
}