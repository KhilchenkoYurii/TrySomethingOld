namespace LambdaExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        CheckSquare();

        CheckLambdaExpression();

        CheckMultiplier();

        CheckBookRepository();
    }

    public static void CheckBookRepository()
    {
        var books = new BookRepository().GetBooks();

        //books = books.FindAll(book => book.Price < 3);

        books = books.FindAll(IsCheaperThan3Dollars);

        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Price: {book.Price}");
        }
    }

    public static bool IsCheaperThan3Dollars(Book book)
    {
        return book.Price < 3;
    }

    public static void CheckLambdaExpression()
    {
        // args => expression

        // () => ...

        // x => ...

        // (x, y, z) => ...


        Func<int, int> squareFunc = number => number * number;

        Console.WriteLine(squareFunc(5));
    }

    public static void CheckMultiplier()
    {
        const int factor = 10;

        Func<int, int> multiplier = number => number * factor;

        Console.WriteLine(multiplier(10));
    }

    public static void CheckSquare()
    {
        Console.WriteLine(Square(5));
    }

    public static int Square(int number)
    {
        return number * number;
    }
}