using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[] { 2, 3, 4, 2, 3, 4, 2, 3, 4, 2, 3, 5 };

        Dictionary<int, int> frequency = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (frequency.Keys.Contains(numbers[i]))
            {
                frequency[numbers[i]]++;
            }
            else
            {
                frequency.Add(numbers[i], 1);
            }
        }

        foreach (KeyValuePair<int, int> item in frequency)
        {
            Console.WriteLine("{0}: {1} times", item.Key, item.Value);
        }
    }
}