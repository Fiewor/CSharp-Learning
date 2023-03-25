public partial class Program
{
    public class Post
    {
        private string _title = "";
        private string _description = "";
        private DateTime _created = DateTime.Now;
        private int _vote;
        public int Vote { get; private set; }
        public void UpVote()
        {
            //upvote a post
            Vote++;
        }

        public void DownVote()
        {
            Vote--;
        }
    }
}