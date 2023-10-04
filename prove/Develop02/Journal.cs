public class Journal {
    public static List<Entry> _entries = new List<Entry>();
    public List<Journal> journal = new List<Journal>();

    public static void AddEntry(string _date, string _promptText, string _textEntry){
        Entry entry1 = new Entry(_date, _promptText,_textEntry);
        _entries.Add(entry1);
    }

    public static void DisplayAll()
    {
        for (int i = 0; i < _entries.Count; i++){
            Console.WriteLine($"{i + 1}.{_entries[i]._date} - {_entries[i]._entryText}");
        }
    }

    public static void SaveToFile(string file, string date, string promptText,
        string entryText)
    {
        Console.Write("Enter File Name:");
        file = Console.ReadLine();
        
        // From instructions
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(date);
            outputFile.WriteLine(promptText);
            outputFile.WriteLine(entryText);
        }
    }
    public static void LoadFromFile(string file)
    {
        Console.WriteLine("Enter File Name:");
        file = Console.ReadLine();

        // From instructions
        // Step 1: get all the lines
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    string firstName = parts[0];
                    string lastName = parts[1];
                }
            }
        // Create variables and set them to their proper pieces

        // Create a new entry
    }
