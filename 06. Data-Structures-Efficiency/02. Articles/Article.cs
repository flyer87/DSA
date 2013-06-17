using System;

public class Article : IComparable
{
    public string Barcode { get; private set; }
    public string Vendor { get; private set; }
    public string Title { get; private set; }
    public decimal Price { get; private set; }

    public Article(string barcode, string vendor, string title, decimal price)
    {
        this.Barcode = barcode;
        this.Vendor = vendor;
        this.Title = title;
        this.Price = price;
    }

    public int CompareTo(object obj)
    {
        return this.Barcode.CompareTo(((Article)obj).Barcode);
    }
}