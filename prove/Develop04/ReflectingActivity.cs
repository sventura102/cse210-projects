public class ReflectingActivity : Activity {
    private static List<string> _prompts = new List<string> {"Think of a time when you stood up for someone else.", 
    "Think of a time you did something really difficult.", "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."};
    private static List<string> _questions = new List<string> {"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?",
    "What could you learn from this experience?", "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"};

    public ReflectingActivity(string name, string description, int duration) : 
    base(name, description, duration) {

    }

    public static void Run() {
        GetRandomPrompt();
        GetRandomQuestion();
    }

    public static string GetRandomPrompt() {
        Random randNum = new Random();
        int RandomPos = randNum.Next(_prompts.Count);
        
        return $"{_prompts[RandomPos]}";
    }

    public static string GetRandomQuestion() {
        Random randNum = new Random();
        int RandomPos = randNum.Next(_questions.Count);
        
        return $"{_questions[RandomPos]}";
    }
}