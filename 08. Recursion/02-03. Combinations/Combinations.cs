using System;
using System.Collections.Generic;

class Combinations
{
    // Zadacha 2. i zadacha 3. 
    static void Main()
    {
        int n = 2;
        int startNum = 1;
        int endNum = 4;
        int[] vector = new int[n];

        // GenerateCombinationsWithDuplicates(vector, 0, startNum, endNum); // zadacha 2.

        GenerateCombinationsWithouthDuplicates(vector, 0, startNum, endNum); // zadacha 3.
    }

    static void GenerateCombinationsWithDuplicates(int[] arr, int index, int startNum, int endNum)
    {
        if (index >= arr.Length)
        {
            Print(arr);
            return;
        }

        for (int i = startNum; i <= endNum; i++)
        {
            arr[index] = i;
            GenerateCombinationsWithDuplicates(arr, index + 1, i, endNum);
        }

    }

    static void GenerateCombinationsWithouthDuplicates(int[] arr, int index, int startNum, int endNum)
    {
        if (index >= arr.Length)
        {
            Print(arr);
            return;
        }

        for (int i = startNum; i <= endNum; i++)
        {
            arr[index] = i;
            GenerateCombinationsWithouthDuplicates(arr, index + 1, i + 1, endNum);

        }

    }

    static void Print(int[] array)
    {
        Console.WriteLine("( " + string.Join(", ", array) + " )");
    }
}
