using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter positive integer numbers: ");
        do
        {
            string number = Console.ReadLine();
            if (number.Trim() == string.Empty)
            {
                break;
            }

            numbers.Add(int.Parse(number));

        } while (true);              
        
        int sumOfNumbers = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sumOfNumbers += numbers[i];
        }

        Console.WriteLine("Sum of numbers: " + sumOfNumbers);

        double average = 0;
        if (numbers.Count > 0)
        {
            average = sumOfNumbers / (double)numbers.Count;
        }

        Console.WriteLine("Average of numbers in the list: {0:.00} ", average);
    }
}
