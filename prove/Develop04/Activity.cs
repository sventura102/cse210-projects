using System.ComponentModel.DataAnnotations;

public class Activity {
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration) {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public static string DisplayStartingMessage() {
        string message = "Welcome!";
        return message;
    }

    public static string DisplayEndingMessage() {
        string message = "Thank you for participating. Have a great day!";
        return message;
    }

    public void ShowSpinner(int seconds){
    Console.Write("+");

    Thread.Sleep(500);

    Console.Write("\b \b"); // Erase the + character
    Console.Write("-"); // Replace it with the - character
    }

    public void ShowCountDown(int seconds) {
            DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(5);

    Thread.Sleep(3000);

    DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("We have not arrived at our future time yet..."); 
        }
    }
}