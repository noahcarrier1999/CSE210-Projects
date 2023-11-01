using System.Runtime.Intrinsics.Arm;

public class Activity{
    
    Random random = new Random();

    private string _activityname;

    private string _description;


    // public Activity(string activityName, string description){
    //     _activityname = activityName;
    //     _description = description;
    // }
    // Displays the menu and returns the responce
    public string displayMenu(){
        string menu =@"
Menu Options:
    1. Start breathing activity
    2. Start reflection activity
    3. Start listing activity
    4. Quit
            ";

        Console.Clear();
        System.Console.WriteLine(menu);
        System.Console.Write("Select a choice frome the menu: ");
        string responce = Console.ReadLine();

        return responce;
        
    }

    //Displays the intro
    public int displayIntro(string activity, string description){
        
        Console.Clear();
        string display = @$"Welcome to the {activity}.
        
{description}
";

        Console.WriteLine(display);
        System.Console.WriteLine("How long, in seconds, would you like for your session?");
        string stringTime = Console.ReadLine();
        int time = int.Parse(stringTime);

        return time;

    }

    public void spinAnimation(int seconds){
        List<string> spinnerAnimations = new List<string>{
            "/","-","\\","|"
        };

        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endtime){
            
            foreach(string i in spinnerAnimations){
                Console.Write(i);
                Thread.Sleep(500);
                Console.Write("\b \b");
        };

        }


    }

    public string getRandItem(List<string> list){
        int countOfList = list.Count;
        int ranNum = random.Next(countOfList);
        string item = list[ranNum];
        return item;

    }

    public void getReady(){
         
        Console.Clear();
        Console.WriteLine("Get ready...");
        spinAnimation(4);
         
    }

    public void finished(int seconds, string activityName){
      
        Console.Clear();
        Console.Write("Well done!!");
        
        spinAnimation(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed {seconds} seconds of the {activityName}");
        
        spinAnimation(2);

    }

    public void countDownTimer(int seconds){
        for (int i = seconds; i > 0; i--){
            Console.CursorVisible = false;
            Console.Write($"{i}");
            Thread.Sleep(1000);
            System.Console.Write("\b \b");
        }  
        Console.CursorVisible = true;
     }
   

}
