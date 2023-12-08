




using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

public class RecipeManager{
    
    private List<Recipe> Recipes {get; set;}


    public RecipeManager()
    {
        Recipes = new List<Recipe>();
    }

    //methods
    // public void DisplayMenu(){
        
    //     while(true){

           
    //         Console.Clear();
    //         System.Console.WriteLine("Manager");
    //         System.Console.WriteLine("1. Add");
    //         System.Console.WriteLine("2. See Recipe");
    //         System.Console.WriteLine("3. Search");
    //         System.Console.WriteLine("4. quit");

    //         System.Console.Write("What would you like to do? ");
    //         string response = Console.ReadLine();
            
    //         //Add
    //         if (response == "1"){

    //             addRecipe();
                
    //         }
    //         //See Recipe
    //         else if (response == "2"){
    //             seeRecipe();
        
    //         }

    //         //search
    //         else if (response == "3"){

    //         }
    //         //quit
    //         else if (response == "4"){
    //             break;
    //         }
    //         else{
                
    //             System.Console.WriteLine("Invalid Response");

    //         }

    //     }

    // }

    public void AddRecipe(Recipe recipe){

        Recipes.Add(recipe);

    }

    public void DisplayRecipes(){
        foreach (var recipe in Recipes){
            recipe.Display();
        }
    }


    }

