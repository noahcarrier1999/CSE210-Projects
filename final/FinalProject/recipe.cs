



public class Recipe{

    //Variables
    private string _name;
    private List<string> _ingredients;
    private string _description;

    public Recipe(string Name, List<string> Ingredients, string Description){
        
        _name = Name;
        _ingredients = Ingredients;
        _description = Description;

    }

    public string Name{

        get{return _name;}
        set{_name = value;}
    }

    public List<string> Ingredients{
        
        get{return _ingredients;}
        set{_ingredients = value;}
    }

    public string Description{
        
        get{return _description;}
        set{_description = value;}
    }

//    public string DisplayRecipe(){
        
//    }

}