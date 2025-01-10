namespace Interfaces;

public class DbMigrator
{
    private ILogger _logger;

    public DbMigrator(ILogger logger)
    {
        _logger = logger;
    }

    public void Migrate()
    {
        _logger.LogInfo($"Migration started at {DateTime.Now}");

        //Migration processes

        _logger.LogInfo($"Migration ended at {DateTime.Now}");
    }
}