using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        LinkedQueue<int> queue = new LinkedQueue<int>();

        queue.Enqueue(5);
        queue.Enqueue(2);
        queue.Enqueue(23);

        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        int lastItem = queue.Dequeue(); // throws InvalidOperationException: Queue is empty

        Console.WriteLine(lastItem);
    }
}
