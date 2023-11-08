using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        System.Console.WriteLine(
        @"Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit");

        Console.Write("Select a choice from the menu:");
        string choice = Console.ReadLine();

        if (choice == "1"){
            System.Console.WriteLine(@"
The types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
            ");

            Console.Write("Which type of goal would you like to create? ");
            string responce = Console.ReadLine();

            if (responce == "1"){

            }

            else if (responce == "2"){

            }

            else if (responce == "3"){
                
            }
        }

        else if (choice == "2"){

        }

        else if (choice == "3"){

        }

        else if (choice == "4"){

        }

        else if (choice == "5"){

        }

        else if (choice == "6"){

        }
    }
}