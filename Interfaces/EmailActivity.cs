namespace Interfaces;

public class EmailActivity : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Sending an email to the owner of the " +
                          "video notifying them that the video started processing...");
    }
}