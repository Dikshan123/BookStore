using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL
{
    public class BookCategory
    {
        public BookCategory()
        {
            
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
