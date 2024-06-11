using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cookie_Cookbook.FileAccess
{
    internal static class TextRecipeConversion
    {
        public static List<List<int>> TextToRecipe(string fileName)
        {
            List<List<int>> listOfRecipeList = [];
            string recipeString = File.ReadAllText(fileName);
            List<List<int>>? tempList = JsonSerializer.Deserialize<List<List<int>>>(recipeString);
            if (tempList != null)
            {
                listOfRecipeList = tempList;
            }
            return listOfRecipeList;
        }

        public static void RecipeToText(string fileName, List<List<int>> listOfRecipeList)
        {
            string recipeString = JsonSerializer.Serialize(listOfRecipeList);
            File.WriteAllText(fileName, recipeString);
        }
    }
}
