public class Journal {
    public List<Entry> _entries = new List<Entry>();

    // 4. Journal
    // - saved to a file (the file itself) -> .csv file
    // - able to load/save
    // - display entries
    // - add entry
    // - variables: list journal, list entry
    public void AddEntry(string _date, string _textEntry){
        _entries.Add($"{_date} {_textEntry}");
    }

    public void DisplayAll()
    {
        for (int i = 0; i < _entries.Count; i++){
            Console.WriteLine($"{i + 1}.{_entries[i]._date} - {_entries[i]._entryText}");
        }
    }

    public void SaveToFile(string file)
    {
        Console.Write("Enter File Name:");
        file = Console.ReadLine();
        SaveToFile(journalFile, file);
    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine("Enter File Name:");
        file = Console.ReadLine();
        journalFile = LoadFromFile(file);
    }
}