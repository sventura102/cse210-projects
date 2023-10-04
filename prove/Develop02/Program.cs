using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static Journal journal = new Journal();
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
            //This allows user to add text but doesn't let them type
            //unless they press enter again
            Console.WriteLine(PromptGen.GetRandomPrompt());
            string prompt = Console.ReadLine();
            DateTime theCurrentTime = DateTime.Now;
            string date = theCurrentTime.ToShortDateString();   
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            Journal.AddEntry(date, prompt, text);
        }

        if (number == 2) {
            Journal.DisplayAll();
        }

        if (number == 3) {
            Console.WriteLine("Enter File Name:");
            string file = Console.ReadLine();
            Journal.LoadFromFile(file);
        }

        if (number == 4) {
            Console.WriteLine("Enter File Name:");
            string file = Console.ReadLine();
            Journal.LoadFromFile(file);
        }

        if (number == 5) {
            return;
        }
    }
}