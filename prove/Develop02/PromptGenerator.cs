using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What is one thing that made you smile today?",

        "What challenge did you face today, and how did you respond?",

        "Who helped you today, and what did they do?",

        "What is something important you learned today?",

        "What are you most grateful for today?",

        "What is one thing you would like to improve tomorrow?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index =
            _random.Next(_prompts.Count);

        return _prompts[index];
    }
}