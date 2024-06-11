using Cookie_Cookbook.Data;
using Cookie_Cookbook.Domain;
using Cookie_Cookbook.FileAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Cookbook.Controller
{
    internal static class Recipe
    {
        private static readonly Dictionary<int, IIngredient> IngredientList = Ingredient.GetIngredientList();

        private static List<int> CreateReciprList()
        {
            List<int> list = [];
            Console.WriteLine("\nAdd an ingredient by its ID or type anything else if finished.");
            if (int.TryParse(Console.ReadLine(), out int x))
            {
                if (IngredientList.ContainsKey(x))
                {
                    list.Add(x);
                }
                list.AddRange(CreateReciprList());
            }
            return list;
        }
        public static void UpdateListOfRecipeList(string fileName, List<List<int>> listOfRecipeList)
        {
            List<int> recipeList = CreateReciprList();
            if (recipeList.Count > 0 && listOfRecipeList != null)
            {
                listOfRecipeList.Add(recipeList);
                TextRecipeConversion.RecipeToText(fileName, listOfRecipeList);
                Console.WriteLine("\nRecipe added :");
                Print.PrintReciprList(recipeList);
            }
            else
            {
                Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
            }
        }
    }
}
