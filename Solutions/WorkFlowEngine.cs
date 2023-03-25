public partial class Program
{
    public class WorkFlowEngine
    {
        //private WorkFlow _workflow;

        //public WorkFlowEngine(WorkFlow workflow)
        //{
        //    this._workflow = workflow;
        //}

        public void Run(WorkFlow workflow)
        {
            foreach (var activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}