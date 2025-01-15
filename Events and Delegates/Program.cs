namespace EventsAndDelegates;

public class Program
{
    public static void Main(string[] args)
    {
        CheckVideoEncoder();
    }

    public static void CheckVideoEncoder()
    {
        var video = new Video() { Name = "Video 1" };

        var videoEncoder = new VideoEncoder();

        var mailService = new MailService();

        var messageService = new MessageService();

        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
        videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

        videoEncoder.Encode(video);
    }
}