using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        string rootDir = @"C:\Windows";
        string extension = "*.exe";

        TraverseDirectory.PrintFiles(rootDir, extension);
    }
}
