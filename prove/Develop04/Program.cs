using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        
        Activity activity = new Activity();
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();
        

        while(true){

            string responce = activity.displayMenu();

            if (responce == "1"){ 
                string activityName = breathingActivity.getActivityName();
                string description = breathingActivity.getDescription();
                int seconds = breathingActivity.displayIntro(activityName,description);

                breathingActivity.getReady();
                breathingActivity.startActivity(seconds);
                breathingActivity.finished(seconds, activityName);
                
            }

            else if (responce == "2"){
                string activityName = reflectionActivity.getActivityName();
                string description = reflectionActivity.getDescription();
                int seconds = reflectionActivity.displayIntro(activityName, description);
                string randPrompt = reflectionActivity.getRanPrompt();

                reflectionActivity.getReady();
                
                reflectionActivity.displayMiniMenu(randPrompt);
                
                reflectionActivity.startActivity(seconds);

                reflectionActivity.finished(seconds , activityName);

            }
            else if (responce == "3"){
                string activityName = listingActivity.getActivityName();
                string description = listingActivity.getDescription();
                int seconds = listingActivity.displayIntro(activityName, description);
                string ranQuestion = listingActivity.getRandQuestion();


                listingActivity.getReady();
                
                listingActivity.displayMiniMenu(ranQuestion);

                listingActivity.startActivity(seconds);

                listingActivity.finished(30 , activityName);
            }
            else if(responce == "4"){
                break;
            }
        }
        

    }
}
