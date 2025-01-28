using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            var lines = File.ReadAllLines(file);
            foreach (var line in lines)
            {
                try
                {
                    _entries.Add(Entry.Parse(line));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error parsing entry: {ex.Message}");
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}