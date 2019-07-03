using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextToolsLib
{
    public static class WordCounter
    {
        public static int Count(string text)
        {          
            int counter = 0;
            string[] words = SplitToWords(text);

            if (words != null)
            {
                counter = words.Length;
            }

            return counter;
        }

        public static async Task<int> CountWordOcurrence(string text, string word)
        {
            int counter;
            string[] words = SplitToWords(text);

            try
            {
                counter = words.Where(w => w.Equals(word)).Count();
            }
            catch
            {
                counter = 0;
            }

            return counter;
        }

        private static string[] SplitToWords(string text)
        {
            char[] splitChars = { ' ' };
            string[] words = null;

            if (!string.IsNullOrEmpty(text))
            {
                words = text.Split(splitChars);
            }

            return words;
        }
    }
}
