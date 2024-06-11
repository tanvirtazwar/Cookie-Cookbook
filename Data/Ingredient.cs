using Cookie_Cookbook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Cookbook.Data
{
    internal static class Ingredient
    {
        private static Dictionary<int, IIngredient> IngredientList =>
            new()
            {
                { Wheat_flour.ID , new Wheat_flour() },
                { Coconut_flour.ID , new Coconut_flour() },
                { Butter.ID , new Butter() },
                { Chocolate.ID , new Chocolate() },
                { Sugar.ID , new Sugar() },
                { Cardamom.ID , new Cardamom() },
                { Cinnamon.ID , new Cinnamon() },
                { Cocoa_powder.ID , new Cocoa_powder() }
            };
        public static Dictionary<int, IIngredient> GetIngredientList()
        {
            return IngredientList;
        }
    }
}
