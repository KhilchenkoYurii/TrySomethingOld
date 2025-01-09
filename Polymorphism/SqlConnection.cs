namespace Polymorphism;

public class OracleConnection : DbConnection
{
    public OracleConnection(string connectionString) : base(connectionString)
    {
    }

    public override void OpenConnection()
    {
        Console.WriteLine("Open Oracle connection");
    }

    public override void CloseConnection()
    {
        Console.WriteLine("Close Oracle connection");
    }
}

public class SqlConnection : DbConnection
{
    public SqlConnection(string connectionString) : base(connectionString)
    {
    }

    public override void OpenConnection()
    {
        Console.WriteLine("Open SQL connection");
    }

    public override void CloseConnection()
    {
        Console.WriteLine("Close SQL connection");
    }
}