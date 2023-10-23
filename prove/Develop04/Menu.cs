using System;
using System.Threading.Tasks.Dataflow;
using System.Diagnostics;
public class Menu {
    
    static string startMessage = Activity.DisplayStartingMessage();
    static string endMessage = Activity.DisplayEndingMessage();
    public static void Main1() {
            Console.Clear();

            Console.WriteLine(startMessage);
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();
            int number = int.Parse(choice);

            if (number == 1) {
                BreathingActivity a1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", 30);
                Console.WriteLine(a1);
                BreathingActivity.Run();
                Console.WriteLine(endMessage);
                return;
            }

            if (number == 2) {
                ListingActivity a2 = new ListingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", 30);
                Console.WriteLine(a2);
                ListingActivity.Run();
                Console.WriteLine(endMessage);
                return;

            }

            if (number == 3) {
                ReflectingActivity a3 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 30);
                Console.WriteLine(a3);
                ReflectingActivity.Run();
                Console.WriteLine(endMessage);
                return;
            }

            if (number == 4) {
                Console.Clear();
                return;
            }

    }
}