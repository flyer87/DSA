using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 3, 5, 2, 4, 6, 6, 3, 4, 8, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };

        IList<int> maxSequence = GetMaxSequence(numbers);
        foreach (var item in maxSequence)
        {
            Console.Write("{0} ", item);
        }
    }

    private static List<int> GetMaxSequence(List<int> numbers)
    {
        int startIndex = 0;
        int count = 0;
        int bestCount = 0;

        int currentItem = numbers[0];
        int i;
        for (i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == currentItem)
            {
                count++;
            }
            else
            {
                if (count >= bestCount)
                {
                    bestCount = count;
                    startIndex = i - count;
                }

                currentItem = numbers[i];
                count = 1;
            }
        }

        if (count >= bestCount)
        {
            startIndex = i - count;
            bestCount = count;
        }

        return numbers.GetRange(startIndex, bestCount);
    }
}
