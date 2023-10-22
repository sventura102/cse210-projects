using System;
using System.Threading.Tasks.Dataflow;
using System.Diagnostics;

public class GoalManager {
    
    public List<Goals> _goals;

    public int _score;

    public static void Start() {

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Records Event");
        Console.WriteLine("6. Quit");

        string choice = Console.ReadLine();
        int number = int.Parse(choice);

        if (number == 1) {
            CreateGoal();
        }
        
        if (number == 2) {
            Console.WriteLine("Here are your goals:");
            ListGoalDetails();
        }

        if (number == 3) {
            Console.WriteLine("Goals Saved!");
        }

        if (number == 4) {
            LoadGoals();
        }

        if (number == 5) {
            RecordEvent();
            Console.WriteLine("Events Recorded!");
        }

        if (number == 6) {
            return;
        }


    }

    public static void DisplayPlayerInfo() {

    }

    public void ListGoalNames() {
        int count = 0;
        foreach (Goals item in _goals) {
            count++;
            string name = item._shortName;
            Console.Write($"{count}. {name}");
        }
    }
    public static void ListGoalDetails() {

    }

    public static void CreateGoal() {
        Console.Write("The types of Goals are: \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
        Console.WriteLine("What type of goal would you like to create?");

        string choice = Console.ReadLine();
        int number = int.Parse(choice);
        //Simple Goal
        if (number == 1) {
            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a description of your goal?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with your goal?");
            string points = Console.ReadLine();
            SaveGoals(name, description, points);
        }
        //Eternal Goal
        if (number == 2) {
            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a description of your goal?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with your goal?");
            string points = Console.ReadLine();
            SaveGoals(name, description, points);
        }
        //Checklist
        if (number == 3) {
            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a description of your goal?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with your goal?");
            string points = Console.ReadLine();
            Console.WriteLine("How many times does this goal need to be completed for a bonus?");
            string amount1 = Console.ReadLine();
            int amountCompleted = Convert.ToInt32(amount1);
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            string amount2 = Console.ReadLine();
            int bonus = Convert.ToInt32(amount2);
            SaveGoals(name, description, points);
        }
    }

    public static void RecordEvent() {

    }

    public static void SaveGoals(string name, string description, string points) {
        Console.Write("Enter File Name:");
        var File = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(File))
        {
            outputFile.WriteLine($"{name} - {description} - [{points}]");
        }

        Console.WriteLine("Goals Saved!");
    }

    public static void LoadGoals() {
        Console.WriteLine("Enter File Name:");
        string File = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(File);
        foreach (string line in lines) 
        {
            string[] parts = line.Split(",");
        }
    }
}