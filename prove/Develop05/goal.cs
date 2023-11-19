using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Runtime.InteropServices;
namespace GoalTracker;

public class Goal{
    public readonly string DELIMETER = "|";

    private string _name;
    private string _description;
    private int _totalPoints;
    private int _points;
    private bool _completed = false;
    private string _type = "";

    public Goal(string type, string name, string description, int points, int totalPoints){
         _name = name;
         _description = description;
         _points = points;
         _totalPoints = totalPoints;
         _type = type;
     }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }
    
    public string Type
    {
        get {return _type;}
        set { _type = value;}
    }



    public string Name
    {
        get {return _name;}
        set { _name = value;}
    }

    public void Completed(){
        _completed = true;
    }
    

    public string Description
    {
        get {return _description;}
        set { _description = value;}
    }

    public int Points
    {
        get {return _points;}
        set { _points = value;}
    }

    public int TotalPoints
    {
        get{return _totalPoints;}
        set{_totalPoints = value;}
    }


    public virtual void newGoal(){
        
        // Declaring the name
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Name = name;

        //Declaring the description
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Description = description;

        Console.Write("What is the amount of points associated with this goal? ");
        string stringPoints = Console.ReadLine();
        int points = int.Parse(stringPoints);
        Points = points;

    }

    public void DisplayPoint(){

        Console.WriteLine($"You have {_totalPoints} points.");
    }

    public virtual string ExportGoal(){
        return $"{_name}{DELIMETER}{_description}{DELIMETER}{_points}";

    }

    public virtual void completed(){

        if (_completed == true){
            Console.Write("[X]");
            
        }
        else
        {
            Console.Write("[ ]");
            
        }
    }

    public virtual int addPoints(){
        return _completed ? _points: 0;
    }
}