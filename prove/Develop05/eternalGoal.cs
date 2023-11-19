namespace GoalTracker;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }


    public override string ExportGoal()
    {
         return $"ETERNAL|{Name}{DELIMETER}{Description}{DELIMETER}{Points}";
    }

    public override void completed()
    {
        Console.Write("[ ]");
        
    }


    public override int addPoints()
    {
        return Points; // Return points upon completion

    }

}