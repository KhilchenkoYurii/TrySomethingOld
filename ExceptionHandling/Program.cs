namespace ExceptionHandling;

public class Program
{
    public static void Main(string[] args)
    {
        CheckYoutubeAPI();
    }

    public static void CheckCalculator()
    {
        StreamReader streamReader = null;

        try
        {
            var calculator = new Calculator();

            streamReader = new StreamReader(@"C:\archive.zip");

            using (var streamReader2 = new StreamReader(@"C:\archive.zip"))
            {
                var content = streamReader2.ReadToEnd();
            }

            calculator.Divide(5, 0);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("DivideByZeroException block");
        }
        catch (ArithmeticException ex)
        {
            Console.WriteLine("ArithmeticException block");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception block");
        }
        finally
        {
            if (streamReader != null)
            {
                streamReader.Dispose();
            }
        }

    }

    public static void CheckYoutubeAPI()
    {
        try
        {
            var api = new YoutubeAPI();

            api.GetVideos("user");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}