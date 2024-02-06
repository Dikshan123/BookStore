namespace BookStore.BLL
{
    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public AuthorContact? AuthorContact { get; set; }

        public IEnumerable<Book> Books { get; set; }
    }
}
