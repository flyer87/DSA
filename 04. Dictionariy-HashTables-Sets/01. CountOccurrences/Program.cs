using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double[] doubleArray = new double[10] { 2, 5.2, 6.3, 5.2, 5.2, 6, 8.54, 6.32, 7.5, 1.25 };
        Dictionary<double, int> doublesCount = new Dictionary<double, int>();

        for (int i = 0; i < doubleArray.Length; i++)
        {
            if (!doublesCount.ContainsKey(doubleArray[i]) )
            {
                doublesCount.Add(doubleArray[i], 1);                
            }
            else
            {
                doublesCount[doubleArray[i]]++;
            }
        }

        foreach (var number in doublesCount)
        {
            Console.WriteLine("{0} => {1} times", number.Key, number.Value);
        }
    }
}
