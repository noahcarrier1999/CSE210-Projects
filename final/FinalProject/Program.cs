using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
           
        var recipeManager = new RecipeManager();

        var familyRecipe = new FamilyRecipe("Mom's Spaghetti", new List<Ingredient>(), "Mom");
        familyRecipe.AddIngredient(new Ingredient { IngName = "Spaghetti", Amount = 200, Unit = "g" });
        familyRecipe.AddIngredient(new Ingredient { IngName = "Tomato Sauce", Amount = 1, Unit = "can" });
        recipeManager.AddRecipe(familyRecipe);

        var ovenRecipe = new OvenRecipe("Garlic Bread", new List<Ingredient>(),"Put garlic and butter on the bread then put it in the oven", 350, "15 minutes");
        ovenRecipe.AddIngredient(new Ingredient { IngName = "Bread", Amount = 5, Unit = "pieces" });
        ovenRecipe.AddIngredient(new Ingredient { IngName = "Butter", Amount = 1 / 2, Unit = "cup" });
        ovenRecipe.AddIngredient(new Ingredient { IngName = "Garlic", Amount = 3, Unit = "cloves" });
        recipeManager.AddRecipe(ovenRecipe);

        var dessertRecipe = new DessertRecipe("Chocolate Cake", new List<Ingredient>(), "Delicious chocolate cake recipe");
        dessertRecipe.AddIngredient(new Ingredient { IngName = "Chocolate", Amount = 200, Unit = "g" });
        dessertRecipe.AddIngredient(new Ingredient { IngName = "Flour", Amount = 150, Unit = "g" });
        recipeManager.AddRecipe(dessertRecipe);

        recipeManager.DisplayRecipes();
    }

        
}
