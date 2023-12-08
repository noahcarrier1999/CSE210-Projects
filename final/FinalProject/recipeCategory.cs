

public class RecipeCategory
{
    private string _categoryName {get; set;}
    private List<Recipe> _recipesInCategory {get; set;}

    public void addRecipeToCategory(Recipe recipe){
        _recipesInCategory.Add(recipe);
    }



}