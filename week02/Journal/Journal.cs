//needs to add an entry, display all entries, save current entries, and load entries from a different file. 
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    private string GetFullPath(string filename)
    {
        // If the user enters just a filename, put it in Documents
        string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        return Path.Combine(documents, filename);
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToCsv(string filename)
    {
        string fullPath = GetFullPath(filename);

        using (StreamWriter writer = new StreamWriter(fullPath))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"\"{entry.Date}\",\"{entry.Prompt}\",\"{entry.Response}\"");
            }
        }

        Console.WriteLine($"Journal saved to: {fullPath}");
    }

    public void LoadFromCsv(string filename)
    {
        _entries.Clear();
        string fullPath = GetFullPath(filename);

        if (File.Exists(fullPath))
        {
            string[] lines = File.ReadAllLines(fullPath);
            foreach (string line in lines)
            {
                var parts = line.Split("\",\"");
                if (parts.Length == 3)
                {
                    string date = parts[0].Trim('\"');
                    string prompt = parts[1].Trim('\"');
                    string response = parts[2].Trim('\"');

                    _entries.Add(new Entry(date, prompt, response));
                }
            }
            Console.WriteLine($"Journal loaded from: {fullPath}");
        }
        else
        {
            // Create an empty file if it doesn't exist
            using (File.Create(fullPath)) { }
            Console.WriteLine($"File not found. A new file was created at: {fullPath}");
        }
    }
}



