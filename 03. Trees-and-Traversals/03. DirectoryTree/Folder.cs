using System;
using System.Collections.Generic;
using System.IO;

public class Folder
{
    public Folder(string name)
    {
        this.Name = name;
        this.Files = new File[0];
        this.Subfolders = new Folder[0];
    }

    public string Name { get; set; }

    public File[] Files { get; set; }

    public Folder[] Subfolders { get; set; }

    public void CreateSubfolders(IEnumerable<string> subfolderNames)
    {
        List<Folder> subfolders = new List<Folder>();
        foreach (string subfolderName in subfolderNames)
        {
            Folder newFolder = new Folder(subfolderName);
            subfolders.Add(newFolder);
        }

        this.Subfolders = subfolders.ToArray();
    }

    public void CreateFiles(IEnumerable<string> filesnames)
    {
        List<File> files = new List<File>();
        foreach (string filename in filesnames)
        {
            FileInfo fileInfo = new FileInfo(filename);
            File newFile = new File(filename, fileInfo.Length);
            
            files.Add(newFile);
        }

        this.Files = files.ToArray();
    }
}
