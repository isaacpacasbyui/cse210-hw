using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine(
                "There are no journal entries to display.");

            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile =
            new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(
                    entry.ToFileString());
            }
        }
    }

    public bool LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            return false;
        }

        List<Entry> loadedEntries =
            new List<Entry>();

        string[] lines =
            File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(
                new string[] { "~|~" },
                StringSplitOptions.None);

            if (parts.Length >= 4)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                string mood = parts[3];

                Entry entry = new Entry(
                    date,
                    prompt,
                    response,
                    mood);

                loadedEntries.Add(entry);
            }
        }

        _entries = loadedEntries;

        return true;
    }
}
