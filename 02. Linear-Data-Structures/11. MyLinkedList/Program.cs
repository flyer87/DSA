using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        MyLinkedList<int> linkedList = new MyLinkedList<int>();
        linkedList.AddFirst(1);
        linkedList.AddFirst(2);
        linkedList.AddLast(3);
        linkedList.RemoveFirst();
    }
}
