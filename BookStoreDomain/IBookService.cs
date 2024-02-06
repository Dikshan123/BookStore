using BookStore.BLL;
namespace BookStore.Domain.Service
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
        bool CheckIfBookExists(int id);
    }
}
