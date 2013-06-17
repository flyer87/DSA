namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (this.items[i].CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            int minIndex = 0;
            int maxIndex = this.items.Count - 1;
            while (maxIndex >= minIndex)
            {
                int middleIndex = (maxIndex + minIndex) / 2;

                if (item.CompareTo(items[middleIndex]) < 0)
                {
                    maxIndex = middleIndex - 1;
                }
                else if (item.CompareTo(items[middleIndex]) > 0)
                {
                    minIndex = middleIndex + 1;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < items.Count; i++)
            {
                int randomIndex = random.Next(i, items.Count);
                T temp = items[i];                
                items[i] = items[randomIndex];
                items[randomIndex] = temp;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
