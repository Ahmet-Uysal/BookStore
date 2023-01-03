using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain.Entities
{
    public class BookImageFile : File
    {
        public ICollection<Book> Books { get; set; }
    }
}