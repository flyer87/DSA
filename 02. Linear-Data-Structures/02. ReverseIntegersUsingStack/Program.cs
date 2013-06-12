using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers to reverse! Enter for end!");
        Stack<int> numbersToRevers = new Stack<int>();
        do
        {
            string number = Console.ReadLine();
            if (number.Trim() == string.Empty)
            {
                break;
            }

            numbersToRevers.Push(int.Parse(number));

        } while (true);

        StringBuilder numbersToPrint = new StringBuilder();
        Console.WriteLine("Reversed: ");
        while (numbersToRevers.Count > 0)
        {
            int number = numbersToRevers.Pop();
            numbersToPrint.AppendFormat("{0} ", number);
        }

        Console.WriteLine(numbersToPrint.ToString());
    }
}
