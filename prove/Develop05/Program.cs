using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
namespace GoalTracker;

class Program
{
    

    static void Main(string[] args)
    {
        

        GoalList goalList = new GoalList(); 
        Goal goal = new Goal(" "," ",0);
        
        


        while (true){
            int TotalPoints = 0;

            System.Console.WriteLine($"Your Total Points: {TotalPoints}");
            System.Console.WriteLine("Menu Options:");
            System.Console.WriteLine("1. Create New Goal");
            System.Console.WriteLine("2. List Goals");
            System.Console.WriteLine("3. Save Goals");
            System.Console.WriteLine("4. Load Goals");
            System.Console.WriteLine("5. Record Event");
            System.Console.WriteLine("6. Quit");
            

            Console.Write("Select a choice from the menu:");
            string choice = Console.ReadLine();

            //Create Goal
            if (choice == "1"){
                System.Console.WriteLine("The types of Goals are:");
                System.Console.WriteLine("1. Simple Goal");
                System.Console.WriteLine("2. Eternal Goal");
                System.Console.WriteLine("3. Checklist Goal");


                Console.Write("Which type of goal would you like to create? ");
                string responce = Console.ReadLine();

                if (responce == "1"){
                
                    SimpleGoal simpleGoal = new SimpleGoal("","",0,0);
                    simpleGoal.newGoal();
                    goalList.AddGoal(simpleGoal);


                }

                else if (responce == "2"){
                
                    EternalGoal eternalGoal = new EternalGoal("","",0);
                    eternalGoal.newGoal();
                    goalList.AddGoal(eternalGoal);
                

                }

                else if (responce == "3"){
                
                    ChecklistGoal checklistGoal = new ChecklistGoal("","",0,0,0,0);
                    checklistGoal.newGoal();
                    goalList.AddGoal(checklistGoal);
                
                }
            }
            //List Goals
            else if (choice == "2"){
                goalList.DisplayGoals();
                
            }
            //Save Goals
            else if (choice == "3"){
                goalList.SaveGoals();
            }
            //Load Goals
            else if (choice == "4"){
                goalList.LoadGoals();
            }
            //Record Event
            else if (choice == "5"){

                

                goalList.RecordEvent();
                TotalPoints = CalculateTotalPoints(goalList.Goals);

                Console.WriteLine($"Your total points: {TotalPoints}");

                
                
            }
            //Quit
            else if (choice == "6"){
                
                break;
            }
            
        }

    }


    static int CalculateTotalPoints(List<Goal> goals)
    {
        int total = 0;
        foreach (Goal goal in goals)
        {
            total += goal.addPoints();
        }
        return total;
    }


}