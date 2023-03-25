public partial class Program
{
    public class WorkFlow
    {
        private readonly IList<IActivity> _activities;
        
        public WorkFlow()
        {
            _activities = new List<IActivity>();
        }

        public void AddActivityToWorkflow(IActivity activity)
        {
            _activities.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}