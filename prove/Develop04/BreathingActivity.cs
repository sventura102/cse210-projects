public class BreathingActivity : Activity {
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration) {}

    public static void Run() {
        Console.Write("Breath in...");
        ShowCountDown(30);
        ShowSpinner(30);
        Console.Write("Breath out...");
    }
}