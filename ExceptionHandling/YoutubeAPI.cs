namespace ExceptionHandling;

public class YoutubeAPI
{
    public List<Video> GetVideos(string user)
    {
        try
        {
            throw new Exception("Exception");
        }
        catch(Exception ex)
        {
            throw new YoutubeException("YoutubeAPI exception", ex);
        }

        return new List<Video>();
    }
}