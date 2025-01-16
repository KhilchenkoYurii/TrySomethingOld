namespace ExtensionMethods;

public class Program
{
    public static void Main(string[] args)
    {
        CheckStringExtension();
    }

    public static void CheckStringExtension()
    {
        string post = "This is a very long post about some shit...";

        Console.WriteLine(post.Shorten(5));
    }
}