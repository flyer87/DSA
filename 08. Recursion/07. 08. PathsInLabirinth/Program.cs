using System;
using System.Collections.Generic;

class Program
{
    private static char[,] labyrinth = 
    {
        {' ', ' ', ' ', '*', ' ', ' ', ' '},
        {'*', '*', ' ', '*', ' ', '*', ' '},
        {' ', ' ', ' ', ' ', ' ', ' ', ' '},
        {' ', '*', '*', '*', '*', '*', ' '},
        {' ', ' ', ' ', ' ', ' ', ' ', ' '},
    };

    private static Stack<KeyValuePair<int, int>> path = new Stack<KeyValuePair<int, int>>();
    private static bool pathIsFound = false;

    static void Main(string[] args)
    {
        // Task 8.
        // SetExit(0, 4);
        HasPathBetweenTwoCells(0, 0);

        // Task.7 
        //SetExit(0, 4);
        // AllPathsBetweenTwoCells(0, 0);

        if (!pathIsFound)
        {
            Console.WriteLine("There is no path!");
        }
    }

    private static void AllPathsBetweenTwoCells(int row, int col)
    {
        if (!InRange(row, col))
        {
            return;
        }

        if (labyrinth[row, col] == 'e')
        {
            PrintPath();
            return;
        }

        if (labyrinth[row, col] != ' ')
        {
            return;
        }

        labyrinth[row, col] = 'v';
        path.Push(new KeyValuePair<int, int>(row, col));

        AllPathsBetweenTwoCells(row, col + 1);
        AllPathsBetweenTwoCells(row - 1, col);
        AllPathsBetweenTwoCells(row, col - 1);
        AllPathsBetweenTwoCells(row + 1, col);

        labyrinth[row, col] = ' ';
        path.Pop();
    }

    private static void HasPathBetweenTwoCells(int row, int col)
    {
        if (pathIsFound)
        {
            return;
        }

        if (!InRange(row, col))
        {
            return;
        }

        if (labyrinth[row, col] == 'e')
        {
            PrintPath();
            pathIsFound = true;
            return;
        }

        if (labyrinth[row, col] != ' ')
        {
            return;
        }

        labyrinth[row, col] = 'v';
        path.Push(new KeyValuePair<int, int>(row, col));

        HasPathBetweenTwoCells(row, col + 1);
        HasPathBetweenTwoCells(row - 1, col);
        HasPathBetweenTwoCells(row, col - 1);
        HasPathBetweenTwoCells(row + 1, col);

        labyrinth[row, col] = ' ';
        path.Pop();
    }

    static bool InRange(int row, int col)
    {
        bool rowInRange = row >= 0 && row < labyrinth.GetLength(0);
        bool colInRange = col >= 0 && col < labyrinth.GetLength(1);
        return rowInRange && colInRange;
    }

    private static void PrintPath()
    {
        KeyValuePair<int, int>[] pathArray = path.ToArray();
        Array.Reverse(pathArray);
        Console.WriteLine(string.Join(",", pathArray));
    }

    private static void SetExit(int row, int col)
    {
        labyrinth[row, col] = 'e';
    }
}
