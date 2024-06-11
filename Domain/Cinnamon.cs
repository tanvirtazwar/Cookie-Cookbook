using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Cookbook.Domain
{
    internal class Cinnamon : IIngredient
    {
        public static int ID { get; } = 7;
        public string Name { get; } = nameof(Cinnamon);
        public string Instruction { get; } = "Take half a teaspoon. " +
                "Add to other ingredients.";
        public override string ToString() => Name;
    }
}
