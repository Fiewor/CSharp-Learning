public partial class Program
{
    public abstract class DbConnection
    {
        private string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
        public DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("Connection string cannot be null or white space.");

            ConnectionString = connectionString;
        }
        public DbConnection(string connectionString, TimeSpan timeout)
            : this(connectionString)
        {
            Timeout = timeout;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
