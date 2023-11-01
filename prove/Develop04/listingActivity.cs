using System.Net;

public class ListingActivity : Activity {

    Random random = new Random();

    private string _activityName = "Listing Activity";
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";

    private List<string> _responceList = new List<string>(); 

    private List<string> _ranQuestions = new List<string>{
        "When have you felt the Holy Spirit this week",
        "What are you greatful for?",
        "What are some compliments you would give yourself",
        "What are your core values",
        "What makes you feel alive"


    };

    // public int getResponceCount(){

    //     return _responceList.Count();
    // }

    public string getRandQuestion(){
        return getRandItem(_ranQuestions);
    }

    public string getActivityName(){
        return _activityName;
    }

    public string getDescription(){
        return _description;
    }

    public void displayMiniMenu(string ranQuestion){
        
        Console.WriteLine();
        Console.WriteLine("List as many responces you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"---{ranQuestion}---"); 
        Console.WriteLine();
        System.Console.Write("You may begin in: ");
        Console.WriteLine();
        countDownTimer(5);
    }

    public void startActivity(int seconds){
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(seconds);
        
        
        while(DateTime.Now < endtime){
            Console.Write("> ");
            string responce = Console.ReadLine();
            _responceList.Add(responce);
        }

        Console.WriteLine($"You listed {_responceList.Count()} items");
        Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
    }
}