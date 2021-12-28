using System;
using System.Linq;
namespace Open_Lab_05._04
{
    public class StringTools
    {
        public string RemoveSpecialCharacters(string original)
        {
            original = original.Replace("!", "");
            original = original.Replace("%", "");
            original = original.Replace("$", "");
            original = original.Replace("(", "");
            original = original.Replace(")", "");
            original = original.Replace(".", "");
            original = original.Replace("#", "");
            original = original.Replace("&", "");
            original = original.Replace("?", "");
            original = original.Replace("*", "");
            original = original.Replace("<", "");
            original = original.Replace(">", "");
            original = original.Replace("/", "");
            original = original.Replace("@", "");
            original = original.Replace("`", "");
            original = original.Replace("^", "");
            original = original.Replace(";", "");
            original = original.Replace(":", "");
            original = original.Replace("[", "");
            original = original.Replace("]", "");
            original = original.Replace("=", "");
            original = original.Replace(",", "");
            original = original.Replace("'", "");
            original = original.Replace("+", "");
            original = original.Replace('"'.ToString(), "");


            original = original.Replace("\\", "");

            return original;
        }
    }
}
