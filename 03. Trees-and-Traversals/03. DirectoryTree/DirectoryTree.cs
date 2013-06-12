using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

public static class DirectoryTree
{
    private static BigInteger sum = 0;

    public static void CreateTree(Folder folder)
    {
        IEnumerable<string> subFolderNames = Directory.EnumerateDirectories(folder.Name);
        folder.CreateSubfolders(subFolderNames);

        IEnumerable<string> filesnames = Directory.EnumerateFiles(folder.Name);
        folder.CreateFiles(filesnames);

        foreach (Folder subfolder in folder.Subfolders)
        {
            try
            {
                CreateTree(subfolder);
            }
            catch (Exception)
            {
                continue;
            }
        }
    }

    public static void PrintTree(Folder folder, string spaces)
    {
        Console.WriteLine(spaces + folder.Name);
        foreach (var subfolder in folder.Subfolders)
        {
            PrintTree(subfolder, spaces + " ");
        }

        foreach (var file in folder.Files)
        {
            Console.WriteLine(spaces + " " + file.Name + " " + file.Size);
        }
    }

    public static BigInteger GetAllFileSize(Folder folder)
    {
        if (folder.Files.Length == 0)
        {
            return 0;
        }

        foreach (var file in folder.Files)
        {
            sum += file.Size;
        }

        foreach (var subFolder in folder.Subfolders)
        {
            sum += GetAllFileSize(subFolder);
        }

        return sum;
    }
}