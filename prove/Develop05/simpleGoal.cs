namespace GoalTracker;
public class SimpleGoal : Goal
{
    private int _completed = 0;

    public SimpleGoal(string name, string description, int points, int completed) : base(name, description, points)
    {
        _completed = completed;
    }

    public override string ExportGoal()
    {
        return $"SIMPLE|{Name}{DELIMETER}{Description}{DELIMETER}{Points}{DELIMETER}{_completed}";
    }

    public override int addPoints()
    {
        return base.addPoints();
    }
}