using System;
using System.Collections.Generic;

internal class MyLinkedList<T>
{
    private ListItem<T> head = null;
    private int count;

    public int Count { get { return count; } }

    public void AddFirst(T item)
    {
        ListItem<T> newListItem = new ListItem<T>(item);

        if (head == null)
        {
            head = newListItem;
        }
        else
        {
            newListItem.NextItem = head;
            head = newListItem;
        }

        count++;
    }

    public void AddLast(T item)
    {
        ListItem<T> newListItem = new ListItem<T>(item);

        if (head == null)
        {
            head = newListItem;
        }
        else
        {
            ListItem<T> currentItem = this.head;
            while (currentItem.NextItem != null)
            {
                currentItem = currentItem.NextItem;
            }

            currentItem.NextItem = newListItem;
        }

        count++;
    }

    public void RemoveFirst()
    {
        if (head != null)
        {
            this.head = head.NextItem;
            count--;
        }
    }

    public void RemoveLast()
    {
        if (head == null)
        {
            return;
        }

        if (head.NextItem == null)
        {
            head = null;
        }

        if (head.NextItem != null)
        {
            ListItem<T> lastItem = head;

            while (lastItem.NextItem != null)
            {
                lastItem = lastItem.NextItem;
            }

            ListItem<T> currentItem = this.head;
            while (currentItem.NextItem != lastItem)
            {
                currentItem = currentItem.NextItem;
            }

            currentItem.NextItem = null;
            count--;
        }
    }

    public void AddBefore(T item)
    {
        throw new NotImplementedException();
    }

    public void AddAfter(T item)
    {
        throw new NotImplementedException();
    }

    private class ListItem<T>
    {
        private T value;
        private ListItem<T> nextItem;

        public T Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public ListItem<T> NextItem
        {
            get { return nextItem; }
            set { this.nextItem = value; }
        }

        public ListItem(T value, ListItem<T> nextItem = null)
        {
            this.Value = value;
            this.NextItem = nextItem;
        }

        public ListItem(T item)
        {
            this.value = item;
            this.nextItem = null;
            // TODO: Complete member initialization
        }
    }
}
