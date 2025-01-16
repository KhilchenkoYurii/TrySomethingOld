namespace LINQ;

public class Program
{
    public static void Main(string[] args)
    {
        CheckBookRepository();
    }

    public static void CheckBookRepository()
    {
        var books = new BookRepository().GetBooks();

        books.Single(b => b.Title == "Book 123"); //return exeption if object not exist

        books.SingleOrDefault(b => b.Title == "Book 123"); // return object or first element

        books.First(b => b.Title == "Book 123"); //similar to above

        books.Last(b => b.Title == "Book 123"); //return to last object

        books.Skip(2).Take(3); // skip 2 records, take 3 next

        books.Count();

        books.Max(b => b.Price); // return book with max price

        books.Min(b => b.Price); // return book with min price

        books.Sum(b => b.Price); // return sum by some property

        books.Average(b => b.Price); // return average price

        var cheaperBooks =
            from b in books
            where b.Price < 19
            orderby b.Price
            select b.Title;

        var cheapBooks = books
            .Where(b => b.Price < 15)
            .OrderBy(b => b.Price)
            .Select(b => b.Title);

        foreach (var book in cheaperBooks)
        {
            //Console.WriteLine($"Title: {book.Title}, Price: {book.Price}");
            Console.WriteLine($"Title: {book}");
        }
    }
}