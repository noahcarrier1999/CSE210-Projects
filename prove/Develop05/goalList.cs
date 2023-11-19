
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

namespace GoalTracker;

public class GoalList{


    private List<Goal> _goals = new List<Goal>();

    public List<Goal> Goals{
        get{return _goals;}
        set{_goals = value;}
    }

    public void AddGoal(Goal goal){
        _goals.Add(goal);
    }

    public string ExportList(){
        string exportedList = "";
        foreach (Goal item in _goals){
            exportedList += item.ExportGoal() + "\n";
        }
        return exportedList;
    }


    public virtual void DisplayGoals(){

        int number = 1;

        foreach (Goal item in _goals){
            
            Console.Write($"{number}.");
            item.completed();
            Console.WriteLine($"{ item.Name} ({item.Description})");

            if (item is ChecklistGoal checklistGoal)
            {
                Console.Write("--Completed");
                Console.Write($"{checklistGoal.TimesCompleted}/{checklistGoal.TimesToComplete} goals");
            }

            System.Console.WriteLine();
            number += 1;
        }

    }

    public virtual void RecordEvent(){
    

        System.Console.WriteLine("The Goals are:");
        
        int number =  1;
        foreach( Goal item in _goals){
            
            
            Console.Write($"{number}.");
            Console.WriteLine($"{ item.Name}");
            number += 1;

        }
        
        System.Console.WriteLine("Which Goal did you accomplish");
        string stringAnswer = Console.ReadLine();
        int Answer = int.Parse(stringAnswer);

        
        foreach (Goal item in _goals){
            int placeOfGoal = _goals.IndexOf(item);
            if( Answer-1 == placeOfGoal){
                item.Completed();
            }
        }
    }

    public virtual void SaveGoals(){
        string filePath = "goals.txt";

        string exportedContent = ExportList();

        using (StreamWriter writer = new StreamWriter(filePath)){
            writer.Write(exportedContent);
        }

    }

    public virtual void LoadGoals(){
        string filePath = "goals.txt";

        

        using (StreamReader reader = new StreamReader(filePath)){
            string line;
            while((line = reader.ReadLine()) != null){
                string[] values = line.Split("|");
                if (values.Length> 0){
                    string type = values[0];

                    if(type =="CHECKLIST"){
                        string name = values[1];
                        string description = values[2];
                        int points = int.Parse(values[3]);
                        int timesToComplete = int.Parse(values[4]);
                        int bonus = int.Parse(values[5]);
                        int completed = int.Parse(values[4]);
                        

                        ChecklistGoal checklistGoal = new ChecklistGoal(name,description,points,timesToComplete,bonus,completed);
                        _goals.Add(checklistGoal);
                    }
                    else if (type == "SIMPLE"){
                        string name = values[1];
                        string description = values[2];
                        int points = int.Parse(values[3]);
                        int completed = int.Parse(values[4]);

                        SimpleGoal simpleGoal = new SimpleGoal(name,description,points,completed);
                        _goals.Add(simpleGoal);
                    }
                    else if (type == "ETERNAL"){
                        string name = values[1];
                        string description = values[2];
                        int points = int.Parse(values[3]);
                        

                        EternalGoal eternalGoal = new EternalGoal(name,description,points);
                        _goals.Add(eternalGoal);
                    }
                }
            }
        }

    }

}