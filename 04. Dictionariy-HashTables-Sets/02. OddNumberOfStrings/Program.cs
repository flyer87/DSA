using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string wordsAsString = "C#, SQL, PHP, PHP, SQL, SQL";
        string[] words = wordsAsString.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordsCount = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (!wordsCount.ContainsKey(words[i].Trim()))
            {
                wordsCount.Add(words[i].Trim(), 1);
            }
            else
            {
                wordsCount[words[i].Trim()]++;
            }
        }

        foreach (var word in wordsCount)
        {
            if ((word.Value % 2) != 0)
            {
                Console.WriteLine("{0}", word.Key);
            }
        }

        Console.WriteLine();
    }
}
