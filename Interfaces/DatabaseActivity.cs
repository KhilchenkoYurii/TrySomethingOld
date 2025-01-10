namespace Interfaces;

public class DatabaseActivity : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Changing the status of the video record in the database to “Processing”...");
    }
}