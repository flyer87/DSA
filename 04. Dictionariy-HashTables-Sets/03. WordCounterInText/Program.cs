using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"../../words.txt";
        StreamReader inputFile = new StreamReader(filePath);
        using (inputFile)
        {
            string text = inputFile.ReadToEnd();
            char[] separators = new char[] { ' ', '.', ',', '!', '–', '?', '-', '–' };
            string[] words = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            //string[] words = Regex.Split(text.ToLower(), "[^a-zA-Z]+", RegexOptions.IgnorePatternWhitespace);

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!wordsCount.ContainsKey(word.Trim()))
                {
                    wordsCount.Add(word.Trim(), 1);
                }
                else
                {
                    wordsCount[word.Trim()]++;
                }
            }

            IOrderedEnumerable<KeyValuePair<string, int>> orderedWordsCount = 
                wordsCount.OrderBy(keyValuePair => keyValuePair.Value);
                    //ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var pair in orderedWordsCount)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }

    }
}
