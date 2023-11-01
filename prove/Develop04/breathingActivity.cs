using System.Collections.Concurrent;

public class BreathingActivity : Activity{
    private string _activityName = "breathing activity";
    private string _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";

    // public BreathingActivity(string activity, string description): base(activity,description){
        
    // }

    public string getActivityName(){
        return _activityName;
    }

    public string getDescription(){
        return _description;
    }

    public void startActivity(int seconds){
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endtime){
            System.Console.WriteLine();
            System.Console.Write("Breath in  ");
            countDownTimer(4);
            System.Console.WriteLine();

            System.Console.WriteLine();
            System.Console.Write("Hold  ");
            countDownTimer(7);
            System.Console.WriteLine(); 
            
            System.Console.WriteLine();
            System.Console.Write("Breath out slowly  ");
            countDownTimer(8);
            System.Console.WriteLine();
        }
    }

    
}