using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_2sem
{
    public static class TextOperations
    {
        public static string ToUpperCase(string text)
        {
            return text.ToUpper();
        }
        public static string CountCharacters(string text)
        {
            return $"Кількість символів: {text.Length}";
        }
        public static string CountWords(string text)
        {
            var words = text.Split(new char[] { ' ', '\t', '\n' });
            return $"Кількість слів: {words.Length}";
        }
    }
}
