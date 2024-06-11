using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Cookbook.Domain
{
    internal class Coconut_flour : IIngredient
    {
        public static int ID { get; } = 2;
        public string Name { get; } = nameof(Coconut_flour).Replace("_", " ");
        public string Instruction { get; } = "Sieve. Add to other ingredients.";
        public override string ToString() => Name;
    }
}
