using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {

            // summarising really long text
            if (text.Length < maxLength)
                return text;
            else
            {
                var words = text.Split(" ");
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1; // + 1 accounts for whitespace
                    if (totalCharacters > maxLength)
                        break;
                }

                var summary = String.Join(" ", summaryWords) + "...";
                return summary;
            }
        }
    }
}
