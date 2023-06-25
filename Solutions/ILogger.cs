public partial class Program
{
    public partial class DbMigrator
    {
        //private readonly Logger _logger;

        //public DbMigrator(Logger logger)
        //{
        //    _logger = logger;
        //}

        public interface ILogger
        {
            void LogError(string message);
            void LogInfo(string message); // logs info for troubleshooting
        }
    }
}