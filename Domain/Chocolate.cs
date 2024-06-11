using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Cookbook.Domain
{
    internal class Chocolate : IIngredient
    {
        public static int ID { get; } = 4;
        public string Name { get; } = nameof(Chocolate);
        public string Instruction { get; } = "Melt in awater bath. " +
                "Add to other ingredients.";
        public override string ToString() => Name;
    }
}
