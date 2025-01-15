namespace EventsAndDelegates;

public class VideoEncoder
{
    //1 - Define a delegate
    //2 - Define an event based on that delegate
    //3 - Raise an event

    public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);

    //EventHandler
    //EventHandler<>

    public event EventHandler<VideoEventArgs> VideoEncoded;


    //public event VideoEncoderEventHandler VideoEncoded;

    public void Encode(Video video)
    {
        Console.WriteLine("Encoding the video...");
        
        Thread.Sleep(3000);

        OnVideoEncoded(video);
    }

    protected virtual void OnVideoEncoded(Video video)
    {
        if (VideoEncoded != null)
        {
            VideoEncoded(this, new VideoEventArgs() { Video = video});
        }
    }
}