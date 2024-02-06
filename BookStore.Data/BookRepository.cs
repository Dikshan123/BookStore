using BookStore.BLL;
using BookStore.Repositoy.Mapper;
using Microsoft.EntityFrameworkCore;
using BookContext = BookStore.Models.Models;

namespace BookStore.Repositoy
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext.BookStoreContext _context;
        public BookRepository(BookContext.BookStoreContext context) 
        {
            _context = context;
        }

        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            IEnumerable<Book> books = _context.Books
                .Include(b => b.Authors)
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .Select(b => BookMapperDataToBusiness.BookDataToBusiness(b));
          return books;
        }

        public Book GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
