using System;
using System.Collections.Generic;

class Loop
{
    static void Simulate(int[] vector, int lenght, int index)
    {
        if (index == lenght)
        {
            Print(index, vector);
            return;
        }

        for (int j = 0; j < lenght; j++)
        {
            vector[index] = j;
            Simulate(vector, lenght, index + 1);
        }
    }

    private static void Print(int length, int[] vector)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write("{0} ", vector[i] + 1);
        }

        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        const int lenght = 4;
        int[] taken = new int[lenght];

        Simulate(taken, lenght, 0);
    }
}
