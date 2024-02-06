using System;
using System.Collections.Generic;

namespace BookStore.Models.Models
{
    public partial class AuthorContact
    {
        public int AuthorId { get; set; }
        public string? ContactNumber { get; set; }
        public string? Address { get; set; }

        public virtual Author Author { get; set; } = null!;
    }
}
