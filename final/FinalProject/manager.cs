




using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

public class Manager{

    //variables
    //methods
    public void DisplayMenu(){
        System.Console.WriteLine("Manager");
        System.Console.WriteLine("1. Add");
        System.Console.WriteLine("2. remove");
        System.Console.WriteLine("3. Search");
        System.Console.WriteLine("4. quit");

    }

    public void GetResponse(){
        System.Console.Write("What would you like to do?");
        string response = Console.ReadLine();
        
        //Add
        if (response == "1"){
            
        }
        //remove
        else if (response == "2"){

        }
        //search
        else if (response == "3"){

        }
        //quit
        else if (response == "4"){

        }
        else{
            
            System.Console.WriteLine("Invalid Response");
        }


    }

}