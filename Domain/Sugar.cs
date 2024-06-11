using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Cookbook.Domain
{
    internal class Sugar : IIngredient
    {
        public static int ID { get; } = 5;
        public string Name { get; } = nameof(Sugar);
        public string Instruction { get; } = "Add to other ingredients.";
        public override string ToString() => Name;
    }
}
