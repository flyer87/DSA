using System;

public class Product : IComparable
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    public Product(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public int CompareTo(object obj)
    {
        return this.Price.CompareTo(((Product)obj).Price);
    }
}
