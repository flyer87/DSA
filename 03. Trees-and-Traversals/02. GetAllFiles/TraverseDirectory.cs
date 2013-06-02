using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public static class TraverseDirectory
{
    private static List<string> allFiles = new List<string>();

    public static void PrintFiles(string dir, string extension)
    {
        TraverseDirectories(dir, extension);

        StringBuilder output = new StringBuilder();
        foreach (var file in allFiles)
        {
            output.AppendLine(file);
        }

        Console.WriteLine(output.ToString());
    }

    private static void TraverseDirectories(string currentDir, string fileExtension)
    {
        int defSize = 100;
        string[] files = new string[defSize];
        try
        {
            files = Directory.GetFiles(currentDir, fileExtension);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Directory {0} CAN NOT be accessed", currentDir);
            return;
        }

        allFiles.AddRange(files);

        string[] subDirs = Directory.GetDirectories(currentDir);
        foreach (string dir in subDirs)
        {
            TraverseDirectories(dir, fileExtension);
        }
    }
}
