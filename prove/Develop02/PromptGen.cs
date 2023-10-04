using System;
using System.Security.Cryptography;
// 2. randomPrompt class
// - If question already asked, do not repeat
// - Display questions
// - variables: list prompts, loop, display
public class PromptGen {
    public static List<string> _prompts = new List<string> {"List three things you're grateful for today.", "Write about a song and what it made you feel.", 
    "What color do you feel like and why?", "What was the best part of my day?", "If I had one thing I could do over today, what would it be?"};

    public static string GetRandomPrompt() {
        Random randNum = new Random();
        int RandomPos = randNum.Next(_prompts.Count);
        
        string randomPrompt = _prompts[RandomPos];
        return randomPrompt;
    }
    }
