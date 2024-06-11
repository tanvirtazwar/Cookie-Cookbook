using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Cookbook.Domain
{
    internal class Butter : IIngredient
    {
        public static int ID { get; } = 3;
        public string Name { get; } = nameof(Butter);
        public string Instruction { get; } = "Melt on lowheat. " +
            "Add to other ingredients.";
        public override string ToString() => Name;
    }
}
