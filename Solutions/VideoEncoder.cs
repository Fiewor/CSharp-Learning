public partial class Program
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // to give this class the ability to publish an event, there are 3 steps you have to follow:
        // 1. define a delegate (contract between publisher and subscriber) - this determines the shape/signature of the method in the subscriber


        // Two parameters to the delegate
        // 1. object i.e. the source(of the event) or the class that is publishing the event
        // 2. any additional data that we want to with the event
        //public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        // name of the delegate is = name of event + EventHandler

        //----------
        // we can use the .NET delegate instead of creating our own
        //----------

        // if we want to send a reference to the video so the subscriber knows which video we encoded
        // to do that, instead of using EventArgs,we need a custom class - this custom class should derive from EventArgs and include any additional data that we would like to send to our subscribers

        // 2. define an event based on that delegate
        //public event VideoEncodedEventHandler VideoEncoded; // using our own delegate
        public event EventHandler<VideoEventArgs> VideoEncoded; // generic form of the event halder is being used because we want to pass some data
        public event EventHandler VideoEncoding; // if we were not going to pass any data, we could use this normal form of the EventHandler

        // 3. raise/publish the event
        // to do this, we need a method that is responsible for that
        protected virtual void OnVideoEncoded(Video video)
        {
            // how do we notify subscribers?
            // 1. check if there any subscribers to this event
            if (VideoEncoded != null)
                //VideoEncoded(this, EventArgs.Empty);
                VideoEncoded(this, new VideoEventArgs() { Video = video }); // with his change, our publisher is going to send some extra data which is encapsulated in the VideoEventArgs class, and there we would have a reference to the video that was encoded

            // Parameters explanation:
            // this - cause source is the current class (the publisher of the event)
            // EventArgs.Empty - is a static property of this class which returns an instance of event args which is empty. Used when we don't want to send any additional data with the event
        }

        // .NET convention for event publisher methods. 
        //1. They should be:
        // i. protected
        // ii. virtual
        // iii. void
        //2. Naming
        // They should start with On + the name of the event


        //public readonly MailService _mailService;
        public readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {

            // ------ Interface ------
            //_mailService = new MailService();
            //_notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video....");
            Thread.Sleep(3000); // delay the application for a period of 3 seconds

            // once encoding is finished, we just call the event publisher method
            OnVideoEncoded(video);
            // the method should notify all the subscribers


            //_mailService.Send(new Mail());

            // once the video is encoded, we now need to iterate over the list of notification channels and notify each of them

            //foreach (var channel in _notificationChannels)
            //{
            //    channel.Send(new Message());
            //}
            // so a different Send method is called based on the channel - this is how interfaces implement polymorphic behaviour
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