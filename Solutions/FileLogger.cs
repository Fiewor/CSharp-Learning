using static Program.DbMigrator;

public partial class Program
{
    // if we decide that instead of logging messages on a console, we instead want to log them in a file, we can create a class that implements that

    public class FileLogger : ILogger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }
        public void LogError(string message)
        {
            Log(message, "ERROR");
        } 

        public void LogInfo(string message)
        {
            Log(message, "INFO");
            // an easier way to do this is to use an immigration
        }
        
        public void Log(string message, string messageType) 
        {
            // create a streamwriter for writing data to a file

            // because streamwriter uses a file resource that is not managed by CLR and hence, we need to dispose the resource once we finish using it.
            // this is ahchieved with the 'using' block below

            // behind the scene, there is an exception handling inside 'using', so, if something goes wrong, the compiler will make sure to close the file handle by calling a dispose method on the StreamWriter
            // the dispose method -> StreamWriter.Dispose() - this method is used for some external resources that are not managed by CLR
            // by using the 'using' bloc, the cmompiler automatically includes a call to the Dispose method so we don't have to manually do that
            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(messageType + ":" + message);
            }
        }
    }
}