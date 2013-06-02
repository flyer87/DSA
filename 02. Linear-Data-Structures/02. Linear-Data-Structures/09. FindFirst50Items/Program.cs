using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        const int generatedNumbers = 50;

        Console.WriteLine("First number: ");
        int firstItem = int.Parse(Console.ReadLine());

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(firstItem);

        int countOfNumbers = 1;
        StringBuilder output = new StringBuilder();
        output.AppendFormat("{0} ", firstItem);

        while (countOfNumbers < generatedNumbers)
        {
            int number = queue.Dequeue();

            queue.Enqueue(number + 1);
            queue.Enqueue(2 * number + 1);
            queue.Enqueue(number + 2);

            output.AppendFormat("{0} ", number + 1);
            output.AppendFormat("{0} ", 2 * number + 1);
            output.AppendFormat("{0} ", number + 2);

            countOfNumbers += 3;
        }

        Console.WriteLine(output.ToString());        
    }
}