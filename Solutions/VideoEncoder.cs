public partial class Program
{
    public class VideoEncoder
    {
        //public readonly MailService _mailService;
        public readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            //_mailService = new MailService();
            _notificationChannels= new List<INotificationChannel>();
        }

        public void Encode(VideoEncoder video)
        {
            //video encoding logic
            //_mailService.Send(new Mail());

            // once the video is encoded, we now need to iterate over the list of notification channels and notify each of them

            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
            // so a different Send method is calle based on the channel - this is how interfaces implement polymorphic behaviour
        }

        // we need to tell video encoder about the actual notification channels at runtime
        // because the _notificationChannels list is defined as private (cause it's implementation details of this class and we don't want to expose it to the outside, we need to create a method that does the afore-mentioned task

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
        // so this is the method we use from the outside
    }
}