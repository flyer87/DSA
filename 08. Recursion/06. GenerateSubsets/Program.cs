using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] strArray = new string[] { "test", "rock", "fun" };
        string[] result = new string[2];
        GenerateSubsets(result, 0, 0, strArray);
    }

    private static void GenerateSubsets(string[] result, int index, int startIndex, string[] strArray)
    {
        if (index == result.Length)
        {
            Print(result);
            return;
        }

        for (int i = startIndex; i < strArray.Length; i++)
        {
            result[index] = strArray[i];
            GenerateSubsets(result, index + 1, i + 1, strArray);
        }
    }

    private static void Print(string[] strArray)
    {
        Console.WriteLine("{" + string.Join(",", strArray) + "}");
    }
}
