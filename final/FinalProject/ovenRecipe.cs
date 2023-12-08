



public class OvenRecipe:Recipe{

    private int _ovenTemp;
    private string _ovenTime;

    public int OvenTemp {get => _ovenTemp;}
    public string OvenTime {get => _ovenTime;}

    public OvenRecipe(string Name, List<Ingredient> Ingredients, string Description, int OvenTemp, string OvenTime) :base(Name,Description){

        _ovenTemp = OvenTemp;
        _ovenTime = OvenTime;
    }

   
    public override void Display() {
        Console.WriteLine($"Recipe: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Oven Temperature: {OvenTemp}°F");
        Console.WriteLine($"Oven Time: {OvenTime}");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in Ingredients) {
            Console.WriteLine($"{ingredient.Amount} {ingredient.Unit} of {ingredient.IngName}");
        }
        Console.WriteLine("------------------------------");
    }
}