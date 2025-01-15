namespace Generics;

public class Program
{
    
    public static void Main(string[] args)
    {
        CheckNullable();
    }

    public static void TryStandartListClasses()
    {
        var book = new Book { Isbn = "1234", Title = "Keksil" };

        //var numbers = new List();

        //numbers.Add(1);

        //var books = new BookList();

        //books.Add(book);

        var numbers = new GenericList<int>();

        numbers.Add(1);

        var books = new GenericList<Book>();

        books.Add(book);

        var genericD = new GenericDictionary<string, Book>();

        genericD.Add("1222", new Book());
    }

    public static void CheckNullable()
    {
        var number = new Nullable<int>(5);

        Console.WriteLine($"Has value? : {number.HasValue}");

        Console.WriteLine($"Value : {number.GetValueOrDefault()}");
    }
}