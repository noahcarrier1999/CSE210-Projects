using System.Dynamic;

namespace GoalTracker;

public class ChecklistGoal : Goal
{
    //private string _name;
    //private string _description;
    //private int _points;
    private int _timesToComplete;
    private int _bonus;
    private int _timesCompeted;
    private int _completed = 0;


    public int TimesToComplete{

        get{return _timesToComplete;}
        set{_timesToComplete = value;}
    }

    public int Bonus{
        
        get{return _bonus;}
        set{_bonus = value;}
    }

    public int TimesCompleted{
        get{ return _timesCompeted;}
        set{_timesCompeted = value;}
    }


    public ChecklistGoal(string name, string description, int points, int timesToCmplete, int bonus, int completed) : base(name, description, points)
    {
        _timesToComplete = timesToCmplete;
        _bonus = bonus;
        _completed = completed;

    }

    public override void newGoal()
    {
        base.newGoal();

        Console.Write("How many times does this goal need to be accomplished for bonus?");
        string stringTimesToComplete = Console.ReadLine();
        int timesToComplete = int.Parse(stringTimesToComplete);
        TimesToComplete = timesToComplete;

        System.Console.Write("What is the bonus for accomplishing it that many times");
        string stringBonus = Console.ReadLine();
        int bonus = int.Parse(stringBonus);
        Bonus = bonus;
        
    }

    public override string ExportGoal()
    {
        return $"CHECKLIST|{Name}{DELIMETER}{Description}{DELIMETER}{Points}{DELIMETER}{_timesToComplete}{DELIMETER}{_bonus}{DELIMETER}{_completed}";
    }


    public override void completed()
    {
        base.completed();
        TimesCompleted += 1;

        if (TimesCompleted == TimesToComplete){
            _completed = 1;
        }
        else 
        {
            _completed = 0;
        }
        
    }

    public override int addPoints()
    {   
        if (_completed == 1){
            return Points + Bonus;
        }

        else
        {
            return Points;
        }
        
    }

}
