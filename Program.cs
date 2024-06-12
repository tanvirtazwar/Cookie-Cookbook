using Cookie_Cookbook.Controller;
using Cookie_Cookbook.FileAccess;

TextFormat fileType = TextFormat.Txt;
string fileName = FileType.ResturnType(fileType);
List<List<int>>? listOfRecipeList = [];
if (File.Exists(fileName))
{
    listOfRecipeList = TextRecipeConversion.TextToRecipe(fileName);
    Print.PrintListOfRecipeList(listOfRecipeList);
}
Print.PrintIngredientList();
Recipe.UpdateListOfRecipeList(fileName, listOfRecipeList);
