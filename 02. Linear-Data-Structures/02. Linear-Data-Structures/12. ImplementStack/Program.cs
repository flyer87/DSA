using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        MyStack<int> stack = new MyStack<int>();
        stack.Push(5);
        stack.Push(10);
        stack.Push(8);
        int number = stack.Pop();
        number = stack.Peak();
        Console.WriteLine(number);
    }
}