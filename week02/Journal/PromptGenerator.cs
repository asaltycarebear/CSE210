//Class for providing prompts when a user selects an entry. 
using System;
using System.Collections.Generic; //added so I don't have to prefface my lists with it. 

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are you proud you did today?",
        "Do you have an idea?",
        "What could you do to improve your life tomorrow?",
        "What do you regret today, and how can you do better tomorrow?",
        "Could you find a way to lift anothers burden tomorrow?",
        "How did you get better today?",
    };
    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}