using System;

class Program
{
    static void Main(string[] args)
    {
        bool Menu = true;
        while (Menu) {
            Menu = MainMenu();
        }
    }
    public static bool MainMenu() {
    Console.Clear();
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Breathing Activity");
    Console.WriteLine("2. Listing Activity");
    Console.WriteLine("3. Reflecting Activity");
    Console.WriteLine("4. Exit");

    string startMessage = Activity.DisplayStartingMessage();
    string endMessage = Activity.DisplayEndingMessage();
    
    switch (Console.ReadLine()) {
        case "1":
            BreathingActivity a1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", 30);
            Console.WriteLine(startMessage);
            Console.WriteLine(a1);
            BreathingActivity.Run();
            Console.WriteLine(endMessage);
            return true;
        case "2": 
            ListingActivity a2 = new ListingActivity("Listing Activity", "his activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 30);
            Console.WriteLine(startMessage);
            Console.WriteLine(a2);
            ListingActivity.Run();
            Console.WriteLine(endMessage);
            return true;
        case "3":
            ReflectingActivity a3 = new ReflectingActivity("Reflecting Activity", "his activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 30);
            Console.WriteLine(startMessage);
            ReflectingActivity.Run();
            Console.WriteLine(endMessage);
            return true;
        case "4":
            return false;
    }
}
    
}