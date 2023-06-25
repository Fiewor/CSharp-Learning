public partial class Program
{
    // we can now create concrete classes that implement this interface
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail....");
        }
    }
}