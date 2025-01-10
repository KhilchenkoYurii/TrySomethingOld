namespace Interfaces;

public class Workflow
{
    private readonly IList<IActivity> _activities;

    public Workflow()
    {
        _activities = new List<IActivity>();
    }

    public void Run()
    {
        foreach (var activity in _activities)
        {
            activity.Execute();
        }
    }

    public void AddActivity(IActivity activity)
    {
        _activities.Add(activity);
    }
}