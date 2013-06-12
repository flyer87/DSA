using System;
using System.Collections.Generic;
using System.Linq;

class HashTable<K, T>
{
    private LinkedList<KeyValuePair<K, T>>[] container = new LinkedList<KeyValuePair<K, T>>[16];
}
