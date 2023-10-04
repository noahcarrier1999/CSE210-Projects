using System.ComponentModel;

public class PromptGenerator
{
    List<string> prompts = new List<string>
    {
        "Who was the most interesting person you interacted with today, and why?",
        "What was the most challenging decision you made today?",
        "Identify a moment today where you felt in 'flow'. Describe the activity and your feelings.",
        "What's one skill you used today that you want to improve?",
        "Name a moment today that you would like to remember five years from now."
    };
    

    Random random = new Random();

    public string GetRandomPrompt()
    {
        int randomIndex = random.Next(prompts.Count);
        string randomPrompt = prompts[randomIndex];
        return randomPrompt;
    }
}
    

