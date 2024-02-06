using BookStore.BLL;
using models = BookStore.Models.Models;

namespace BookStore.Repositoy.Mapper
{
    public static class BookMapperDataToBusiness
    {
        public static Book BookDataToBusiness(models.Book book)
        {
            return new Book()
            {
                Title = book.Title,
                Category = new BookCategory()
                {
                    Name = book.Category.Name,
                },
                Publisher = new Publisher()
                {
                    Name = book.Publisher.Name
                },
                Authors = book.Authors.Select(a => BookStoreAuthorDataToBusiness(a)).ToList()
            };
        }
        public static Author BookStoreAuthorDataToBusiness(models.Author author)
        {
            if (author == null)
                return null;
             
            return new Author()
            {
                Name = author.Name,
                AuthorContact = BookStoreAuthorContactDataToBusiness(author.AuthorContact)
            };
        }
        public static AuthorContact BookStoreAuthorContactDataToBusiness(models.AuthorContact contact)
        {
            if (contact == null)
                return null;

            return new AuthorContact()
            {
                ContactNumber = contact.ContactNumber,
                Address = contact.Address
            };
        }
    }
}
