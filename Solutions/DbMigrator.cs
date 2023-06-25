public partial class Program
{
    // DbMigrator doesn't care who the actual logger is. An instance of any class that implements that interface can be passed in the constructor.
    // So, there is no coupling between DbMigrator and that concrete class (Logger)
    public partial class DbMigrator
    {
        private readonly ILogger logger;

        public DbMigrator(ILogger logger) // this technique is called dependency injection - which means, in the constructor, you're specifying the dependencies for a class
                                          // later, in the Main method, we'll specify the concrete class that implements that interface
        {
            this.logger = logger;
        }
        public void Migrate()
        {
            logger.LogInfo("Migration started at " + DateTime.Now);

            logger.LogInfo("Migration finished at " + DateTime.Now);
        }


    }
}