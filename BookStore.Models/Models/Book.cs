using System;
using System.Collections.Generic;

namespace BookStore.Models.Models
{
    public partial class Book
    {
        public Book()
        {
            Authors = new HashSet<Author>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int CategoryId { get; set; }
        public int PublisherId { get; set; }

        public virtual BookCategory Category { get; set; } = null!;
        public virtual Publisher Publisher { get; set; } = null!;

        public virtual ICollection<Author> Authors { get; set; }
    }
}
