using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        // numbers.Sort();

        IList<int> sortedNumbers = numbers.OrderBy(x => x).ToList();

        Console.WriteLine("Sorted: ");
        foreach (var number in sortedNumbers)
        {
            Console.Write("{0} ", number);
        }
    }
}
