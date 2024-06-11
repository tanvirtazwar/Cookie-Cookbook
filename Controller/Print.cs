using Cookie_Cookbook.Data;
using Cookie_Cookbook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Cookbook.Controller
{
    internal static class Print
    {
        private static readonly Dictionary<int, IIngredient> IngredientList = Ingredient.GetIngredientList();
        public static void PrintIngredientList()
        {
            Console.WriteLine("Create a newcookie recipe! Available ingredients are:");
            foreach (var item in IngredientList)
            {
                Console.WriteLine(item.Key + "." + item.Value);
            }
        }
        public static void PrintReciprList(List<int> list)
        {
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(IngredientList[item] + "." + IngredientList[item].Instruction);
                }
            }
        }
        public static void PrintListOfRecipeList(List<List<int>> listOfRecipeList)
        {
            if (listOfRecipeList != null && listOfRecipeList.Count > 0)
            {
                Console.WriteLine("Existing recipes are:");
                for (int i = 0; i < listOfRecipeList.Count; i++)
                {
                    Console.WriteLine($"*******{i + 1}*******");
                    PrintReciprList(listOfRecipeList[i]);
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
