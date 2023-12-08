



public class Recipe{

    //Variables.
    private string _name;
    private string _description;
    private List<Ingredient> _ingredients;

    public string Name { get => _name;}
    public string Description { get => _description; }
    public IReadOnlyList<Ingredient> Ingredients { get => _ingredients.AsReadOnly(); }
    

    public Recipe(string Name, string Description){
        
        _name = Name;
        _description = Description;
        _ingredients = new List<Ingredient>();
        

    }


    public void AddIngredient(Ingredient ingredient){
        _ingredients.Add(ingredient);
    }

    public virtual void Display() {
        Console.WriteLine($"Recipe: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in Ingredients) {
            Console.WriteLine($"{ingredient.Amount} {ingredient.Unit} of {ingredient.IngName}");
        }
        Console.WriteLine("------------------------------");
    }

}