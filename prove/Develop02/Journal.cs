using System.IO;
using System.IO.Enumeration;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }
    public void SaveToFile(string file)
    {
        // Console.Write("What is the file name?");
        // string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"Date: {e._date} | Prompt: {e._promptText} | {e._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        // Console.Write("What is the file name? ");
        // string file = Console.ReadLine();
        
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            };
            _entries.Add(entry);
        }
    }

}