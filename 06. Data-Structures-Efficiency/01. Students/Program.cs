using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        SortedDictionary<string, SortedSet<string>> courses =
            new SortedDictionary<string, SortedSet<string>>();

        string filePath = @"../../students.txt";
        StreamReader inputFile = new StreamReader(filePath);
        using (inputFile)
        {
            string line = inputFile.ReadLine();
            while (line != null)
            {
                string[] data = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string courseName = data[2].Trim();
                string firstName = data[0].Trim();
                string lastName = data[1].Trim();

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new SortedSet<string>() { lastName + " " + firstName });
                }
                else
                {
                    courses[courseName].Add(lastName + " " + firstName);
                }

                line = inputFile.ReadLine();
            }
        }

        foreach (var course in courses)
        {
            Console.Write("{0}: ", course.Key);
            foreach (string student in course.Value)
            {
                Console.Write("{0}, ", student);
            }

            Console.WriteLine();
        }
    }
}
