namespace Interfaces;

public class WebServiceActivity : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Calling a web service provided by a third-party video encoding " +
                          "service to tell them you have a\r\nvideo ready for encoding... \r");
    }
}