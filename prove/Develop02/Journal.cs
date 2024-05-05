// EXCEEDS CORE REQUIREMENTS: Displays the number of journal entries.

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        // EXCEEDS CORE: Displays how many entries the user has in the journal
        Console.WriteLine($"\nYou have {_entries.Count} journal entries: ");

        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }
    public void SaveToFile(string file)
    {
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