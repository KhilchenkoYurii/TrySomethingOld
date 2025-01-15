namespace Delegates;

public class Program
{
    public static void Main(string[] args)
    {
        CheckPhotoProcessor();
    }

    public static void CheckPhotoProcessor()
    {
        var processor = new PhotoProcessor();
        
        var photoFilter = new PhotoFilters();

        //PhotoProcessor.PhotoFilterHandler filterHandler = photoFilter.ApplyBrightness;

        Action<Photo> filterHandler = photoFilter.ApplyBrightness;

        filterHandler += photoFilter.ApplyContrast;
        filterHandler += RemoveRedEye;

        processor.Process("path", filterHandler);
    }

    public static void RemoveRedEye(Photo photo)
    {
        Console.WriteLine("Remove red eye");
    }
}