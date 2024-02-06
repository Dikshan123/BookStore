using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL
{
    public class AuthorContact
    {
        public int AuthorId { get; set; }
        public string? ContactNumber { get; set; }
        public string? Address { get; set; }

        public Author? Author { get; set; }
    }
}
