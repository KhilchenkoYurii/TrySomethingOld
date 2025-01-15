namespace EventsAndDelegates;

public class MailService
{
    public void OnVideoEncoded(object obj, VideoEventArgs args)
    {
        Console.WriteLine($"MailService: Sending an email with video {args.Video.Name}...");
    }
}