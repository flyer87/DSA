using System;
using System.Collections.Generic;
using System.Linq;

class PriorityQueue<T> where T : IComparable<T>
{
    private T[] items;
    private int currentFreeIndex;
    private int itemsCount;

    public PriorityQueue()
    {
        items = new T[32];
        currentFreeIndex = 0;
        itemsCount = 0;
    }

    public void Enqueue(T item)
    {
        if (currentFreeIndex == items.Length)
        {
            ResizeArray();
        }

        items[currentFreeIndex] = item;
        currentFreeIndex++;
        itemsCount++;

        // rebalance
        this.SiftUp();
    }

    public T Dequeue()
    {
        if (currentFreeIndex > 0)
        {
            T topItem = items[0];
            currentFreeIndex--;
            items[0] = items[currentFreeIndex];
            items[currentFreeIndex] = default(T);

            HeapifyDown();

            return topItem;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    private void SiftUp()
    {
        int currentItemIndex = currentFreeIndex - 1;
        while (currentItemIndex > 0)
        {
            int parentIndex = (currentItemIndex - 1) / 2;

            if (items[currentItemIndex].CompareTo(items[parentIndex]) > 0)
            {
                T temp = items[parentIndex];
                items[parentIndex] = items[currentItemIndex];
                items[currentItemIndex] = temp;
            }
            else
            {
                break;
            }

            currentItemIndex = parentIndex;
        }
    }

    private void HeapifyDown()
    {
        int i = 0;
        int leftIndex = 2 * i + 1;
        int rigthIndex = 2 * i + 2;

        while (leftIndex < currentFreeIndex && rigthIndex < currentFreeIndex)
        {
            int largestIndex = i;

            if (leftIndex < currentFreeIndex)
            {
                if (items[leftIndex].CompareTo(items[largestIndex]) > 0)
                {
                    largestIndex = leftIndex;
                }
            }

            if (rigthIndex < currentFreeIndex)
            {
                if (items[rigthIndex].CompareTo(items[largestIndex]) > 0)
                {
                    largestIndex = rigthIndex;
                }
            }

            if (largestIndex != i)
            {
                T buf = items[largestIndex];
                items[largestIndex] = items[i];
                items[i] = buf;
            }

            i++;
            leftIndex = 2 * i + 1;
            rigthIndex = 2 * i + 2;
        }
    }

    private void ResizeArray()
    {
        Array.Resize(ref items, items.Length * 2);
    }
}
