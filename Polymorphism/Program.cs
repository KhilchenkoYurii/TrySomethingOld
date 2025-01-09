namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckDbCommand();
        }

        public static void CheckDbCommand()
        {
            var sqlDb = new SqlConnection("Sql connection");

            var oracleDb = new OracleConnection("Oracle connection");

            var dbCommands = new DbCommand(sqlDb);

            dbCommands.Execute("SELECT *");

            dbCommands = new DbCommand(oracleDb);

            dbCommands.Execute("SELECT *");

            //dbCommands.Execute("");

            //dbCommands = new DbCommand(null);
        }

        public static void CheckDbConnection()
        {
            var sqlDb = new SqlConnection("Sql connection");

            var oracleDb = new OracleConnection("Oracle connection");

            sqlDb.OpenConnection();

            oracleDb.OpenConnection();

            sqlDb.CloseConnection();

            oracleDb.CloseConnection();

        }

        public static void CheckShapes()
        {
            var shapes = new List<Shape>();

            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());

            Canvas canvas = new Canvas();

            canvas.DrawShape(shapes);
        }
    }
}