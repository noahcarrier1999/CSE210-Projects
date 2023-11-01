
public class ReflectionActivity : Activity{

    Random random = new Random();
    Activity activity = new Activity();

    private string _activityName = "Reflection Activity";
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";

    private List<string> _ranPrompts = new List<string>{
        "Think of a time when you did something really difficult."

    };

    private List<string> _ranQuestions = new List<string>{
        "> How did you feel when it was complete?",
        "> What is your favorite thing about this experience?",
        "> Did you learn from this?",
        "> How are you different today from this experience?",
        "> If you could go back in time to relive this experience would you and why?"


    };

    public string getRanPrompt(){
        return getRandItem(_ranPrompts);

    }

    public string getRandQuestion(){
        return getRandItem(_ranQuestions);
    }

    public string getActivityName(){
        return _activityName;
    }

    public string getDescription(){
        return _description;
    }

    public void startActivity(int seconds){
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(seconds);
        
        System.Console.WriteLine();
        System.Console.WriteLine("Now ponder each of the following questions as they relate to this experiance.");
        System.Console.WriteLine();
        Console.Write("You may begin in: ");
        countDownTimer(7);
        Console.WriteLine(); 
        System.Console.WriteLine();
        Console.Clear();
        
        while (DateTime.Now < endtime){
            
            Console.Write(getRandQuestion());
            activity.spinAnimation(seconds / 2);
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            
        }
        

    }

    public void displayMiniMenu(string ranPrompt){
        {
           Console.WriteLine("Consider the following prompt:");
           Console.WriteLine();
           Console.WriteLine($"---{ranPrompt}---"); 
           Console.WriteLine();
           System.Console.WriteLine("When you have something in mind, press enter to continue.");
           Console.ReadLine();
        }
    }


}