using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Cookbook.Domain
{
    internal class Cardamom : IIngredient
    {
        public static int ID { get; } = 6;
        public string Name { get; } = nameof(Cardamom);
        public string Instruction { get; } = "Take half a teaspoon. " +
                "Add to other ingredients.";
        public override string ToString() => Name;
    }
}
