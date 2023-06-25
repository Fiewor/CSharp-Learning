public partial class Program
{
    // this class is respnosible for sending an email once the video is encoded
    public class MailService
    {
        public void Send(Mail mail)
        {
            Console.WriteLine("Sending mail...");
        }

        // event handler
        //public void OnVideoEncoded(object source, EventArgs e)
        public void OnVideoEncoded(object source, VideoEventArgs e) // we changed the method rto comply with the delegate
        {
            Console.WriteLine("MailService: Sending an mail..." + e.Video.Title);
        }
    }
}