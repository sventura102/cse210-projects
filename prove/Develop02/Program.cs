using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select one of the following choices: \n1. Write \n2. Display \n3. Load \n4. Save\n5. Quit");
        
        string choice = Console.ReadLine();
        int number = int.Parse(choice);

        if (number == 1) {
            
        }
    }
}

// 1. Options class
// - display 5 questions
// - execute task based on user option
// - variables: string variable, convert int
//
// 2. randomPrompt class
// - If question already asked, do not repeat
// - Display questions
// - variables: list prompts, loop, display
//
// 3. Entry
// - random prompt displayed
// - user entry accounted for such as input and time
// - saved to the journal
// - variables: string entryText (user inputs data), display option, string date, string promptText (displays prompt)
//
// 4. Journal
// - saved to a file (the file itself) -> .csv file
// - able to load/save
// - display entries
// - add entry
// - variables: list journal, list entry