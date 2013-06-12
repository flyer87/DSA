using System;
using System.Collections.Generic;

public class MyStack<T>
{
    private int defaultSize = 2;
    private T[] items;
    private int top;

    public MyStack()
    {
        this.items = new T[defaultSize];
        this.top = -1;
    }

    public T Pop()
    {
        if (top >= 0)
        {
            top--;
            return items[top + 1];
        }
        else
        {
            throw new ArgumentOutOfRangeException("Empty stack");
        }
    }

    public void Push(T item)
    {
        if (top == items.Length - 1)
        {
            ExtendArray();
        }

        items[top + 1] = item;
        top++;
    }

    public T Peak()
    {
        return items[top];
    }

    private void ExtendArray()
    {
        Array.Resize<T>(ref items, items.Length * 2);
    }
}
