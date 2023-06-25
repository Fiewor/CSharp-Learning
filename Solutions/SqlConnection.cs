public partial class Program
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
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
