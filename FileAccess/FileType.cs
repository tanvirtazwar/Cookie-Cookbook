using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Cookbook.FileAccess
{
    internal static class FileType
    {
        public static string ResturnType(TextFormat textFormat)
        {
            if (textFormat is TextFormat.Txt) return "recipe.txt";
            else if (textFormat is TextFormat.Json) return "recipe.json";
            throw new NotImplementedException();
        }
    }

    public enum TextFormat
    {
        Txt,
        Json
    }
}
