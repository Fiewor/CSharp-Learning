public partial class Program
{
    public interface INotificationChannel
    {
        void Send(Message message);
    }
}