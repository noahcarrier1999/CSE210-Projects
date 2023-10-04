using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string input = "";
        
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to The Journal Program");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Please select one of the following choices.");
            System.Console.WriteLine("1. Write");
            System.Console.WriteLine("2. Display");
            System.Console.WriteLine("3. Load");
            System.Console.WriteLine("4. Save");
            System.Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            Console.WriteLine();
            
            input = Console.ReadLine();
            Console.WriteLine();
        

            if (input == "1"|| input == "Write")
            {
                //gets a random prompt
            
                string prompt = promptGenerator.GetRandomPrompt();
                
                //displays the prompt
                System.Console.WriteLine($"Prompt: {prompt}");

                //allows user to right a responce
                System.Console.Write("Enter a Responce: ");
                string ?responce = Console.ReadLine();

                DateTime date = DateTime.Now;

                journal.AddEntry(date,prompt,responce);
            }
            else if (input == "2" || input == "Display")
            {
                journal.DisplayAllEntries();
            }
            else if (input == "3" || input == "Load")
            {
                System.Console.Write("What File do you want to load from: ");
                string filepath = Console.ReadLine();
                journal.LoadFromFile(filepath);
            }
            else if (input == "4" || input == "Save")
            {
                Console.Write("What File do you want to save to: ");
                string filepath = Console.ReadLine();
                journal.SaveToFile(filepath);
            }
            else if (input == "5" || input == "quit")
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Please try another option?");
            }
        
        }

        System.Console.WriteLine("Thank You for Journaling");

    }
}
