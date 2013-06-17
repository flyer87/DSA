using System;
using System.Collections.Generic;
using System.Linq;

class HashTable<K, T>
{
    private LinkedList<KeyValuePair<K, T>>[] container;    
    private int itemsCount;

    public HashTable()
    {
        container = new LinkedList<KeyValuePair<K, T>>[16];
        itemsCount = 0;
    }

    public void Add(K key, T value)
    {
        if (key == null)
        {
            throw new ArgumentNullException("Key cannot be null!");
        }

        if (value == null)
        {
            throw new ArgumentNullException("Value cannot be null!");
        }

        if (itemsCount >= this.container.Length * 3 / 4)
        {
            ResizeHashTable();
        }

        int index = Math.Abs(key.GetHashCode() % this.container.Length);
        if (this.container[index] == null)
        {
            this.container[index] = new LinkedList<KeyValuePair<K, T>>();
        }

        this.container[index].AddLast(new KeyValuePair<K, T>(key, value));
        this.itemsCount++;        
    }

    private void ResizeHashTable()
    {
        throw new NotImplementedException();
    }
}
