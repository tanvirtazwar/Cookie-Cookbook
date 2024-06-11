using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Cookbook.Domain
{
    internal interface IIngredient
    {
        public static int ID { get; }
        public string Name { get; }
        public string Instruction { get; }
        public string ToString();
    }
}
