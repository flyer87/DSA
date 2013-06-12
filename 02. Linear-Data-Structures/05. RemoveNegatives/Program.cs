using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegatives
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 3, -5, 2, 4, 6, 6, 3, 4, 8, -5, 0, -5, -5, };
        numbers.RemoveAll(Negatives);

        Console.WriteLine("After removing negatives: ");
        foreach (int number in numbers)
        {
            Console.Write("{0} ", number);
        }

        Console.WriteLine();
    }

    private static bool Negatives(int number)
    {
        return number < 0 ? true : false;
    }
}