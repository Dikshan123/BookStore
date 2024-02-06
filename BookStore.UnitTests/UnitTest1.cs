namespace BookStore.UnitTests
{
    using BookStore.Domain.Service;
    using Moq;
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckIfBookExists()
        {
            int i = 4;
            Mock<IBookService> BookService = new Mock<IBookService> ();
        }
    }
}