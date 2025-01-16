namespace MyNamespace;

public class Program
{
    public static void Main(string[] args)
    {
        CheckNullable();
    }

    public static void CheckNullable()
    {
        DateTime? date = new DateTime(2025,1,1);

        DateTime date2 = date ?? DateTime.Today;

        Console.WriteLine(date2);

        Console.WriteLine($"GetValueOrDefault: {date.GetValueOrDefault()}");
        Console.WriteLine($"HasValue: {date.HasValue}");
        Console.WriteLine($"Value: {date.Value}");
    }
}