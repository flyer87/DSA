using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

class Program
{
    static void Main(string[] args)
    {
        OrderedMultiDictionary<decimal, Article> priceArticles =
            new OrderedMultiDictionary<decimal, Article>(true);

        decimal minPrice = 7;
        decimal maxPrice = 8;

        Random randomGen = new Random();

        for (int i = 0; i < 1000; i++)
        {
            Article article = new Article("Barcode" + (i + 1), "Vendor" + (i + 1), "Article" + (i + 1),
                randomGen.Next(1,11) );
            if (!priceArticles.ContainsKey(article.Price))
            {
                priceArticles.Add(article.Price, article);
            }
            else
            {
                priceArticles[article.Price].Add(article);
            }
        }

        PrintArticles(priceArticles, minPrice, maxPrice);
    }

    private static void PrintArticles(OrderedMultiDictionary<decimal, Article> priceArticles, decimal minPrice, decimal maxPrice)
    {
        Console.WriteLine("Range: {0} - {1} BGN: ", minPrice, maxPrice);
        foreach (var item in priceArticles)
        {
            if (item.Key >= minPrice && item.Key <= maxPrice)
            {
                Console.Write("  {0} BGN: ", item.Key);
                foreach (Article article in item.Value)
                {
                    Console.Write(article.Title + ", ");
                }

                Console.WriteLine();
            }
        }
    }
}
