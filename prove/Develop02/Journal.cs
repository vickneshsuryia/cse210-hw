using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }


    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }


    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine(e.Date + "~|~" + e.Prompt + "~|~" + e.Response);
            }
        }

        Console.WriteLine("Journal saved successfully!\n");
    }


    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);
            Entry e = new Entry();
            e.Date = parts[0];
            e.Prompt = parts[1];
            e.Response = parts[2];
            _entries.Add(e);
        }

        Console.WriteLine("Journal loaded successfully!\n");
    }
}
