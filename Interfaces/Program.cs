namespace Interfaces;

public class Program
{
    public const string path = @"C:\Users\yurii.khilchenko\Desktop\TextForExcercise1.txt";

    public static void Main(string[] args)
    {
        CheckWorkflow();
    }

    public static void CheckWorkflow()
    {
        var workflow = new Workflow();

        workflow.AddActivity(new CloudActivity());
        workflow.AddActivity(new WebServiceActivity());
        workflow.AddActivity(new DatabaseActivity());
        workflow.AddActivity(new EmailActivity());

        workflow.Run();
    }

    public static void CheckNotifications()
    {
        var encode = new VideoEncoder();

        encode.RegisterNotificationChannel(new MailNotificationChannel());
        encode.RegisterNotificationChannel(new SmsNotificationChannel());

        encode.Encode(new Video());
    }

    public static void CheckOrderProcesses()
    {
        var orderProcesses = new OrderProcessor(new ShippingCalculator());

        var order = new Order {DatePlaced = DateTime.Now, TotalPrice = 100f};

        orderProcesses.Process(order);

    }

    public static void CheckDbMigrator()
    {
        var dbMigrator = new DbMigrator(new FileLogger(path));
        
        dbMigrator.Migrate();
    }
}
