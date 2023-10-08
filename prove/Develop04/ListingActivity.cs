public class ListingActivity : Activity {
    private int _count;
    private List<string> _prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", 
    "Who are people that you have helped this week?", "What have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    public ListingActivity(string name, string description, int duration): base(name, description, duration) {}

    public void Run() {
        Console.Write(GetRandomPrompt());
        Console.Write(GetListFromUser());
    }

    public string GetRandomPrompt() {
        Random randNum = new Random();
        int RandomPos = randNum.Next(_prompts.Count);
        
        return $"{_prompts[RandomPos]}";
    }

    public string GetListFromUser() {
        Console.Write("Your Answer: ");
        string message = Console.ReadLine();
        return message;
    }
}