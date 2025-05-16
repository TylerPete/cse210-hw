using System.IO;

public class Journal()
{
    public List<Entry> _entries = new List<Entry>();

    public void SaveToFile(string fileName)
    {
        using (StreamWriter saveFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                saveFile.WriteLine($"{entry._date} ~ {entry._prompt}");
                saveFile.WriteLine(entry._response);
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        string[] journalLines = File.ReadAllLines(fileName);

        for (int index = 0; index < journalLines.Length; index += 2)
        {
            string[] pieces = journalLines[index].Split("~");

            string response = journalLines[index + 1];

            Entry newEntry = new Entry();
            newEntry._date = pieces[0].Trim();
            newEntry._prompt = pieces[1].Trim();
            newEntry._response = response;

            _entries.Add(newEntry);
        }
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
}