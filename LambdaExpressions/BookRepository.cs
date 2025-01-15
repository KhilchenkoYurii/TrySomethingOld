namespace LambdaExpressions;

public class BookRepository
{
    public List<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book { Title = "Book1", Price = 1 },
            new Book { Title = "Book2", Price = 2 },
            new Book { Title = "Book3", Price = 3 }
        };
    }
}