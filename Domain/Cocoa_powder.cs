using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Cookbook.Domain
{
    internal class Cocoa_powder : IIngredient
    {
        public static int ID { get; } = 8;
        public string Name { get; } = nameof(Cocoa_powder).Replace("_", " ");
        public string Instruction { get; } = "Add to other ingredients.";
        public override string ToString() => Name;
    }
}
