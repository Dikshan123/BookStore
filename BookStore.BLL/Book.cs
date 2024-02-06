namespace BookStore.BLL
{
    public class Book
    {
        public Book()
        {

        }
        public string? Title { get; set; }
    
        public  BookCategory? Category { get; set; }
        public  Publisher? Publisher { get; set; }

        public List<Author?> Authors { get; set; }
    }
}
