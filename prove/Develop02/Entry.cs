public class Entry {
    // 3. Entry
    // - random prompt displayed
    // - user entry accounted for such as input and time
    // - saved to the journal
    // - variables: string entryText (user inputs data), display option, string date, string promptText (displays prompt)
    public string _date;
    public string _promptText;
    public string _entryText;
    // A constructor is a special function which each class may contain,
    // and in order for a function to be a constructor, its name must 
    // match the name of the class in which it resides. 
    // The parameters of a class's constructor will be required upon object
    // creation outside of the class.
    public Entry(string date, string promptText, string entryText) {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }


    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt:");
        Console.WriteLine($"{_entryText}");
    }
}