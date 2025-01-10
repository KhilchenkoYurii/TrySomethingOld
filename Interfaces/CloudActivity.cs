namespace Interfaces;

public class CloudActivity : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Uploading a video to a cloud storage...");
    }
}