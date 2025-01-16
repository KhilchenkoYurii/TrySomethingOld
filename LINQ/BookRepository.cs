namespace LINQ;

public class BookRepository
{
    public IEnumerable<Book> GetBooks()
    {
        return new List<Book>()
        {
            new Book() { Title = "Book 1", Price = 10 },
            new Book() { Title = "Book 23", Price = 17 },
            new Book() { Title = "Book 111", Price = 19 },
            new Book() { Title = "Book 2", Price = 21 },
            new Book() { Title = "Book 3", Price = 11 },
        };
    }
}