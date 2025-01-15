namespace EventsAndDelegates;

public class MessageService
{
    public void OnVideoEncoded(object obj, VideoEventArgs args)
    {
        Console.WriteLine($"MessageService: Sending a message with video {args.Video.Name}...");
    }
}