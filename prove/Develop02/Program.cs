using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        // 1. Options class
        // - display 5 questions
        // - execute task based on user option
        // - variables: string variable, convert int
        Console.WriteLine("Please select one of the following choices: \n1. Write \n2. Display \n3. Load \n4. Save\n5. Quit");

        string choice = Console.ReadLine();
        int number = int.Parse(choice);

        if (number == 1) {
            Entry entry = new Entry();
            entry._date = "9/23/2023";
            entry._promptText = 
        }
    }
}