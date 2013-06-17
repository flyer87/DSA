using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        PriorityQueue<int> queue = new PriorityQueue<int>();
        //queue.Enqueue(1);
        //queue.Enqueue(10);
        //queue.Enqueue(100);
        //queue.Enqueue(200);
        //queue.Enqueue(2000);

        queue.Enqueue(11);
        queue.Enqueue(5);
        queue.Enqueue(8);
        queue.Enqueue(3);
        queue.Enqueue(4);

        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
    }
}