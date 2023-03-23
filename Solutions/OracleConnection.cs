public partial class Program
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening connection...");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing connection....");
        }
    }
    }
