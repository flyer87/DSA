using System;
using System.Collections.Generic;
using System.Text;

class LinkedQueue<T>
{
    private QueueNode<T> head;
    private QueueNode<T> tail;
    private int count;

    public void Enqueue(T item)
    {
        QueueNode<T> newItem = new QueueNode<T>(item);
        if (head == null)
        {
            head = newItem;
            tail = newItem;
        }
        else
        {            
            tail.NextItem = newItem;
            tail = newItem;
        }

        count++;
    }

    public T Dequeue()
    {
        if (head != null)
        {
            T value = head.Value;
            head = head.NextItem;
            count++;

            return value;
        }

        throw new InvalidOperationException("Queue is empty!");
    }

    public int Count
    {
        get { return count; }
    }

    private class QueueNode<T>
    {
        private T value;
        private QueueNode<T> nextItem;

        public QueueNode(T value)
        {
            this.value = value;
        }

        public QueueNode()
        {
        }

        public T Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public QueueNode<T> NextItem
        {
            get { return this.nextItem; }
            set { this.nextItem = value; }
        }
    }
}
