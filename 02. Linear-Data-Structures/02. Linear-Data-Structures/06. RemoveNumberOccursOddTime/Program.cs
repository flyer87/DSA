using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        IDictionary<int, int> numbers = new Dictionary<int, int>();

        Console.WriteLine("Enter integer numbers: ");
        do
        {
            string number = Console.ReadLine();
            if (number.Trim() == string.Empty)
            {
                break;
            }

            int intNumber = int.Parse(number);
            if (numbers.Keys.Contains(intNumber))
            {
                numbers[intNumber]++;
            }
            else
            {
                numbers.Add(intNumber, 1);
            }

        } while (true);

        IList<int> evenOccuersNumbers = numbers.Where(pair => (pair.Value % 2 == 0)).Select(pair => pair.Key).ToList();

        Console.WriteLine("Numbers that occur even number of times: ");
        foreach (int number in evenOccuersNumbers)
        {
            Console.Write("{0} ", number);
        }

        Console.WriteLine();
    }
}
