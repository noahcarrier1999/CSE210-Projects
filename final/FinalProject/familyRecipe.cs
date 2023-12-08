


public class FamilyRecipe:Recipe{

    private string _owner;
    
    public string Owner {get => _owner;}

    public FamilyRecipe(string Name, List<Ingredient> Ingredients, string Description ) :base(Name,Description){
        _owner = Owner;
    }

    
}