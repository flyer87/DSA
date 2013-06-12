using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string directoryName = @"C:\Program Files\Intel\TVWiz2ft";
        Folder folder = new Folder(directoryName);

        DirectoryTree.CreateTree(folder);
        DirectoryTree.PrintTree(folder, string.Empty);
        Console.WriteLine(DirectoryTree.GetAllFileSize(folder));
    }
}
