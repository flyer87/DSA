using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        decimal minPrice = 1;
        decimal maxPrice = 5;
        int maxItemsCount = 20;
        int numberOfItem = 1000010;

        OrderedBag<Product> products = new OrderedBag<Product>();

        AddProducts(numberOfItem, products);

        var productsInRange =
            products.Range(new Product("unusedItem", minPrice), true, new Product("unusedItem", maxPrice), true);

        List<Product> firstNItemsInRange = new List<Product>(maxItemsCount);
        for (int i = 0; i < productsInRange.Count && i < maxItemsCount; i++)
        {
            firstNItemsInRange.Add(productsInRange[i]);
        }
    }

    private static void AddProducts(int numberOfItem, OrderedBag<Product> products)
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        
        Random random = new Random();
        for (int i = 1; i <= numberOfItem; i++)
        {
            products.Add(new Product(i.ToString(), random.Next(1, 10)));
        }

        timer.Stop();
        int ms = timer.Elapsed.Seconds;
    }
}
