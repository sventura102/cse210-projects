public class Entry {
    // 3. Entry
    // - random prompt displayed
    // - user entry accounted for such as input and time
    // - saved to the journal
    // - variables: string entryText (user inputs data), display option, string date, string promptText (displays prompt)
    public string _date;
    public string _promptText;
    public string _entryText;
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt:");
        Console.WriteLine($"{_entryText}");
    }
}